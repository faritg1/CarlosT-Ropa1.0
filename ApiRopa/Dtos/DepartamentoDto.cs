using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public string NombreDepar { get; set; }
        public int IdPaisFk { get; set; }
    }
}