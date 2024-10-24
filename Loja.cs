public class Loja
{
    public List<Produto> Produtos { get; private set; }
    public List<Cliente> Clientes { get; private set; }

    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
    }

    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        foreach (var produto in Produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto; 
            }
        }
        return null;
    }


    public void ListarProdutos()
    {
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Código: {produto.Codigo}, Preço: {produto.Preco:C}");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    public void ConsultarClientePorID(string id)
    {
        foreach (var cliente in Clientes)
        {
            if (cliente.NumeroIdentificacao == id)
            {
                Console.WriteLine($"Cliente encontrado: {cliente.Nome}");
                return; 
            }
        }

        Console.WriteLine("Cliente não encontrado.");
    }



    public void ListarClientes()
    {
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes();
        }
    }
}
