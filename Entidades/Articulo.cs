using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroArticulo.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public int Descripcion { get; set; }
        public float Costo { get; set; }
        public float ValorInv { get; set; }
    }
}
