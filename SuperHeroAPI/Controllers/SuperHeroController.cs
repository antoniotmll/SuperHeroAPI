using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero { 
                    Id = 1, 
                    Name = "Spider Man", 
                    FirstName = "Peter", 
                    LastName = "Parker", 
                    Place = "NYC"
                }
            };

            return Ok(heroes);
        }
    }
}
