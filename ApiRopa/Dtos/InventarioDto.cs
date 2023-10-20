using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRopa.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }
        public int CodigoInv { get; set; }
        public double ValorVtaCop { get; set; }
        public double ValorUsd { get; set; }
        public int IdPrendaFk { get; set; }
    }
}