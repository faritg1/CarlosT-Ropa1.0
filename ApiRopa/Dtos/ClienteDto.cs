using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public int IdMunicipioFk { get; set; }
    }
}