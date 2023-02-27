using LotRSDK.Models;

namespace LotRSDK.Interfaces
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int movieId);
        Task<List<Quote>> GetMovieQuotesByIdAsync(int movieId);
    }
}
