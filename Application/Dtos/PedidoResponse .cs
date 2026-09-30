using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public record PedidoResponse
    {
        public required PedidoId PedidoId { get; init; }
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        public required double Valor { get; init; }

        public required string Classificacao { get; init; }
    }
}
