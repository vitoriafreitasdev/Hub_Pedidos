using Application.Dtos;
using Domain.Models;

using System.Reflection.Metadata.Ecma335;

namespace Application.Conversions
{
    public static class MapeamentoDtoDomain
    {
        public static PedidoResponse ItemPedidoParaPedidoResponse(ItemPedido pedido)
        {
            string classificacao = pedido.ClassificacaoPedido();
            return new PedidoResponse
            {
                PedidoId = pedido.PedidoId,
                Nome = pedido.Nome,
                Descricao = pedido.Descricao,
                Valor = pedido.Valor,
                Classificacao = classificacao
            };
        }
    }
}
/*
// Domínio
public class Produto 
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

// DTO
public record ProdutoResponseDto(Guid Id, string Nome, decimal Preco);

// Classe de Mapeamento Explicit
public static class ProdutoMappingExtensions
{
    public static ProdutoResponseDto ToResponseDto(this Produto produto)
    {
        return new ProdutoResponseDto(
            produto.Id,
            produto.Nome,
            produto.Preco
        );
    }

    public static Produto ToDomain(this ProdutoResponseDto dto)
    {
        return new Produto
        {
            Id = dto.Id,
            Nome = dto.Nome,
            Preco = dto.Preco
        };
    }
}

// Entidade para DTO
ProdutoResponseDto dto = produto.ToResponseDto();

// Lista de Entidades para Lista de DTOs (via LINQ)
var dtos = produtos.Select(p => p.ToResponseDto()).ToList();

 */