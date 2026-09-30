using System;
using System.Collections.Generic;
using System.Text;

// mudando coisas 
namespace Domain.Models
{
    public record ItemPedido
    {
        public required PedidoId PedidoId { get; init; }
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        private readonly double _valor;
        public required double Valor
        {
            get => _valor;
            init
            {
                if (value < 0) throw new ArgumentException("Valor inválido");
                _valor = value;
            }
        }

        public ItemPedido CriarPedido(string nome, string descricao, double valor)
        {
            return new ItemPedido
            {
                PedidoId = new PedidoId{ Id = Guid.NewGuid().ToString() },
                Nome = nome,
                Descricao = descricao,
                Valor = valor
            };
        }
        public string ClassificacaoPedido()
        {
            string classificacao = Valor switch 
            {
                >= 100 => "Deluxe",
                >= 50 => "Premium",
                >= 25 => "Standard",
                _ => "Basic"
            };

            return classificacao;
        }

    }
}
