## Manero Project Development Guide

This guide aims to help team members set up their local development environments.

### Folder Structure

- **base**: Root directory containing the Git repository.
  - **Manero**: Main project directory.
  - **Manero.Tests**: Directory containing xUnit tests.

### Pre-requisites

1. **Install .NET SDK**: Make sure the .NET SDK is installed on your machine. Download it from the [official site](https://dotnet.microsoft.com/download).

   `[Download .NET SDK](https://dotnet.microsoft.com/download)`

### Getting the Code

2. **Clone the Repository**: 
   - **Using Terminal**: 
     ```bash
     git clone https://github.com/SantaForse/Manero.git
     ```
   - **Using Visual Studio**: 
     1. Open Visual Studio
     2. Go to `File -> Clone or Checkout Code`
     3. Enter the GitHub repo URL and click `Clone`

### Project Setup

3. **Navigate to the Project Directory**: 
   - **Using Terminal**: 
     ```bash
     cd to/the/project/directory
     ```
   - **Using Visual Studio**: Open the `Manero` project from the `Solution Explorer`.

4. **Initialize User Secrets**: 
   - **Using Terminal**: 
     ```bash
     dotnet user-secrets init
     ```
   - **Using Visual Studio**: 
     1. Right-click on the `Manero` project in `Solution Explorer`
     2. Click on `Manage User Secrets`

### Database Connection

5. **Set Database Connection**: 
   The connection string is availible in the group chats.
   - **Using Terminal**: 
     ```bash
     dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Paste_Your_Connection_String_Here"
     ```
   - **Using Visual Studio**: 
     1. After clicking `Manage User Secrets`, a `secrets.json` file will open.
     2. Paste your connection string like so:
        ```json
        {
          "ConnectionStrings": {
            "DefaultConnection": "Paste_Your_Connection_String_Here"
          }
        }
        ```

### Running the Project

6. **Run the Manero Project**: 
   - **Using Terminal**: 
     ```bash
     dotnet run
     ```
   - **Using Visual Studio**: 
     1. Make sure `Manero` is set as the `Startup Project` (it should be bold in `Solution Explorer`).
     2. Press `F5` or click on the `Start Debugging` button.

### Running Tests

To run the tests located in the `Manero.Tests` folder, do the following:

   - **Using Terminal**: 
     ```bash
     cd Manero.Tests
     dotnet test
     ```
   - **Using Visual Studio**: 
     1. Open the `Test Explorer` window.
     2. Click on `Run All Tests` or select specific tests to run.

Navigate to `https://localhost:5001` (or the port specified) to see the running application.
