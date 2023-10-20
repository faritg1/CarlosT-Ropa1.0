using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden : BaseEntity
    {
        [Required]
        public int CantidadProducir { get; set; }
        [Required]
        public int CantidadProducida { get; set; }

        [Required]
        public int IdOrdenFk { get; set; }
        public Orden Ordenes { get; set; }
        [Required]
        public int IdPrendaFk { get; set; }
        public Prenda Prendas { get; set; }
        [Required]
        public int IdEstadoFk { get; set; }
        public Estado Estados { get; set; }
        [Required]
        public int IdColorFk { get; set; }
        public Color Colores { get; set; }
    }
}