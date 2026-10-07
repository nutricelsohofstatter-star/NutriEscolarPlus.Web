namespace NutriEscolarPlus.Web.Models;

public class ModeloPop
{
    public int Id { get; set; }

    public string Codigo { get; set; } =
        string.Empty;

    public string Titulo { get; set; } =
        string.Empty;

    public CategoriaPop Categoria { get; set; }

    public string Descricao { get; set; } =
        string.Empty;

    public string Objetivo { get; set; } =
        string.Empty;

    public string CampoAplicacao { get; set; } =
        string.Empty;

    public string Responsabilidades { get; set; } =
        string.Empty;

    public string Frequencia { get; set; } =
        string.Empty;

    public string Monitoramento { get; set; } =
        string.Empty;

    public string Registros { get; set; } =
        string.Empty;

    public string AcoesCorretivas { get; set; } =
        string.Empty;

    public string Observacoes { get; set; } =
        string.Empty;

    public string Referencias { get; set; } =
        string.Empty;

    public List<string> Materiais { get; set; } =
        new();

    public List<string> Etapas { get; set; } =
        new();
}