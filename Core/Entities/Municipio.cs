using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Municipio : BaseEntity
    {
        [Required]
        public string NombrePais { get; set; }

        [Required]
        public int IdDepar { get; set; }
        public Departamento Departamentos { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
    }
}