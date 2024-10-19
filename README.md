# Full Stack Application


This project consists of a **frontend** built with **Angular** and a **backend** built with **.NET 8**. The following guide will walk you through setting up and running both the frontend and backend locally or using Docker.

# Setup with Docker


## Prerequisites

- [Docker](https://www.docker.com/products/docker-desktop)
- [Docker Compose](https://docs.docker.com/compose/)

## Setting Up and Running the Application with Docker

1. **Clone the repository**:
    ```bash
    git clone https://github.com/Ziadkad/HahnProject
    cd HahnProject
    ```

2. **Build and Run the Application with Docker Compose**:
    ```bash
    docker-compose up --build
    ```

   This command will:
   - Build the **sqlserver** , **backend** and **frontend** Docker images.
   - Start three containers (sqlserver, backend and frontend).
   - Set up networking between them.

   **SqlServer** will be accessible at `localhost,1433` with username `sa` and Password `YourPassword123`. The **backend** will be accessible at `http://localhost:5000`, and the **frontend** will be accessible at `http://localhost:4200`.

## Stopping the Docker Containers
    To stop the running containers, run:
    ```bash
    docker-compose down
    ```


# Setup without Docker


## Prerequisites

### Backend
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Rider](https://www.jetbrains.com/rider/)

### Frontend
- [Node.js (LTS version)](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli) (`npm install -g @angular/cli`)

## Setting Up the Backend (API)

1. **Clone the repository**:
    ```bash
    git clone https://github.com/Ziadkad/HahnProject
    cd HahnProject/backend
    ```

2. **Restore .NET packages**:
    ```bash
    dotnet restore
    ```

3. **Run the backend**:
    ```bash
    dotnet run
    ```
    This will start the backend on `http://localhost:5000` (default). The exact port might vary, so check the console output.

## Setting Up the Frontend (Angular)

1. **Navigate to the frontend directory**:
    ```bash
    cd ../frontend
    ```

2. **Install dependencies**:
    ```bash
    npm install
    ```

3. **Update the API URL**:
   Open `src/environments/environment.ts` (for development) or `src/environments/environment.prod.ts` (for production), and update the `apiUrl` to match your backend's URL:
    ```typescript
    export const environment = {
      apiUrl: 'http://localhost:5000/api'
    };
    ```

4. **Run the frontend**:
    ```bash
    ng serve
    ```
    The frontend will be accessible at `http://localhost:4200`.