using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prenda : BaseEntity
    {
        [Required]
        public int IdPrenda { get; set; }
        [Required]
        public string NombrePrenda { get; set; }
        [Required]
        public double ValorUnitCop { get; set; }
        [Required]
        public double ValorUnitUsd { get; set; }

        [Required]
        public int IdEstadoFk { get; set; }
        public Estado Estados { get; set; }
        [Required]
        public int IdTipoProteccionFk { get; set; }
        public TipoProteccion TiposProtecciones { get; set; }
        [Required]
        public int IdGeneroFk { get; set; }
        public Genero Generos { get; set; }

        public ICollection<InsumoPrenda> InsumosPrendas { get; set; }
        public ICollection<DetalleOrden> DetallesOrdenes { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
    }
}