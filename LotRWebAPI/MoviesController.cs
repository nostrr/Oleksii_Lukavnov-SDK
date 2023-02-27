using LotRWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotRWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly static List<Movie> _movies = new()
        {
            new Movie { Id = 1,
                Title = "The Fellowship of the Ring",
                Director = "Peter Jackson",
                Quote = new List<Quote>(){ new Quote {Id = 1, MovieId = 1, 
                    Text = "What About Second Breakfast?" } } },
            new Movie { Id = 2,
                Title = "The Two Towers",
                Director = "Peter Jackson",
                Quote = new List<Quote>(){ new Quote {Id = 2, MovieId = 2,
                    Text = "There's Some Good In This World, Mr. Frodo, And It's Worth Fighting For." } }},
            new Movie { Id = 3,
                Title = "The Return of the King",
                Director = "Peter Jackson",
                Quote = new List<Quote>(){ new Quote {Id = 3, MovieId = 3, 
                    Text = "I Can't Carry It For You, But I Can Carry You." } }},
        };

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpGet("{id}/quotes")]
        public IActionResult GetMovieQuote(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie.Quote);
        }
    }
}
