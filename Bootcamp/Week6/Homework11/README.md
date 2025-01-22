# Homework 11

This guide explains SQL queries to compare and combine data from the `actor` and `customer` tables using their `first_name` column.

## Queries

### 1. UNION: All Unique First Names
Retrieve all unique first names from both tables.

```sql
SELECT first_name FROM actor
UNION
SELECT first_name FROM customer;
```

### 2. INTERSECT: Common First Names
Retrieve first names that are present in both tables.

```sql
SELECT first_name FROM actor
INTERSECT
SELECT first_name FROM customer;
```

### 3. EXCEPT: First Names in `actor` Only
Retrieve first names that are in the `actor` table but not in the `customer` table.

```sql
SELECT first_name FROM actor
EXCEPT
SELECT first_name FROM customer;
```

### 4. UNION ALL: All First Names (Including Duplicates)
Retrieve all first names from both tables, including duplicates.

```sql
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer;
```

### 5. INTERSECT ALL: Common First Names (Including Duplicates)
Retrieve common first names from both tables, including duplicates.

```sql
SELECT first_name FROM actor
INTERSECT ALL
SELECT first_name FROM customer;
```

### 6. EXCEPT ALL: First Names in `actor` Only (Including Duplicates)
Retrieve first names that are in the `actor` table but not in the `customer` table, including duplicates.

```sql
SELECT first_name FROM actor
EXCEPT ALL
SELECT first_name FROM customer;
```

