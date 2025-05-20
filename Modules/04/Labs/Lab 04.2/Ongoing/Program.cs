IEnumerable<Movie> movies = new List<Movie>
{
    new(Title: "Total Recall", Year: 2012, ImdbRating: 6.2f),
    new(Title: "Evil Dead", Year: 1981, ImdbRating: 7.5f),
    new(Title: "The Matrix", Year: 1999, ImdbRating: 8.7f),
    new(Title: "Cannonball Run", Year: 1981, ImdbRating: 6.3f),
    new(Title: "Star Wars: Episode IV - A New Hope", Year: 1977, ImdbRating: 8.6f),
    new(Title: "Don't Look Up", Year: 2021, ImdbRating: 7.3f),
    new(Title: "Evil Dead", Year: 2013, ImdbRating: 6.5f),
    new(Title: "Who Am I", Year: 2014, ImdbRating: 7.5f),
    new(Title: "Total Recall", Year: 1990, ImdbRating: 7.5f),
    new(Title: "The Interview", Year: 2014, ImdbRating: 6.5f)
};


// TODO: a) Find the movie which premiered first (without OrderBy())
Console.WriteLine("a) Find the movie which premiered first (without OrderBy())");
Movie? queryA = movies
    .MinBy(movie => movie.Year);
Console.WriteLine(queryA);


// TODO: b) Find the first movie with a rating above 9.0f
// (or the just first movie if no such high-rated movie exists)
Console.WriteLine("b) Find the first movie with a rating above 9.0f (or the just first movie if no such high-rated movie exists)");
Movie queryB = movies
    .OrderBy(movie => movie.Year)
    .ThenBy(movie => movie.ImdbRating)
    .FirstOrDefault(movie => movie.ImdbRating > 9.0f, movies.First());
Console.WriteLine(queryB);


// TODO: c) Find the second-to-last movie of the list (if it exists)
Console.WriteLine("c) Find the second-to-last movie of the list (if it exists)");
Movie? queryC = movies
    .ElementAtOrDefault(^2);

Console.WriteLine(queryC);


// TODO: d) Find all the movies except the first and last to premiere
Console.WriteLine("d) Find all the movies except the first and last to premiere");
IEnumerable<Movie> queryD = movies
    .OrderBy(movie => movie.Year)
    .Take(1..^2);// <-- Insert code here

foreach (Movie movie in queryD)
{
    Console.WriteLine(movie);
}


// TODO: e) Find the sequence movies with the remakes removed
Console.WriteLine("e) Find the sequence movies with the remakes removed");
IEnumerable<Movie> queryE = movies
    .OrderBy(movie => movie.Year)
    .DistinctBy(movie => movie.Title);
// group by title
// .Select(group => group.OrderBy(movie => movie.Year).First());

foreach (Movie movie in queryE)
{
    Console.WriteLine(movie);
}


// TODO: f) Group the movies into groups of 4 movies each
// (with the last group potentially containing fewer than 4 elements,
//  if 4 does not divide the total number of movies)
Console.WriteLine("f) Group the movies into groups of 4 movies each (with the last group potentially containing fewer than 4 elements, if 4 does not divide the total number of movies)");
var queryF = movies.Chunk(4); // <-- Insert code here

foreach (var chunk in queryF)
{
    foreach (Movie movie in chunk)
    {
        Console.WriteLine(movie);
    }
    Console.WriteLine();
}
