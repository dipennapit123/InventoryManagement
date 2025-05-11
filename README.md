# Inventory Management API
## Overview
The Inventory Management API is designed to help businesses manage their inventory efficiently. It provides endpoints for managing products, categories, stock levels, and more.

## Features
- Add, update, and delete products.
- Manage product categories.
- Track stock levels and inventory movements.
- Generate inventory reports.

## Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/your-repo/InventoryManagementAPI.git
    ```
2. Navigate to the project directory:
    ```bash
    cd InventoryManagementAPI
    ```
3. Install dependencies:
    ```bash
    dotnet restore
    ```
4. Build the project:
    ```bash
    dotnet build
    ```

## Usage
1. Run the application:
    ```bash
    dotnet run
    ```
2. Access the API documentation at `http://localhost:5000/swagger`.

## API Endpoints
- **GET /products**: Retrieve a list of all products.
- **POST /products**: Add a new product.
- **PUT /products/{id}**: Update an existing product.
- **DELETE /products/{id}**: Delete a product.

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes and push the branch.
4. Submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.