using System;

namespace IEduca.Model
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Duracion { get; set; }
        public string Enlace { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
