namespace AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<SuperHero, SuperHeroDto>();
        }
    }
}
