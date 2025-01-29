# Basic MVC 

This is a simple ASP.NET MVC practice project to demonstrate how to work with models, views, and controllers. The project includes two views: one for displaying customer details and another for displaying customer details along with their orders.

---

## Project Structure

The project is organized as follows:

- **Models**:
  - `CustomerViewModel`: Represents a view model for displaying customer details.
  - `CustomerOrderViewModel`: Represents a view model for displaying customer details along with their orders.
  - `Customer`: Represents a customer entity.
  - `Order`: Represents an order entity.

- **Views**:
  - `Customer/Index.cshtml`: Displays customer details using the `CustomerViewModel`.
  - `Customer/Index.cshtml`: Displays customer details and their orders using the `CustomerOrderViewModel`.

- **Controllers**:
  - `CustomerController`: Handles requests for customer-related views.

---

## Views

### 1. Customer Details View (`Index.cshtml`)
This view displays the details of a customer, including their ID, first name, last name, and email.

**Model Used**: `CustomerViewModel`

### 2. Customer Orders View (`Index.cshtml`)
This view displays the details of a customer along with a list of their orders.

**Model Used**: `CustomerOrderViewModel`
