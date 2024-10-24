
        Loja loja = new Loja();

       
        Produto produtoFisico = new ProdutoFisico("Celular", "001", 1500.00m, 0.5, "Eletrônicos");
        Produto produtoDigital = new ProdutoDigital("E-book", "002", 30.00m, 15.0, "PDF");

        loja.CadastrarProduto(produtoFisico); 
        loja.CadastrarProduto(produtoDigital); 

 
        Cliente cliente = new Cliente("João Silva", "123456789", "Rua A, 123", "joao@email.com");
        loja.CadastrarCliente(cliente); 

        
        Pedido pedido = new Pedido(cliente); 
        pedido.AdicionarProduto(produtoFisico); 
        pedido.AdicionarProduto(produtoDigital); 

        Console.WriteLine($"Total do pedido: {pedido.CalcularTotal():C}"); 

 
        pedido.FinalizarPedido(); 

  
        loja.ListarProdutos();
        loja.ListarClientes(); 
