using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InventarioTalla
    {
        [Required]
        public int IdInvFk { get; set; }
        public Inventario Inventarios { get; set; }
        [Required]
        public int IdTallaFk { get; set; }
        public Talla Tallas { get; set; }
    }
}