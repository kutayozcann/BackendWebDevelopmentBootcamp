# Homework 2

## Queries

### 1. Get all data from the `film` table where `replacement_cost` is between 12.99 and 16.99.
```sql
SELECT * FROM film 
WHERE replacement_cost BETWEEN 12.99 AND 16.99;
```

### 2. Get `first_name` and `last_name` from the `actor` table where `first_name` is 'Penelope', 'Nick', or 'Ed'.
```sql
SELECT first_name, last_name FROM actor
WHERE first_name IN('Penelope', 'Nick', 'Ed');
```

### 3. Get all data from the `film` table where:
- `rental_rate` is 0.99, 2.99, or 4.99
- And `replacement_cost` is 12.99, 15.99, or 28.99
```sql
SELECT * FROM film
WHERE rental_rate IN(0.99, 2.99, 4.99) AND replacement_cost IN(12.99, 15.99, 28.99);
