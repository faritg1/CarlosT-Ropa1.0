using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente  : BaseEntity
    {
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        [Required]

        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TiposPersonas { get; set; }
        [Required]
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}