# CrazyMusicians API

## Overview
The **CrazyMusicians API** is a simple RESTful API built with **ASP.NET Core** that allows managing a list of musicians. It provides CRUD operations and search functionality.

## Features
- Retrieve all musicians
- Get a specific musician by ID
- Search for musicians by full name
- Add a new musician
- Update an existing musician
- Partially update a musician using JSON Patch
- Delete a musician

## Technologies Used
- **ASP.NET Core**
- **C#**
- **Microsoft.AspNetCore.Mvc**
- **Microsoft.AspNetCore.JsonPatch**

## Endpoints

### Get All Musicians
**GET** `/api/musicians`
- Returns the list of all musicians.

### Get Musician by ID
**GET** `/api/musicians/{id}`
- Retrieves a musician by their ID.
- Returns **404 Not Found** if the musician does not exist.

### Search Musicians
**GET** `/api/musicians/search?fullName={fullName}`
- Searches for musicians by full name (case-insensitive).
- Returns **400 Bad Request** if the search term is empty.
- Returns **404 Not Found** if no musician matches the search.

### Add a New Musician
**POST** `/api/musicians`
- Adds a new musician to the list.
- Requires a valid JSON body:
  ```json
  {
    "fullName": "John Doe",
    "profession": "Guitarist",
    "funFact": "Loves playing music in the dark."
  }
  ```
- Returns **400 Bad Request** if the model validation fails.

### Update a Musician
**PUT** `/api/musicians/{id}`
- Updates an existing musician.
- Requires a valid JSON body similar to the **POST** request.
- Returns **404 Not Found** if the musician does not exist.

### Partially Update a Musician (JSON Patch)
**PATCH** `/api/musicians/{id}`
- Allows partial updates using JSON Patch.
- Example request body:
  ```json
  [
    { "op": "replace", "path": "/fullName", "value": "Updated Name" }
  ]
  ```
- Returns **400 Bad Request** if the request body is invalid.
- Returns **404 Not Found** if the musician does not exist.

### Delete a Musician
**DELETE** `/api/musicians/{id}`
- Deletes a musician by ID.
- Returns **404 Not Found** if the musician does not exist.

