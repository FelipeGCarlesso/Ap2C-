public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public string Categoria { get; set; }

    public ProdutoFisico(string nome, string codigo, decimal preco, double peso, string categoria)
        : base(nome, codigo, preco)
    {
        Peso = peso;
        Categoria = categoria;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaDeImposto = 0.1m;
        decimal custoDeEnvio = (decimal)(Peso * 5.0);
        return Preco + (Preco * taxaDeImposto) + custoDeEnvio;
    }
}
