using LotRSDK.Enums;
using LotRSDK.Services;

namespace LordOfTheRingsSDK.Tests
{
    public class MovieServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(ClientType.HttpClient)]
        [TestCase(ClientType.WebClient)]
        [TestCase(ClientType.HttpWebRequest)]
        public void GetMovies_ReturnsNonEmptyList(ClientType clientType)
        {
            var movieService = new MovieService(clientType);

            var movies = movieService.GetMoviesAsync();

            Assert.That(movies.Result, Is.Not.Empty);
        }

        [Test]
        [TestCase(ClientType.HttpClient)]
        [TestCase(ClientType.WebClient)]
        [TestCase(ClientType.HttpWebRequest)]
        public void GetMovieById_ReturnsNonEmptyObject(ClientType clientType)
        {
            var movieService = new MovieService(clientType);

            var movie = movieService.GetMovieByIdAsync(2);

            Assert.That(movie.Result, Is.Not.Null);
        }

        [Test]
        [TestCase(ClientType.HttpClient)]
        [TestCase(ClientType.WebClient)]
        [TestCase(ClientType.HttpWebRequest)]
        public void GetMovieQuotes_ReturnsNonEmptyList(ClientType clientType)
        {
            var movieService = new MovieService(clientType);

            var quotes = movieService.GetMovieQuotesByIdAsync(1);

            Assert.That(quotes.Result, Is.Not.Empty);
        }
    }
}
