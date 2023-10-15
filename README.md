## Setting up Local Development Environment

Follow these steps to set up the local development environment. This guide is particularly aimed at those who are new to .NET development.

### Pre-requisites

1. **Install .NET SDK**: Make sure the .NET SDK is installed on your machine. You can download it from the [official site](https://dotnet.microsoft.com/download).

   `[Download .NET SDK](https://dotnet.microsoft.com/download)`

### Getting the Code

2. **Clone the Repository**: 
   - **Using Terminal**: Run the following command to clone the GitHub repository to your machine.
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
      cd path/to/your/project
      ```
   - **Using Visual Studio**: The project should be listed in the `Solution Explorer`.

4. **Initialize User Secrets**: 
   - **Using Terminal**: 
      ```bash
      dotnet user-secrets init
      ```
   - **Using Visual Studio**: 
     1. Right-click on the project in `Solution Explorer`
     2. Click on `Manage User Secrets`

### Database Connection

5. **Set Database Connection**: 
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

6. **Run the Project**: 
   - **Using Terminal**: 
      ```bash
      dotnet run
      ```
   - **Using Visual Studio**: 
     1. Make sure your project is set as the `Startup Project` (it should be bold in `Solution Explorer`).
     2. Press `F5` or click on the `Start Debugging` button.

Navigate to `https://localhost:5001` (or the port specified) to see the running application.
