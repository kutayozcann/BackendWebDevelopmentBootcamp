# Homework 1

## Queries

### 1. Get `title` and `description` from the `film` table.
```sql
SELECT title, description FROM film;
```

### 2. Get all data from the `film` table where `length` is between 60 and 75.
```sql
SELECT * FROM film WHERE length > 60 AND length < 75;
```

### 3. Get all data from the `film` table where:
- `rental_rate` is 0.99
- And `replacement_cost` is 12.99 or 28.99
```sql
SELECT * FROM film WHERE rental_rate = 0.99 AND (replacement_cost = 12.99 OR replacement_cost = 28.99);
```

### 4. Get `last_name` of the customer with `first_name` 'Mary'.
```sql
SELECT last_name FROM customer WHERE first_name = 'Mary';
```

### 5. Get all data from the `film` table where:
- `length` is 50 or less
- And `rental_rate` is not 2.99 or 4.99
```sql
SELECT * FROM film WHERE NOT length > 50 AND NOT (rental_rate = 2.99 OR rental_rate = 4.99);
```
