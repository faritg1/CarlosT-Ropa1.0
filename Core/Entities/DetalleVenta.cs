using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double ValorUnit { get; set; }

        [Required]
        public int IdVentaFk { get; set; }
        public Venta Ventas { get; set; }
        [Required]
        public int IdInventartioFk { get; set; }
        public Inventario Inventarios { get; set; }
        [Required]
        public int IdTallaFk { get; set; }
        public Talla Tallas { get; set; }
    }
}