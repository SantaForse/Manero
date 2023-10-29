# Manero Project Development Guide 📘

Welcome to the Manero Project! This guide is designed to help you set up your local development environment.

## Table of Contents

1. [Folder Structure](#folder-structure-)
2. [Pre-requisites](#pre-requisites-)
3. [Getting the Code](#getting-the-code-)
4. [Project Setup](#project-setup-)
5. [Database Connection](#database-connection-)
6. [Running the Project](#running-the-project-)
7. [Running Tests](#running-tests-)
8. [Working with CSS in Visual Studio](#working-with-css-in-visual-studio-)
9. [Additional Resources](#additional-resources-)

---

## Folder Structure 📂

The project follows a specific directory structure. Familiarizing yourself with this will make your life a lot easier.

```
Manero/
│
├── Manero/               # Main project directory
├── Manero.Tests/         # Directory containing xUnit tests
└── ...
```

## Pre-requisites 🛠

Before diving into the code, make sure you have the following installed:

- **.NET SDK**: You need the .NET SDK to compile and run the project. [Download .NET SDK](https://dotnet.microsoft.com/download)

---

## Getting the Code 📦

### Clone the Repository

1. **Using Terminal**: Open your terminal and run the following command:

   ```bash
   git clone https://github.com/SantaForse/Manero.git
   ```

2. **Using Visual Studio**:

   - Open Visual Studio.
   - Navigate to `File -> Clone or Checkout Code`.
   - Enter the GitHub repository URL and click `Clone`.

---

## Project Setup 🛠

### Navigate to the Project Directory

1. **Using Terminal**: Change your current directory to the project's main folder:

   ```bash
   cd Manero
   ```

2. **Using Visual Studio**: Open the `Manero` project from the `Solution Explorer`.

### Initialize User Secrets

User secrets help you keep sensitive configuration data out of your source code.

1. **Using Terminal**:

   ```bash
   dotnet user-secrets init
   ```

2. **Using Visual Studio**:

   - Right-click on the `Manero` project in `Solution Explorer`.
   - Select `Manage User Secrets` from the context menu.

---

## Database Connection 🗄

> **Note**: The connection string is available in the group chats. The default setting for running in development mode is to connect to a LocalDB.
> **Note**: If running locally the localDB has to be set up before starting the project, do this by running Database-Update in the Package Manager Console.

1. **Using Terminal**:

   ```bash
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Your_Connection_String"
   ```

2. **Using Visual Studio**:

   - After clicking `Manage User Secrets`, a `secrets.json` file will open.
   - Paste your connection string like so:

     ```json
     {
     	"ConnectionStrings": {
     		"DefaultConnection": "Your_Connection_String"
     	}
     }
     ```

---

## Running the Project 🏃‍♀️

1. **Using Terminal**:

   ```bash
   dotnet run
   ```

2. **Using Visual Studio**:

   - Ensure `Manero` is set as the `Startup Project`. It should appear in bold in the `Solution Explorer`.
   - Press `F5` or click on the `Start Debugging` button to run the project.

---

## Running Tests 🧪

### To run the tests located in the `Manero.Tests` folder, do the following:

1. **Using Terminal**:

   ```bash
   cd Manero.Tests
   dotnet test
   ```

2. **Using Visual Studio**:

   - Open the `Test Explorer` window.
   - Click on `Run All Tests` or select specific tests to run.

---

## Working with CSS in Visual Studio 🎨

### About `BuildWebCompiler` and `Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation`

- **`BuildWebCompiler`**: This package automatically compiles SCSS into CSS every time you save changes to an SCSS file. No manual steps needed!
- **`Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation`**: With this package, any changes made to Razor views (`.cshtml` files) are reflected immediately upon refreshing the browser—no need to restart the application.

### Directory Structure for Styles

Your styles should be organized as follows:

```plaintext
Manero/
│
├── Styles/
│   ├── Buttons/      # Button-related styles
│   ├── Inputs/       # Input-related styles
│   └── Root/         # Root-level styles
│
└── ...
```

### Compilation Configuration

The `compilerconfig.json` file directs `buildWebCompiler` to compile `styles.scss` into `wwwroot/css/styles.css`.

- **Auto-Compile**: Simply save your SCSS changes and they will automatically compile.
- **Manual**: Right-click on `compilerconfig.json` in `Solution Explorer` and choose `Web Compiler -> Re-compile all`.

---

## Additional Resources 📚

Here are some extra materials that may assist you in setting up and working on the project:

- **.NET Core Documentation**: [Official Docs](https://docs.microsoft.com/en-us/dotnet/core/)
- **xUnit Testing**: [Getting Started with xUnit](https://xunit.net/docs/getting-started/netcore/cmd)
- **Visual Studio Shortcuts**: [Keyboard Shortcuts](https://visualstudioshortcuts.com/)
- **SCSS Basics**: [SCSS Tutorial](https://sass-lang.com/guide)
- **Razor Views in ASP.NET**: [Understanding Razor](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0)
