# Homework 8

## 1. Create Table
The following SQL query creates the `employee` table with the specified columns:

```sql
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);
```

## 2. Insert Data
Insert sample data into the `employee` table:

```sql
INSERT INTO employee (name, birthday, email) VALUES ('Thurstan', '1979-05-15', 'tshurville0@typepad.com');
INSERT INTO employee (name, birthday, email) VALUES ('Doralyn', '2018-07-16', 'dcastelin1@qq.com');
INSERT INTO employee (name, birthday, email) VALUES ('Allyn', '1950-03-01', 'amaccallester2@sciencedaily.com');
INSERT INTO employee (name, birthday, email) VALUES ('Fara', '2019-03-08', 'fleither3@ucoz.ru');
INSERT INTO employee (name, birthday, email) VALUES ('Neille', '1995-10-22', 'nlindelof4@wired.com');
INSERT INTO employee (name, birthday, email) VALUES ('Wendi', '1984-08-11', 'whallas5@who.int');
INSERT INTO employee (name, birthday, email) VALUES ('Hyacintha', '1963-05-17', 'hrau6@is.gd');
INSERT INTO employee (name, birthday, email) VALUES ('Rusty', '1981-09-21', 'rdanes7@slate.com');
INSERT INTO employee (name, birthday, email) VALUES ('Hill', NULL, 'hdavidovicz8@amazon.co.jp');
INSERT INTO employee (name, birthday, email) VALUES ('Sydney', '1984-01-05', 'sblackey9@ezinearticles.com');
```

_And so on, inserting additional rows as provided._

## 3. Update Data
Update specific rows in the `employee` table:

```sql
UPDATE employee
SET name = 'UPDATE',
	birthday = NULL,
	email = 'UPDATE'
WHERE id IN (1, 2, 3, 4, 5);
```

This query updates the `name`, `birthday`, and `email` fields of employees with `id` 1 through 5.

## 4. Delete Data
Delete specific rows from the `employee` table:

```sql
DELETE FROM employee
WHERE id IN (6, 7, 8, 9, 10);
```

This query removes employees with `id` 6 through 10 from the table.

---

