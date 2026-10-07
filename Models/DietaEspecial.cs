namespace NutriEscolarPlus.Web.Models;

public class DietaEspecial
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public int AlunoId { get; set; }

    public string AlunoNome { get; set; } = string.Empty;

    public string Turma { get; set; } = string.Empty;

    public TipoDietaEspecial Tipo { get; set; } =
        TipoDietaEspecial.AlergiaAlimentar;

    public string DiagnosticoNecessidade { get; set; } =
        string.Empty;

    public string AlimentosRestritos { get; set; } =
        string.Empty;

    public string SubstituicoesOrientacoes { get; set; } =
        string.Empty;

    public string Observacoes { get; set; } =
        string.Empty;

    public StatusDietaEspecial Situacao { get; set; } =
        StatusDietaEspecial.Ativa;

    public DateTime DataInicio { get; set; } =
        DateTime.Today;

    public DateTime? DataFim { get; set; }

    public DateTime DataCadastro { get; set; } =
        DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }
}


public enum TipoDietaEspecial
{
    AlergiaAlimentar = 1,
    IntoleranciaAlimentar = 2,
    DoencaCeliaca = 3,
    Diabetes = 4,
    OutraNecessidade = 5
}


public enum StatusDietaEspecial
{
    Ativa = 1,
    Inativa = 2
}