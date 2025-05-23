using Microsoft.AspNetCore.Mvc;
using modul10_103022300043;

namespace modul10_103022300042.Controllers
{
    [ApiController]
    [Route("api/Movies")]
    public class MahasiswaControllers : ControllerBase
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie ( "The Shawshank Redemption","Frank Darabont", ["Tim Robbins","Morgam Freeman", "Bob Gunton"],"A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion." ),
            new Movie ( "The Godfather", "Francis Ford Coppola", ["Marlon Brando", "AI Pacino","James Caan"],"The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." ),
            new Movie ( "The Dark Knight", "Christopher Nolan", ["Christian Bale","Heath Ledger","Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness." )
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return movieList;
        }

        [HttpGet("{index}")]
        public ActionResult<Movie> Get(int index)
        {
            if (index < 0 || index >= movieList.Count)
            {
                return NotFound();
            }
            return movieList[index];
        }

        [HttpPost]
        public ActionResult<List<Movie>> Post([FromBody] Movie mov)
        {
            movieList.Add(mov);
            return movieList;
        }
        [HttpDelete("{index}")]
        public ActionResult<List<Movie>> Delete(int index)
        {
            if (index < 0 || index >= movieList.Count)
            {
                return NotFound();
            }
            movieList.RemoveAt(index);
            return movieList;
        }
    }
}