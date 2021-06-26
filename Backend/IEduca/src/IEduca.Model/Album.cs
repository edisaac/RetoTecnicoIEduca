using System;
using System.Collections.Generic;

namespace IEduca.Model
{
    public class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Portada { get; set; }
        public List<Cancion> Canciones { get; set; }

    }
}
