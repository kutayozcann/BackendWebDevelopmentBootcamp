# Homework 10

This guide explains SQL join queries for combining data from multiple tables. Below are simple examples and their uses.

## Queries

### 1. LEFT JOIN: `city` and `country`
This query shows city and country names. It includes all rows from `country`, even if there are no matching rows in `city`.

```sql
SELECT city, country FROM country
LEFT JOIN city ON city.country_id = country.country_id;
```

### 2. RIGHT JOIN: `customer` and `payment`
This query gets payment IDs and customer names. It includes all rows from `payment`, even if there are no matching rows in `customer`.

```sql
SELECT payment_id, first_name, last_name FROM customer
RIGHT JOIN payment ON customer.customer_id = payment.customer_id;
```

### 3. FULL JOIN: `customer` and `rental`
This query shows rental IDs and customer names. It includes all rows from both tables, even if there are no matches.

```sql
SELECT rental_id, first_name, last_name FROM customer
FULL JOIN rental ON customer.customer_id = rental.customer_id;
```
