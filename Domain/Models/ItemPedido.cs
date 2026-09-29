using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public record ItemPedido
    {
        public required PedidoId PedidoId { get; init; }
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        public required double Valor { get; init; }
        public ItemPedido(PedidoId Id, string Nome, string Descricao, double Valor)
        {
            if (Valor < 0) throw new ArgumentException("Entrada de valor inválida");
            PedidoId = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Valor = Valor;
        }
    }
}
