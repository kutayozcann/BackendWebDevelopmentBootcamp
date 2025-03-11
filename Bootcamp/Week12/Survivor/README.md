# Survivor Web API Application

This project is a Web API application for the Survivor competition. It includes a relationship between competitors and categories and provides API endpoints to perform CRUD (Create, Read, Update, Delete) operations on these relationships. The application uses a `BaseEntity` class to ensure consistency across all entities and supports soft delete functionality.

---

## Tables

### Competitors Table

- **Id**: Unique identifier for the competitor (Primary Key, inherited from `BaseEntity`).
- **Name**: Name of the competitor.
- **Age**: Age of the competitor.
- **CategoryId**: Identifier of the category the competitor belongs to (Foreign Key).
- **CreatedDate**: Timestamp when the competitor was created (inherited from `BaseEntity`).
- **ModifiedDate**: Timestamp when the competitor was last modified (inherited from `BaseEntity`).
- **IsDeleted**: Soft delete flag to mark the competitor as deleted (inherited from `BaseEntity`).

### Categories Table

- **Id**: Unique identifier for the category (Primary Key, inherited from `BaseEntity`).
- **Name**: Name of the category.
- **CreatedDate**: Timestamp when the category was created (inherited from `BaseEntity`).
- **ModifiedDate**: Timestamp when the category was last modified (inherited from `BaseEntity`).
- **IsDeleted**: Soft delete flag to mark the category as deleted (inherited from `BaseEntity`).

---

## Relationships

- A **Category** can have multiple **Competitors** (One-to-Many relationship).
- Each **Competitor** belongs to only one **Category**.

---
## Competitor Endpoints

### Get All Competitors
- **GET** `/api/competitors`
- **Description**: Retrieves a list of all competitors.
- **Response**: List of competitor objects.

### Get Competitor by ID
- **GET** `/api/competitors/{id}`
- **Description**: Retrieves a specific competitor by their ID.
- **Response**: A single competitor object.

### Get Competitors by Category ID
- **GET** `/api/competitors/categories/{CategoryId}`
- **Description**: Retrieves all competitors belonging to a specific category.
- **Response**: List of competitor objects.

### Create a Competitor
- **POST** `/api/competitors`
- **Description**: Creates a new competitor.
- **Request Body**:
  ```json
  {
      "name": "John Doe",
      "age": 25,
      "categoryId": 1
  }
