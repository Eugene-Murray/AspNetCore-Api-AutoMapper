using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Example mapping from a source type to a destination type
        CreateMap<SourceClass, DestinationClass>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name));

        // ReverseMap() allows two-way mapping
        CreateMap<DestinationClass, SourceClass>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
            .ReverseMap();
    }
}
