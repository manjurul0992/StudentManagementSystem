# Student Management System

## Getting Started

These instructions will help you set up and run the project on your local machine for development and testing purposes.

## Prerequisites

Ensure you have the following installed:

- **Visual Studio (2022)**
- **SQL Server**
- **.NET Framework 4.8 or later**

## Clone or Download

You can either clone the repository or download it as a ZIP file:

- 1. **Clone the repository:**

   ```bash
   git clone https://github.com/manjurul0992/StudentManagementSystem.git

- 2.Or Download the ZIP file:

* Download the repository as a ZIP file from this link https://github.com/manjurul0992/StudentManagementSystem/archive/refs/heads/master.zip.
* Extract the contents to your local machine

# SQL Server Configuration
1.Open the web.config file located in the root directory of the project.

2.Replace <SQL Server Name> with your actual SQL Server instance name:

<connectionStrings>
  <add name="AppDbContext" connectionString="Data Source=YOUR_SQL_SERVER_NAME;Database=Banglafire;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
</connectionStrings>

# Build and Run the Project


- 1. Open the solution file (.sln) in Visual Studio.
- 2.Run.
if facing this error ![Error Images](https://github.com/manjurul0992/StudentManagementSystem/blob/master/Images/Screenshot%202024-08-20%20061142.png)
- 3. If you encounter an error related to Microsoft.CodeDom.Providers.DotNetCompilerPlatform, follow these steps:
Open NuGet Package Manager in Visual Studio.
		- a. Uninstall the Microsoft.CodeDom.Providers.DotNetCompilerPlatform package.
		- b. Reinstall the package.
		- c. Rebuild the project.
		- d. Close the project in Visual Studio.
		- d. Reopen the project and run it again.
# Troubleshooting
If you encounter any issues, ensure that:
		- 1.All dependencies are installed correctly.
		- 2. The SQL Server connection string is configured properly.

# Video Instructions
[![Video Title](./Images/video-thumbnail.png)](https://github.com/manjurul0992/StudentManagementSystem/blob/master/Images/Video_2024-08-20_060855.wmv)

For a step-by-step video tutorial on how to set up and run this project, refer to the video instructions.
https://github.com/manjurul0992/StudentManagementSystem/blob/master/Images/Video_2024-08-20_060855.wmv
