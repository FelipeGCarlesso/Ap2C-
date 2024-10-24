public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, string codigo, decimal preco, double tamanhoArquivo, string formato)
        : base(nome, codigo, preco)
    {
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal desconto = 0.1m; // 10% de desconto
        return Preco - (Preco * desconto);
    }
}
