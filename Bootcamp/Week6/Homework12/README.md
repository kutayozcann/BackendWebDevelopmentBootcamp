# Homework 12

This document contains SQL queries to analyze data from the `film` and `payment` tables. Below are the queries and their purposes.

## Queries and Descriptions

### 1. Films Longer Than Average
Count how many films have a length greater than the average film length:
```sql
SELECT COUNT(*) FROM film
WHERE length >
(
SELECT AVG(length) FROM film
);
```

### 2. Films with the Highest Rental Rate
Count the number of films with the highest rental rate:
```sql
SELECT COUNT(*) FROM film
WHERE rental_rate =
(
SELECT MAX(rental_rate) FROM film
);
```

### 3. Films with Lowest Rental Rate and Replacement Cost
List films that have both the lowest rental rate and the lowest replacement cost:
```sql
SELECT film_id, title, rental_rate, replacement_cost FROM film
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film)
  AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

### 4. Top Customers by Number of Payments
List customers who have made the most payments, sorted by payment count in descending order:
```sql
SELECT customer_id, COUNT(*)
FROM payment
GROUP BY customer_id
ORDER BY COUNT(*) DESC;
```
