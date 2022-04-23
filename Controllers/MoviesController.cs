using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204080.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movies> listFilm = new List<Movies>()
        {
            new Movies("The Shawshank Redemption", "Frank Darabont", "Morgan Freeman", "Tim Robbins", "Bob Gunton" , "Wlliam Sadler" , "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movies("The Godfather", "Francis Ford Coppola", "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight", "Christopher Nolan", "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };
        


        // GET: api/Movies
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return listFilm;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return listFilm[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            listFilm.Add(value);
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listFilm.RemoveAt(id);
        }
    }
}
