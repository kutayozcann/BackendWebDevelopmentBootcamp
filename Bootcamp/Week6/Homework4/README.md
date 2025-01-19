# Homework 4

### Query 1: Unique Replacement Costs

Retrieve all unique values from the `replacement_cost` column in the `film` table.

```sql
SELECT DISTINCT replacement_cost FROM film;
```

---

### Query 2: Count of Unique Replacement Costs

Count the number of unique values in the `replacement_cost` column.

```sql
SELECT COUNT(DISTINCT replacement_cost) FROM film;
```

---

### Query 3: Titles Starting with 'T' and Rated 'G'

Count films where the title starts with 'T' and the rating is 'G'.

```sql
SELECT COUNT(*) FROM film
WHERE title LIKE 'T%' AND rating = 'G';
```

---

### Query 4: Countries with 5-Character Names

Count country names with exactly 5 characters.

```sql
SELECT COUNT(*) FROM country
WHERE LENGTH(country) = 5;
```

---

### Query 5: Cities Ending with 'R'

Count city names ending with 'R' or 'r', ignoring case sensitivity.

```sql
SELECT COUNT(*) FROM city
WHERE city ILIKE '%r';
```

---
