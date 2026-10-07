namespace NutriEscolarPlus.Web.Models;

public class FichaTecnica
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public string NomePreparacao { get; set; } = string.Empty;

    public CategoriaFichaTecnica Categoria { get; set; }
        = CategoriaFichaTecnica.Outros;

    public decimal Rendimento { get; set; }

    public string UnidadeRendimento { get; set; } = "porções";

    public decimal? PesoPorcao { get; set; }

    public string UnidadePesoPorcao { get; set; } = "g";

    public string ModoPreparo { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;

    public StatusFichaTecnica Situacao { get; set; }
        = StatusFichaTecnica.Ativa;

    public List<IngredienteFichaTecnica> Ingredientes { get; set; }
        = new();

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }
}


public class IngredienteFichaTecnica
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public decimal Quantidade { get; set; }

    public string UnidadeMedida { get; set; } = string.Empty;
}


public enum CategoriaFichaTecnica
{
    CafeDaManha = 1,
    Lanche = 2,
    Almoco = 3,
    Jantar = 4,
    Sobremesa = 5,
    Bebida = 6,
    Outros = 7
}


public enum StatusFichaTecnica
{
    Ativa = 1,
    Inativa = 2
}