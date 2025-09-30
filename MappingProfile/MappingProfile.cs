using AutoMapper;
using disntney_plus_api.DTOs;
using disntney_plus_api.Models;

namespace disntney_plus_api.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>();            
            CreateMap<MovieImage, MovieImageDto>();
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Gallery, opt => opt.MapFrom(src => src.CategoryGallery));
            CreateMap<CategoryGallery, CategoryGalleryDto>();
            CreateMap<Recommendation, RecommendationDto>();
        }
    }
}
