using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    internal class CriarPedidoRequest
    {
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required double Valor { get; set; }
    }
}
