using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEduca.Model.Dto
{
    public class CancionCreateDto
    {
        public string Nombre { get; set; }
        public TimeSpan Duracion { get; set; }
        public string Enlace { get; set; }
        public int AlbumId { get; set; }
    }

    public class CancionSingleDto
    {
        public string Nombre { get; set; }
        public TimeSpan Duracion { get; set; }
        public string Enlace { get; set; }
    }
}
