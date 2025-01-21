## Homework 9

### Purpose
These SQL queries are designed to combine data from different tables within a database. This is done using the `INNER JOIN` operation, which connects rows from two or more tables based on a related column.

### Query

1. **City and Country:**
   * **Purpose:** Matches cities with their corresponding countries.
   * **Example:** This query could tell you that 'Paris' is in 'France'.
   * **SQL:**
     ```sql
     SELECT city, country FROM city
     INNER JOIN country ON city.country_id = country.country_id;
     ```

2. **Customer and Payment:**
   * **Purpose:** Connects customers to their payment transactions.
   * **Example:** This query could find out which customer made a specific payment.
   * **SQL:**
     ```sql
     SELECT payment_id, first_name, last_name FROM customer
     INNER JOIN payment ON payment.customer_id = customer.customer_id;
     ```

3. **Customer and Rental:**
   * **Purpose:** Links customers with their rental history.
   * **Example:** This query could show you what items a customer has rented.
   * **SQL:**
     ```sql
     SELECT rental_id, first_name, last_name FROM customer
     INNER JOIN rental ON customer.customer_id = rental.customer_id;
     ```
