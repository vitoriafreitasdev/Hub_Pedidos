using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public record PedidoId
    {
        public required string Id { get; init; }
    }
}
