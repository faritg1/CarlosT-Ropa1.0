using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        [Required]
        public int CodigoInv { get; set; }
        [Required]
        public double ValorVtaCop { get; set; }
        [Required]
        public double ValorUsd { get; set; }

        [Required]
        public int IdPrendaFk { get; set; }
        public Prenda Prendas { get; set; }

        public ICollection<InventarioTalla> InventariosTallas { get; set; }
        public ICollection<DetalleVenta> DetallesVentas { get; set; }
    }
}