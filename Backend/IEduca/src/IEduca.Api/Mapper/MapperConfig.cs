using AutoMapper;
using IEduca.Model;
using IEduca.Model.Dto;
using System;
using IEduca.Model.Helper;
namespace IEduca.Api.Mapper
{

    public class MapperConfig : Profile
        {
            public MapperConfig()
            {
                CreateMap<Album, AlbumListDto>();
                CreateMap<AlbumCreateDto, Album>();
                CreateMap<Album, AlbumDto>();
                CreateMap<Cancion, CancionSingleDto>().ForMember(
                    x => x.Duracion,
                    x => x.MapFrom(x => x.Duracion.ToString(@"mm\:ss"))
                    );
                CreateMap<CancionSingleDto, Cancion>().ForMember(
                    x => x.Duracion,
                    x => x.MapFrom( x => x.Duracion.GetMinutesAndSeconds())
                    );
        }
        }
    

}
