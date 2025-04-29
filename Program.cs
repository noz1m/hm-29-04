using Infrastructure.Services;
using Domain.Entities;


var movServices = new MovieServices();

System.Console.WriteLine("1. Chose a movie");
System.Console.WriteLine("2. Chose a movie by id");
System.Console.WriteLine("3. Add a movie");
System.Console.WriteLine("4. Update a movie");
System.Console.WriteLine("5. Delete a movie");

// create
var mov1 = new Movie(){Title = "Iron man", Director = "Marvel", Year = 2008};
var mov2 = new Movie(){Title = "Avengers", Director = "Marvel", Year = 2012};
var mov3 = new Movie(){Title = "Iron man 2", Director = "Marvel", Year = 2010};
var mov4 = new Movie(){Title = "Iron man 3", Director = "Marvel", Year = 2013};
var mov5 = new Movie(){Title = "Capitan America", Director = "Marvel", Year = 2016};

movServices.AddMovie(mov1);

//read
var movies = movServices.GetAllMovies();
foreach (var movie in movies)
{
    Console.WriteLine($"{movie.Id} {movie.Title} {movie.Director} {movie.Year}");
}

//update
var movUpdate = movServices.GetMovieById(1);
movUpdate.Title = "Avengers";
movServices.UpdateMovie(movUpdate);

//delete
movServices.DeleteMovie(1);

switch (Console.ReadLine())
{
    case "1":
        movServices.GetAllMovies();
        break;
    case "2":
        movServices.GetMovieById(1);
        break;
    case "3":
        movServices.AddMovie(mov1);
        break;
    case "4":
        movServices.UpdateMovie(movUpdate);
        break;
    case "5":
        movServices.DeleteMovie(1);
        break;
}