using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoProveedor
    {
        [Required]
        public int IdInsumofk { get; set; }
        public Insumo Insumos { get; set; }
        [Required]
        public int IdProveedorfk { get; set; }
        public Proveedor Proveedores { get; set; }
    }
}