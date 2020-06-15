using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroArticulo.Entidades
{
    class Articulo
    {
        [Key]
        public int ProductoId { get; set; }
        public int Descripcion { get; set; }
        public float Costo { get; set; }
        public float ValorInv { get; set; }
    }
}
