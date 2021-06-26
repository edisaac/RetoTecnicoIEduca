using System.Collections.Generic;

namespace IEduca.Model.Dto
{
    public class AlbumListDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Portada { get; set; }
    }

    public class AlbumCreateDto
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Portada { get; set; }
        public List<CancionSingleDto> Canciones { get; set; }
    }

    public class AlbumDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Portada { get; set; }
        public List<CancionSingleDto> Canciones { get; set; }
    }
}
