# Patikafy

This project demonstrates a simple use of LINQ in C# to filter, group, and sort a list of artists. Below are the main functionalities implemented:

## Features

1. **List Artists Starting with 'S':**
   - Filters and displays artists whose names start with the letter 'S'.

2. **List Artists with Album Sales Over 10 Million:**
   - Filters and displays artists who have sold more than 10 million albums.

3. **Group and Sort Pre-2000 Pop Artists:**
   - Groups pop artists who debuted before the year 2000 by their debut year.
   - Each group is sorted alphabetically by the artist's name.

4. **Top-Selling Artist:**
   - Finds and displays the artist with the highest album sales.

5. **Oldest and Newest Debut Artists:**
   - Finds and displays the artists with the oldest and newest debut years.

## Example Output

```
---------------------Starting with S------------------------
Artist: Sertap Erener
Artist: Serdar Ortaç
Artist: Sıla

-------------More than 10 million album sales---------------
Artist: Tarkan (About 40 million)
Artist: Elton John (About 20 million)

---------------------Pre 2000 and Pop-----------------------
Debut Year: 1968
    Artist: Ajda Pekkan
Debut Year: 1971
    Artist: Sezen Aksu
Debut Year: 1992
    Artist: Tarkan

------------------------------------------------------------
Top Sold Album Artist => Tarkan with About 40 million
Oldest Debut Artist => Neşet Ertaş / 1960
Newest Debut Artist => Sıla / 2009
```
