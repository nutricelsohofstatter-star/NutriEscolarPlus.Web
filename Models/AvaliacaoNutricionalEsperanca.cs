namespace NutriEscolarPlus.Web.Models;

public class AvaliacaoNutricionalEsperanca
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; } = 2;

    public int AlunoId { get; set; }

    public string AlunoNome { get; set; } = string.Empty;

    public int? GrupoId { get; set; }

    public string GrupoNome { get; set; } = string.Empty;

    public DateTime DataAvaliacao { get; set; } = DateTime.Today;

    public decimal? PesoKg { get; set; }

    public decimal? AlturaCm { get; set; }

    public decimal? Imc { get; set; }

    public string Classificacao { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    public decimal? CalcularImc()
    {
        if (!PesoKg.HasValue ||
            !AlturaCm.HasValue ||
            PesoKg.Value <= 0 ||
            AlturaCm.Value <= 0)
        {
            return null;
        }

        var alturaMetros =
            AlturaCm.Value / 100m;

        if (alturaMetros <= 0)
            return null;

        return Math.Round(
            PesoKg.Value /
            (alturaMetros * alturaMetros),
            2
        );
    }
}