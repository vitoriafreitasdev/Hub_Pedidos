using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    internal class PedidoResponse
    {
        public bool CriadoComSucesso { get; set; }
        public ItemPedido? pedidoCriado { get; set; }
        public string? Erro { get; set; }
    }
}
