# Homework 5

## Queries

### 1. Top 5 Longest Films Ending with 'n'
Fetch the top 5 longest films (based on `length`) from the `film` table where the film title ends with the character 'n'.

```sql
SELECT * FROM film
WHERE title LIKE '%n'
ORDER BY length DESC
LIMIT 5;
```

### 2. Second Shortest 5 Films Ending with 'n'
Fetch the next 5 shortest films (6th to 10th shortest based on `length`) from the `film` table where the film title ends with the character 'n'.

```sql
SELECT * FROM film
WHERE title LIKE '%n'
ORDER BY length
OFFSET 5
LIMIT 5;
```

### 3. First 4 Customers by Last Name (Descending) for Store 1
Fetch the first 4 customers (based on `last_name` in descending order) from the `customer` table where `store_id` equals 1.

```sql
SELECT * FROM customer
WHERE store_id = 1
ORDER BY last_name DESC
LIMIT 4;
```
