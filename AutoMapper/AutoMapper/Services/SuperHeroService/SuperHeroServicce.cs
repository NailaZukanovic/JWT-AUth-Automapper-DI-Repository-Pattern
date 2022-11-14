namespace AutoMapper.Services.SuperHeroService
{
    public class SuperHeroServicce : ISuperHeroService
    {
        private static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero {
                Id = 1,
                Name ="Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City",
                DateAdded = new DateTime(2001, 08, 10),
                DateModified = null
            },
            new SuperHero {
                Id = 2,
                Name ="Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu",
                DateAdded = new DateTime(1970, 05, 29),
                DateModified = null
            }
        };

        private IMapper _mapper;

        public SuperHeroServicce(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<SuperHero>> GetHeroes()
        {
            return Ok(heroes.Select(hero => _mapper.Map<SuperHeroDto>(hero)));
        }

        [HttpPost]
        public ActionResult<List<SuperHero>> AddHero(SuperHeroDto newHero)
        {
            var hero = _mapper.Map<SuperHero>(newHero);
            heroes.Add(hero);

            return Ok(heroes.Select(hero => _mapper.Map<SuperHeroDto>(hero)));
        }
    }
}
}
