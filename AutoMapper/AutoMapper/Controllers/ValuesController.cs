using AutoMapper.Services.SuperHeroService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        private readonly ISuperHeroService superHeroService;

        public SuperHeroController(IMapper mapper, ISuperHeroService _superHeroService)
        {
            _mapper = mapper;
            superHeroService = _superHeroService;
        }

        [HttpGet]
        public ActionResult<List<SuperHero>> GetHeroes()
        {
            var result = superHeroService.GetHeroes();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero(SuperHeroDto newHero)
        {
            var result = superHeroService.AddHero(newHero);
            return result;
        }
    }
}
