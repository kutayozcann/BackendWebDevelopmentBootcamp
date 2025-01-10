# IMDB Movie List Application

This C# console application allows users to create and manage a movie list. Users can add movies with a name and rating, display all movies, and filter movies based on specific criteria.

## Features
1. **Add Movies**: Users can input a movie name and a rating between 0 and 10.
2. **Display All Movies**: View the complete list of movies with their titles and ratings.
3. **Filter Movies by Rating**: Display movies with ratings between 4 and 9.
4. **Filter Movies by Title**: Display movies whose titles start with the letter 'A'.

## How It Works
1. The program prompts the user to enter the name and rating of a movie.
2. Users can choose to add more movies or stop entering data.
3. After the user finishes, the program displays:
   - All movies in the list.
   - Movies with ratings between 4 and 9.
   - Movies with titles starting with the letter 'A'.

## Example Output
```plaintext
Welcome to the IMDB List
Please enter the movie name: Avatar
Please enter the movie rating: 9.5
Do you want to create a new movie? (Y/N): Y

Please enter the movie name: Titanic
Please enter the movie rating: 8.0
Do you want to create a new movie? (Y/N): N

--------------------Full IMDB List-----------------
Title : Avatar ----- Rating : 9.5
Title : Titanic ----- Rating : 8.0
-------------------------------------------------
Displaying films that have rating between 4 and 9
Title : Titanic ----- Rating : 8.0
-----------------------------------------------------------
Displaying films with a title that starts with letter 'A'
Title : Avatar
