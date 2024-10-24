public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public string Status { get; private set; }
    public List<Produto> Produtos { get; private set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em Processamento";
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        Status = "Concluído";
        Console.WriteLine("Pedido finalizado com sucesso!");
    }
}
