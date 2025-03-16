‼️Yo waruupp‼️

# WooPharmacyPOS

A Point of Sale (POS) system for managing pharmacy operations.🤑

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/shoodol/WooPharmacyPOS.git
2. Restore the database:
   ```bash
   Open SSMS and restore the .bak file from the Database folder.
3. Update the connection string:
   ```bash
   Open appsettings.json or web.config and update the connection string to match your local SQL Server instance.
4. Restore NuGet packages:
   ```bash
   Right-click the solution > Restore NuGet Packages.
5. Build and run the project:
   ```bash
   Click Build > Build Solution.
   Press F5 to run the project.

## ‼️Here are the official links to download‼️

## Visual Studio 2022, SQL Server, and SQL Server Management Studio (SSMS):

1. Visual Studio 2022
Visual Studio 2022 is the latest version of Microsoft's integrated development environment (IDE). You can download the Community edition for free, which is suitable for individual developers and small teams.
Download Link: https://visualstudio.microsoft.com/vs/
Visual Studio 2022 Community Edition

Steps:
Click the link above.
Select the Community edition (free for individual use).
Download the installer and follow the on-screen instructions to install Visual Studio 2022.

2. SQL Server
SQL Server is a relational database management system (RDBMS) developed by Microsoft. You can download the Developer edition for free, which includes all the features of the Enterprise edition but is licensed for development and testing purposes only.

Download Link: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
SQL Server 2022 Developer Edition

Steps:
Click the link above.
Select the Developer edition (free for development purposes).
Download the installer and follow the on-screen instructions to install SQL Server.

3. SQL Server Management Studio (SSMS)
SSMS is a tool used to manage SQL Server instances. It provides a graphical interface for database administration and development.
Download Link: https://learn.microsoft.com/en-us/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
SQL Server Management Studio (SSMS)

Steps:
Click the link above.
Download the latest version of SSMS.
Run the installer and follow the on-screen instructions to install SSMS.

## ‼️Additional Notes‼️

Visual Studio 2022: Make sure to install the .NET Desktop Development workload during installation, as it includes the necessary tools for building Windows Forms applications.
SQL Server: During installation, ensure that the Database Engine and SQL Server Management Tools are selected.
SSMS: After installation, you can connect to your SQL Server instance using SSMS to manage databases.

By following these steps, your team should be able to set up the project and database successfully. Let me know if you or your team encounter any issues!🧐

-Shoodol🤖
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 📣Step-by-Step Guide for the Target System Owner📣
 
1. Extract the ZIP File
   
Locate the ZIP File:
Find the WooPharmacyPOS_Deployment.zip file that you received (e.g., on your desktop or in your Downloads folder).

Extract the ZIP File:
Right-click on the WooPharmacyPOS_Deployment.zip file.
Select Extract All....
Choose a location to extract the files (e.g., C:\WooPharmacyPOS).
Click Extract.

Open the Extracted Folder:
Navigate to the folder where the files were extracted (e.g., C:\WooPharmacyPOS).

You should see the following files:
WooPharmacyPOS.exe (the main application).
WooPharmacyPOS.exe.config (configuration file).
BouncyCastle.Cryptography.dll (required library).
itextsharp.dll (required library).
System.Configuration.ConfigurationManager.dll (required library).
System.Data.SqlClient.dll (required library).
script.sql (SQL script for database setup).
Setup.bat (batch file for setup).
WooPharmacyDB_LogBackup_2025-03-14_03-36-25.bak (database backup).
How to Download SQLCMD.txt (guide for SQLCMD installation, if needed).

2. Restore the Database

Open Command Prompt:
Press Win + R on your keyboard.
Type cmd and press Enter. A black Command Prompt window will open.

Navigate to the Extracted Folder:
In the Command Prompt, type the following command and press Enter:
bash (type this in CMD)
cd C:\WooPharmacyPOS
(Replace C:\WooPharmacyPOS with the path to your extracted folder if it’s different.)

Run the Database Restoration Script:
In the Command Prompt, type the following command and press Enter:
bash (type this in CMD)
sqlcmd -S .\SQLEXPRESS -i "script.sql"
This command restores the WooPharmacyPOS database.

Verify the Database Restoration:
If the restoration is successful, you’ll see messages like:
Database restored successfully!

3. Run the Application

Launch the Application:
In the extracted folder (C:\WooPharmacyPOS), double-click the Setup.bat file.
This will:

Restore the database (if not already done).
Launch the WooPharmacyPOS application.

Verify the Application:
The WooPharmacyPOS application should open automatically.
Ensure you can log in and use the application without errors.

4. (Optional) Create a Desktop Shortcut
Create a Shortcut:

Right-click on the WooPharmacyPOS.exe file in the extracted folder.
Select Send to > Desktop (create shortcut).

Run the Application from the Desktop:
Double-click the shortcut on your desktop to launch the application in the future.

## ‼️Troubleshooting‼️

SQLCMD Not Found:
If you see an error like 'sqlcmd' is not recognized, ensure SQL Server Tools are installed on your system.
Follow the instructions in the How to Download SQLCMD.txt file to install SQLCMD.

Database Connection Issues:
If the application cannot connect to the database, ensure:
The SQL Server instance name (e.g., .\SQLEXPRESS) is correct.
The database was restored successfully.

Application Fails to Launch:
Ensure you extracted all files from the ZIP file.
Ensure the .NET Framework 4.8 is installed on your system.
Summary of Files in the Extracted Folder
WooPharmacyPOS.exe: The main application executable.
WooPharmacyPOS.exe.config: Configuration file.
BouncyCastle.Cryptography.dll: Required library.
itextsharp.dll: Required library.
System.Configuration.ConfigurationManager.dll: Required library.
System.Data.SqlClient.dll: Required library.
script.sql: SQL script for database setup.
Setup.bat: Batch file to automate database restoration and application launch.
WooPharmacyDB_LogBackup_2025-03-14_03-36-25.bak: Database backup file.

## ‼️Final Notes‼️:

Ensure the target system has .NET Framework 4.8 installed.
https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer
If the target system does not have SQL Server installed, you may need to install it or provide additional instructions for setting up the database.

-Shoodol🤖
