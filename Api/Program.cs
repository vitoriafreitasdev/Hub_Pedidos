using Application.Dtos;
using Application.Conversions;
using Domain.Models;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapPost("/", 
    (CriarPedidoRequest pedido) => 
    {
        ItemPedido pedidoDomain =
             new ItemPedido
             {
                 PedidoId = new PedidoId { Id = Guid.NewGuid().ToString() },
                 Nome = pedido.Nome,
                 Descricao = pedido.Descricao,
                 Valor = pedido.Valor
             };
  
        //fazendo o mapeamento do domínio para o DTO de resposta
        PedidoResponse resposta = MapeamentoDtoDomain
        .ItemPedidoParaPedidoResponse(pedidoDomain);

        return Results.Ok(resposta);
    }
); 

app.Run();
