using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda
    {
        [Required]
        public int IdInsumoFk { get; set; }
        public Insumo Insumos { get; set; }
        [Required]
        public int IdPrendaFk { get; set; }
        public Prenda Prendas { get; set; }
    }
}