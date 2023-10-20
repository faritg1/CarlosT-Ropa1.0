using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class ProveedorDto
    {
        public int Id { get; set; }
        public int NitProv { get; set; }
        public string NombreProv { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public int IdMunicipioFk { get; set; }
    }
}