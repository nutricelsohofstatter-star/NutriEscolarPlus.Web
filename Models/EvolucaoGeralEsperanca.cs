namespace NutriEscolarPlus.Web.Models;

public class EvolucaoGeralEsperanca
{
    public int Id { get; set; }

    public int EncontroId { get; set; }

    public int GrupoId { get; set; }

    public DateTime Data { get; set; }

    public string Evolucao { get; set; } = string.Empty;

    public string Profissional { get; set; } = string.Empty;

    public DateTime DataRegistro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }
}