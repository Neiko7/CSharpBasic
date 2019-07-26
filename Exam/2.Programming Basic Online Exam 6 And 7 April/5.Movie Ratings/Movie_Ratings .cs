using System;


class Movie_Ratings
{
    static void Main()
    {
        int numberOfMovie = int.Parse(Console.ReadLine());

        string nameOfMovie = string.Empty;
        double movieRating = 0.0;

        double totalMovieRating = 0.0;

        double maxRating = double.MinValue;
        double minRating = double.MaxValue;
        string currentNameOfMovieMax = string.Empty;
        string currentNameOfMovieMin = string.Empty;

        for (int i = 1; i <= numberOfMovie; i++)
        {
            nameOfMovie = Console.ReadLine();
            movieRating = double.Parse(Console.ReadLine());

            if (movieRating > maxRating)
            {
                currentNameOfMovieMax = nameOfMovie;
                maxRating = movieRating;
            }

            if (movieRating < minRating)
            {
                currentNameOfMovieMin = nameOfMovie;
                minRating = movieRating;
            }

            totalMovieRating += movieRating;
        }

        totalMovieRating /= numberOfMovie;

        Console.WriteLine($"{currentNameOfMovieMax} is with highest rating: {maxRating:F1}");
        Console.WriteLine($"{currentNameOfMovieMin} is with lowest rating: {minRating:F1}");
        Console.WriteLine($"Average rating: {totalMovieRating:F1}");
    }
}
