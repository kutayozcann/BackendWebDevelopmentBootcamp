# Homework 7

## Queries and Descriptions

### 1. Group Films by Rating
Group all films in the `film` table by their `rating` and count the number of films for each rating.

```sql
SELECT rating, COUNT(*) FROM film
GROUP BY rating;
```

### 2. Replacement Cost with More than 50 Films
Group films in the `film` table by the `replacement_cost` column and list the `replacement_cost` values that correspond to more than 50 films, along with their respective counts.

```sql
SELECT replacement_cost, COUNT(*) FROM film
GROUP BY replacement_cost
HAVING COUNT(*) > 50;
```

### 3. Customer Count by Store ID
Group customers in the `customer` table by their `store_id` and count the number of customers for each store.

```sql
SELECT store_id, COUNT(*) FROM customer
GROUP BY store_id;
```

### 4. Country with the Most Cities
Group cities in the `city` table by `country_id` and identify the `country_id` with the highest number of cities, along with the count of cities.

```sql
SELECT country_id, COUNT(city) FROM city
GROUP BY country_id
ORDER BY COUNT(city) DESC
LIMIT 1;
```
