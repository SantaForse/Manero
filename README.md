﻿## Manero Project Development Guide

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
  1.  Open the `Test Explorer` window.
  2.  Click on `Run All Tests` or select specific tests to run.

Navigate to `https://localhost:5001` (or the port specified) to see the running application.

### Working with CSS in Visual Studio

#### Directory Structure for Styles

Your styles should be located in the following directories within the `Manero` project:

- `Manero/Styles`: Root directory for all style-related files.
  - `Manero/Styles/Buttons`: Contains `_buttons.scss` for button-related styles.
  - `Manero/Styles/Inputs`: Contains `_inputs.scss` for input-related styles.
  - `Manero/Styles/Root`: Contains `_root.scss` for root-level styles.
  - `Manero/Styles/styles.scss`: Main SCSS file, which imports all other SCSS files.
  - `Manero/Styles/styles.css` & `Manero/Styles/styles.min.css`: Compiled output CSS files.

#### Compilation Configuration

The `compilerconfig.json` in the `Manero` root directory directs `buildWebCompiler` to compile `styles.scss` into `wwwroot/css/styles.css`. Configuration snippet:

```json
{
	"outputFile": "wwwroot/css/styles.css",
	"inputFile": "Styles/styles.scss",
	"options": { "sourceMap": true }
}
```

#### How to Compile

- **Using Visual Studio**:

  1. Save your changes in the SCSS file.
  2. `buildWebCompiler` automatically compiles into `styles.css` and `styles.min.css`.

- **Manually**:
  1. Right-click on `compilerconfig.json` in `Solution Explorer`.
  2. Choose `Web Compiler -> Re-compile all`.

#### Real-Time Changes

No need to rebuild the entire project to see your CSS changes. Simply refresh your browser to observe the updated styles.
