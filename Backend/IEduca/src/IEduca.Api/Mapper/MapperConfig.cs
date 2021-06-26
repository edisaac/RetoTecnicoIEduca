using AutoMapper;
using IEduca.Model;
using IEduca.Model.Dto;

namespace IEduca.Api.Mapper
{

    public class MapperConfig : Profile
        {
            public MapperConfig()
            {
                CreateMap<Album, AlbumListDto>();
                CreateMap<AlbumCreateDto, Album>();
                CreateMap<CancionCreateDto, Cancion>();
                CreateMap<Album, AlbumSingleDto>();
                CreateMap<Cancion, CancionSingleDto>();

            }
        }
    
}
