using LotRSDK.Clients;
using LotRSDK.Deserializer;
using LotRSDK.Enums;
using LotRSDK.Interfaces;
using LotRSDK.Models;

namespace LotRSDK.Services
{
    public class MovieService : IMovieService, IDisposable
    {
        private readonly IClient _client;
        private readonly string _baseUrl = Config.BaseUrl;
        private readonly IDeserialize _deserializer;

        /// <summary>
        /// The class allows a simple way to access movie data from the Lord of the Rings API.
        /// </summary>
        /// <param name="clientType">Enum type for choise client.</param>
        /// <param name="baseUrl">Base url for API.</param>
        public MovieService(ClientType clientType, string baseUrl = default)
        {
            if (baseUrl != null)
            {
                _baseUrl = baseUrl;
            }
            _client = ClientFactory.CreateClient(clientType);
            _deserializer = new JsonDeserializer();
        }

        /// <summary>
        /// Get a list of all movies
        /// </summary>
        /// <returns>List of movies.</returns>
        public async Task<List<Movie>> GetMoviesAsync()
        {
            var content = await _client.GetContentAsync(_baseUrl);
            var movies = _deserializer.Deserialize<List<Movie>>(content);
            return movies;
        }

        /// <summary>
        /// Get a specific movie by ID
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns>Movie</returns>
        public async Task<Movie> GetMovieByIdAsync(int movieId)
        {
            var content = await _client.GetContentAsync($"{_baseUrl}/{movieId}");
            var movie = _deserializer.Deserialize<Movie>(content);
            return movie;
        }

        /// <summary>
        /// Get quotes for a specific movie by ID
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns>Quotes</returns>
        public async Task<List<Quote>> GetMovieQuotesByIdAsync(int movieId)
        {
            var content = await _client.GetContentAsync($"{_baseUrl}/{movieId}/quotes");
            var quotes = _deserializer.Deserialize<List<Quote>>(content);
            return quotes;
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
