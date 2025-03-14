using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;

namespace WooPharmacyPOS
{
    public partial class Dashboard : Form
    {
        private decimal productPrice = 0; // Holds product price
        private int stockAvailable = 0;   // Holds stock quantity

        // Variables to store receipt details
        private string receiptProductName = "";
        private string receiptQuantity = "";
        private string receiptTotalPayment = "";
        private string receiptPaymentGiven = "";
        private string receiptChange = "";

        // List of quotes for logout
        private readonly List<string> _quotes = new List<string>
        {
            "Success is not final, failure is not fatal: It is the courage to continue that counts. – Winston Churchill",
            "The only way to do great work is to love what you do. – Steve Jobs",
            "Believe you can and you're halfway there. – Theodore Roosevelt",
            "Strive not to be a success, but rather to be of value. – Albert Einstein",
            "The best time to plant a tree was 20 years ago. The second best time is now. – Chinese Proverb",
            "Your time is limited, don't waste it living someone else's life. – Steve Jobs",
            "The only limit to our realization of tomorrow is our doubts of today. – Franklin D. Roosevelt",
            "Do what you can, with what you have, where you are. – Theodore Roosevelt",
            "The future belongs to those who believe in the beauty of their dreams. – Eleanor Roosevelt",
            "It always seems impossible until it's done. – Nelson Mandela"
        };

        private string connectionString; // Connection string from App.config

        public Dashboard()
        {
            InitializeComponent();

            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["WooPharmacyDBConnection"].ConnectionString;

            // Configure ComboBox auto-completion
            cmbProductSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProductSearch.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Load products into DataGridView and ComboBox
            LoadProductsIntoDataGridView();
            LoadProductList();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with products
            LoadProductList();

            // Set default date for DateTimePicker controls
            dateTimePickerDailyReport.Value = DateTime.Now;
            dateTimePickerMonthlyReport.Value = DateTime.Now;

            // Check for expiring products
            CheckForExpiringProducts();
        }

        private void LoadProductList()
        {
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT ID, Name FROM Products"; // Fetch both ID and Name

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the ComboBox
                cmbProductSearch.DataSource = dt;
                cmbProductSearch.DisplayMember = "Name"; // Column to display
                cmbProductSearch.ValueMember = "ID";     // Column to use as the value
            }
        }

        private void LoadProductsIntoDataGridView()
        {
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT ID, Name, Price, Stock, ExpirationDate FROM Products"; // Include ExpirationDate

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                dgvProductList.DataSource = dt;
            }
        }

        private void cmbProductSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a product is selected, update the price, stock, and ProductID
            if (cmbProductSearch.SelectedItem != null)
            {
                // Get the selected product's ID and Name
                string selectedProductID = cmbProductSearch.SelectedValue?.ToString(); // Use SelectedValue for ID
                string selectedProductName = cmbProductSearch.Text; // Use Text for Name

                if (!string.IsNullOrEmpty(selectedProductID))
                {
                    // Set the ProductID in the label
                    lblProductID.Text = selectedProductID;

                    // Update the price and stock
                    productPrice = GetProductPrice(selectedProductName);
                    stockAvailable = GetProductStock(selectedProductName);

                    // Update the product name in the textbox (if needed)
                    cmbProductSearch.Text = selectedProductName;
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                if (quantity > stockAvailable)
                {
                    MessageBox.Show("Not enough stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Text = stockAvailable.ToString();
                }
                // Format currency as PHP
                lblTotalPayment.Text = (productPrice * quantity).ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));
            }
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (string.IsNullOrWhiteSpace(cmbProductSearch.Text))
            {
                MessageBox.Show("Select a product first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the quantity
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the product is expired
            DateTime expirationDate = GetProductExpirationDate(cmbProductSearch.Text);
            if (expirationDate < DateTime.Now)
            {
                MessageBox.Show("This product is expired and cannot be sold!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the payment amount
            if (!decimal.TryParse(txtPaymentAmount.Text, out decimal paymentGiven) || paymentGiven <= 0)
            {
                MessageBox.Show("Enter a valid payment amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate total payment for the single product
            decimal totalPayment = productPrice * quantity;

            // Check if payment is sufficient
            if (paymentGiven < totalPayment)
            {
                MessageBox.Show("Insufficient payment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate change
            decimal change = paymentGiven - totalPayment;
            // Format currency as PHP
            lblChange.Text = change.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));

            // Store receipt details
            receiptProductName = cmbProductSearch.Text;
            receiptQuantity = txtQuantity.Text;
            receiptTotalPayment = lblTotalPayment.Text;
            receiptPaymentGiven = txtPaymentAmount.Text;
            receiptChange = lblChange.Text;

            // Proceed with saving the transaction and reducing stock
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // Start transaction

                try
                {
                    // Insert the sale into the Sales table
                    string query = "INSERT INTO Sales (ProductID, Quantity, TotalPrice, Date) VALUES (@ProductID, @qty, @total, @date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", lblProductID.Text); // Use the ProductID from the selected product
                        cmd.Parameters.AddWithValue("@qty", quantity); // Quantity from the input field
                        cmd.Parameters.AddWithValue("@total", totalPayment); // Total payment for the product
                        cmd.Parameters.AddWithValue("@date", DateTime.Now); // Current date and time
                        cmd.ExecuteNonQuery();
                    }

                    // Reduce stock after purchase
                    string updateStockQuery = "UPDATE Products SET Stock = Stock - @qty WHERE ID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(updateStockQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", lblProductID.Text); // Use the ProductID from the selected product
                        cmd.Parameters.AddWithValue("@qty", quantity); // Quantity from the input field

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Failed to update stock. Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Commit the transaction if everything is successful
                    transaction.Commit();
                    MessageBox.Show($"Transaction Successful!\nChange: {change.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"))}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView to reflect the updated stock
                    LoadProductsIntoDataGridView();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an error occurs
                    transaction.Rollback();
                    MessageBox.Show("Transaction failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Check if a transaction has been processed
            if (string.IsNullOrEmpty(receiptProductName))
            {
                MessageBox.Show("No transaction to print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate pop-up receipt
            ShowReceiptPopup();

            // Reset the form after printing the receipt
            ResetForm();
        }

        private void ShowReceiptPopup()
        {
            // Create a pop-up form to display the receipt
            Form receiptForm = new Form();
            receiptForm.Text = "WooPharmacy POS Receipt";
            receiptForm.Size = new System.Drawing.Size(300, 300);

            // Create a RichTextBox to display the receipt details
            RichTextBox receiptText = new RichTextBox();
            receiptText.ReadOnly = true;
            receiptText.Dock = DockStyle.Fill;
            receiptText.Font = new System.Drawing.Font("Arial", 12);

            // Add receipt details to the RichTextBox
            receiptText.Text =
                "WooPharmacy POS Receipt\n" +
                "----------------------------------\n" +
                $"Product: {receiptProductName}\n" +
                $"Quantity: {receiptQuantity}\n" +
                $"Total: {receiptTotalPayment}\n" +
                $"Payment Given: {receiptPaymentGiven}\n" +
                $"Change: {receiptChange}\n" +
                "----------------------------------\n" +
                "Thank you for your purchase!";

            // Add the RichTextBox to the form
            receiptForm.Controls.Add(receiptText);

            // Show the receipt form as a dialog
            receiptForm.ShowDialog();
        }

        private void ResetForm()
        {
            cmbProductSearch.Text = "";
            txtQuantity.Text = "";
            txtPaymentAmount.Text = "";
            // Format currency as PHP
            lblTotalPayment.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));
            lblChange.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));

            // Clear receipt details
            receiptProductName = "";
            receiptQuantity = "";
            receiptTotalPayment = "";
            receiptPaymentGiven = "";
            receiptChange = "";
        }

        private decimal GetProductPrice(string productName)
        {
            decimal price = 0;
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT Price FROM Products WHERE Name = @name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    price = Convert.ToDecimal(result); // Return the fetched price
                }
            }
            return price;
        }

        private int GetProductStock(string productName)
        {
            int stock = 0;
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT Stock FROM Products WHERE Name = @name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    stock = Convert.ToInt32(result); // Return the fetched stock
                }
            }
            return stock;
        }

        private DateTime GetProductExpirationDate(string productName)
        {
            DateTime expirationDate = DateTime.MaxValue; // Default to a far future date
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT ExpirationDate FROM Products WHERE Name = @name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    expirationDate = Convert.ToDateTime(result);
                }
            }
            return expirationDate;
        }

        private void CheckForExpiringProducts()
        {
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "SELECT Name, ExpirationDate FROM Products WHERE ExpirationDate BETWEEN @today AND @expirationThreshold";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@today", DateTime.Now);
                cmd.Parameters.AddWithValue("@expirationThreshold", DateTime.Now.AddDays(30)); // Check for products expiring within 30 days

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productName = reader["Name"].ToString();
                        DateTime expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                        MessageBox.Show($"Product '{productName}' is expiring on {expirationDate.ToShortDateString()}.", "Expiration Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Add New Product Button Click Event
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            string name = txtNewProductName.Text;
            if (!decimal.TryParse(txtNewProductPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtNewProductStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Enter a valid stock quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime expirationDate = dateTimePickerExpirationDate.Value; // Get expiration date from DateTimePicker

            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "INSERT INTO Products (Name, Price, Stock, ExpirationDate) VALUES (@name, @price, @stock, @expirationDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProductsIntoDataGridView(); // Refresh DataGridView
        }

        // Edit Product Button Click Event
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lblProductID.Text == "")
            {
                MessageBox.Show("Select a product to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtNewProductName.Text;
            if (!decimal.TryParse(txtNewProductPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtNewProductStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Enter a valid stock quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime expirationDate = dateTimePickerExpirationDate.Value; // Get expiration date from DateTimePicker

            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "UPDATE Products SET Name=@name, Price=@price, Stock=@stock, ExpirationDate=@expirationDate WHERE ID=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", lblProductID.Text);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProductsIntoDataGridView(); // Refresh DataGridView
        }

        // Delete Product Button Click Event
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lblProductID.Text == "")
            {
                MessageBox.Show("Select a product to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
                return;

            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "DELETE FROM Products WHERE ID=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", lblProductID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProductsIntoDataGridView(); // Refresh DataGridView
        }

        // DataGridView Cell Click Event
        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row & column
            {
                DataGridViewRow row = dgvProductList.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null) // Ensure ID exists
                {
                    lblProductID.Text = row.Cells["ID"].Value.ToString(); // Store correct ID
                    txtNewProductName.Text = row.Cells["Name"].Value.ToString();
                    txtNewProductPrice.Text = row.Cells["Price"].Value.ToString();
                    txtNewProductStock.Text = row.Cells["Stock"].Value.ToString();

                    // Handle nullable ExpirationDate
                    if (row.Cells["ExpirationDate"].Value != DBNull.Value)
                    {
                        dateTimePickerExpirationDate.Value = Convert.ToDateTime(row.Cells["ExpirationDate"].Value); // Set expiration date
                    }
                    else
                    {
                        // If ExpirationDate is NULL, set the DateTimePicker to a default value (e.g., today's date)
                        dateTimePickerExpirationDate.Value = DateTime.Now;
                    }
                }
            }
        }

        // Logout Button Click Event
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Display a random quote
                string randomQuote = GetRandomQuote();
                MessageBox.Show(randomQuote, "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear session data (if any)
                ClearSessionData();

                // Close the current form
                this.Close();

                // Optionally, open the login form
                OpenLoginForm();
            }
        }

        // Method to get a random quote
        private string GetRandomQuote()
        {
            Random random = new Random();
            int index = random.Next(_quotes.Count); // Get a random index
            return _quotes[index]; // Return the quote at the random index
        }

        // Method to clear session data (if any)
        private void ClearSessionData()
        {
            // Clear any session data (e.g., logged-in user information)
            // Example:
            // Properties.Settings.Default.UserID = "";
            // Properties.Settings.Default.Save();
        }

        // Method to open the login form (if applicable)
        private void OpenLoginForm()
        {
            // Open the login form (if applicable)
            // Example:
            // LoginForm loginForm = new LoginForm();
            // loginForm.Show();
        }

        // Button click event for daily report
        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            DateTime reportDate = dateTimePickerDailyReport.Value; // Use DateTimePicker for date selection
            DataTable dt = GetDailySalesReport(reportDate);
            dgvReport.DataSource = dt; // Ensure dgvReport exists in your form
        }

        // Button click event for monthly report
        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerMonthlyReport.Value; // Use DateTimePicker for month selection
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            DataTable dt = GetMonthlySalesReport(year, month);
            dgvReport.DataSource = dt; // Ensure dgvReport exists in your form
        }

        // Method to fetch daily sales report
        private DataTable GetDailySalesReport(DateTime reportDate)
        {
            DataTable dt = new DataTable();
            string connectionString = "Server=KENSHIN;Database=WooPharmacyDB;Trusted_Connection=True;";
            string query = "GetDailySalesReport";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReportDate", reportDate.Date);

                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Method to fetch monthly sales report
        private DataTable GetMonthlySalesReport(int year, int month)
        {
            DataTable dt = new DataTable();
            string query = "GetMonthlySalesReport";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Month", month);

                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}