namespace NutriEscolarPlus.Web.Models;

public class Cardapio
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public string InstituicaoNome { get; set; } = string.Empty;

    public int Mes { get; set; }

    public int Ano { get; set; }

    public StatusCardapio Status { get; set; } =
        StatusCardapio.Rascunho;

    public DateTime DataCriacao { get; set; } =
        DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }

    public DateTime? DataFinalizacao { get; set; }

    public string Observacoes { get; set; } =
        string.Empty;

    public List<ItemCardapio> Itens { get; set; } =
        new();
}


public class ItemCardapio
{
    public int Id { get; set; }

    public int CardapioId { get; set; }

    public DateTime Data { get; set; }

    public string Refeicao { get; set; } =
        string.Empty;

    public string Preparacoes { get; set; } =
        string.Empty;
}


public enum StatusCardapio
{
    Rascunho = 1,

    Finalizado = 2
}