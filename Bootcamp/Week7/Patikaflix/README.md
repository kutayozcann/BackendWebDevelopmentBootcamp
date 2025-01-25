# Patikaflix

Patikaflix is a simple console application that allows users to create and manage a list of TV series. The application enables users to input information about TV series and display them based on specific genres such as comedy.

## Features
- Add a new TV series with detailed information such as:
  - Name
  - Production year
  - Genres (e.g., Comedy, Drama, Crime Fiction, etc.)
  - Director
  - Year of publication
  - First platform it was released on
- Validate user inputs to ensure correctness.
- Filter and display series by genre (e.g., comedy) in a sorted manner.

## Usage
1. Follow the on-screen prompts to add a new series.
2. Provide all the required details such as name, production year, genre(s), director, and publication year.
3. After adding a series, choose whether to add another one or view the filtered comedy series list.

## Example Output
```
Welcome to Patikaflix
Please enter series name: Breaking Bad
Please enter production year: 2008
Please enter genre (Comedy, Crime Fiction, Drama, Romantic, History): Drama
Do you want to add genre? (Y/N): n
Please enter publication year: 2008
Please enter director name: Vince Gilligan
Please enter first platform which it was released: AMC
Series added
Do you want to add new series? (Y/N): n

-----------------Comedy List-----------------
Series Name: Friends / Director: David Crane / Genre: comedy
```

