
using AutoMapper;
using HomeAccountingApi.Dto;
using HomeAccountingApi.Models;

namespace HomeAccountingApi.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<AccesToVentilation, 
                AccesToVentilationDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Flat, FlatDto>().ReverseMap();
            CreateMap<Bath, BathDto>().ReverseMap();
            CreateMap<Bathroom, BathroomDto>().ReverseMap();
            CreateMap<BathroomType, BathroomTypeDto>().ReverseMap();
            CreateMap<DraftVentilation, DraftVentilationDto>().ReverseMap();
            CreateMap<Home, HomeDto>().ReverseMap();
            CreateMap<Kitchen, KitchenDto>().ReverseMap();

            CreateMap<ReasonAbcenseToilet, 
                ReasonAbcenseToiletDto>().ReverseMap();

            CreateMap<ReasonAbcenseVentilation, 
                ReasonAbcenseVentilationDto>().ReverseMap();

            CreateMap<Redevelopment, RedevelopmentDto>().ReverseMap();
            CreateMap<Toilet, ToiletDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Ventilation, VentilationDto>().ReverseMap();
            CreateMap<WindowType, WindowTypeDto>().ReverseMap();
        }
    }
}