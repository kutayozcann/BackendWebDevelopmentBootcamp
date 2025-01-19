# Homework 3

### Query 1: Country Names Starting with 'A' and Ending with 'a'

This query retrieves country names that:
- Start with the letter 'A'
- End with the letter 'a'

```sql
SELECT country FROM country
WHERE country LIKE 'A%a';
```

### Query 2: Country Names with at Least 6 Characters Ending with 'n'

This query retrieves country names that:
- Have at least 6 characters
- End with the letter 'n'

```sql
SELECT country FROM country
WHERE LENGTH(country) >= 6 AND country LIKE '%n';
```

### Query 3: Film Titles with at Least 4 'T' Characters (Case-Insensitive)

This query retrieves film titles that:
- Contain at least 4 'T' characters
- Ignores case sensitivity

```sql
SELECT title FROM film
WHERE LENGTH(title) - LENGTH(REPLACE(LOWER(title), 't', '')) >= 4;
```

### Query 4: Films Starting with 'C', Length Greater Than 90, and Rental Rate 2.99

This query retrieves all data from the `film` table where:
- The title starts with 'C'
- The length is greater than 90
- The rental rate is 2.99

```sql
SELECT * FROM film
WHERE title LIKE 'C%' AND length > 90 AND rental_rate = 2.99;
```
