namespace AutoMapper.Services.SuperHeroService
{
    public class ISuperHeroService
    {
        List<SuperHero> GetHeroes();

        List<SuperHero> AddHero(SuperHeroDto newHero);
    }
 }
