using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proveedor : BaseEntity
    {
        [Required]
        public int NitProv { get; set; }
        [Required]
        public string NombreProv { get; set; }

        [Required]
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TiposPersonas { get; set; }
        [Required]
        public int IdMunicipioFk { get; set; }
        public Municipio Municipios { get; set; }

        public ICollection<InsumoProveedor> InsumosProveedores { get; set; }
    }
}