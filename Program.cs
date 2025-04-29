using Infrastructure.Services;
using Domain.Entities;

var movServices = new MovieServices();

// create
var mov1 = new Movie();
mov1.Title = "Iron man";
mov1.Director = "Marvel";
mov1.Year = 2008;

movServices.AddMovie(mov1);

// Syzstem.Console.WriteLine(result > 0 ? "Success" : "Failed");
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