# Homework 6
## Queries

### 1. Average Rental Rate
Calculate the average value of the `rental_rate` column in the `film` table, rounded to two decimal places.

```sql
SELECT ROUND(AVG(rental_rate), 2) FROM film;
```

### 2. Count of Films Starting with 'C'
Determine how many films in the `film` table have titles that start with the character 'C'.

```sql
SELECT COUNT(*) FROM film
WHERE title LIKE 'C%';
```

### 3. Longest Film with Rental Rate 0.99
Find the maximum `length` of films in the `film` table where the `rental_rate` is equal to 0.99.

```sql
SELECT MAX(length) FROM film
WHERE rental_rate = 0.99;
```

### 4. Distinct Replacement Costs for Long Films
Count the number of distinct `replacement_cost` values for films with a `length` greater than 150 minutes.

```sql
SELECT COUNT(DISTINCT replacement_cost) FROM film
WHERE length > 150;
```
