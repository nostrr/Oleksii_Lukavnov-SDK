using LotRSDK.Enums;
using LotRSDK.Services;

namespace LotRSDKSampleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movieService = new MovieService(ClientType.HttpClient);

            var movies = movieService.GetMoviesAsync();

            var movie = movieService.GetMovieByIdAsync(1);

            var quotes = movieService.GetMovieQuotesByIdAsync(1);

            Console.WriteLine(movies.Result);
            Console.WriteLine(movie.Result);
            Console.WriteLine(quotes.Result);
        }
    }
}