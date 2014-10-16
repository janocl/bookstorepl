using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPL2.Models
{
    public class LibroVM
    {
        public short IDLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public short IDEditorial { get; set; }
        public short Paginas { get; set; }
        public decimal Precio { get; set; }
        public byte[] Imagen { get; set; }
        public System.DateTime Publicacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> Stock { get; set; }
    }
}