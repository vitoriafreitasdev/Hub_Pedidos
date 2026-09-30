using Domain.Models;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<double> valores = new List<double> { 75.0, 100.5, 25.0, 20.0 };
            List<ItemPedido> pedidos = new List<ItemPedido>();
            foreach (double valor in valores)
            {
                ItemPedido pedido = new ItemPedido
                {
                    PedidoId = new PedidoId { Id = "1" + valor },
                    Nome = "Produto Teste",
                    Descricao = "Descrição do Produto Teste",
                    Valor = valor
                };
                pedidos.Add(pedido);
            }

            List<string> resultado = new List<string> { "Premium", "Deluxe", "Standard", "Basic" };

            List<string> classificoes = pedidos.Select(p => p.ClassificacaoPedido()).ToList();
            Assert.Equal(resultado, classificoes);
        }
    }
}
