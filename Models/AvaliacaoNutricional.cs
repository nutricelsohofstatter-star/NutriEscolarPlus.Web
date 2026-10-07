namespace NutriEscolarPlus.Web.Models;

public class AvaliacaoNutricional
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public int AlunoId { get; set; }

    public string AlunoNome { get; set; } = string.Empty;

    public DateTime DataAvaliacao { get; set; } = DateTime.Today;


    // =========================================================
    // DADOS ANTROPOMÉTRICOS
    // =========================================================

    public decimal? PesoKg { get; set; }

    public decimal? AlturaCm { get; set; }


    // =========================================================
    // RESULTADO NUTRICIONAL
    // =========================================================

    /// <summary>
    /// Escore-Z do IMC para idade.
    /// Calculado conforme a referência antropométrica
    /// utilizada pelo sistema.
    /// </summary>
    public decimal? EscoreZImcIdade { get; set; }


    /// <summary>
    /// Classificação nutricional resultante da avaliação.
    /// Exemplo: Eutrofia, Magreza, Sobrepeso etc.
    /// </summary>
    public string Classificacao { get; set; } = string.Empty;


    /// <summary>
    /// Indicador antropométrico utilizado na classificação.
    /// </summary>
    public string IndicadorClassificacao { get; set; } =
        string.Empty;


    /// <summary>
    /// Referência utilizada para realizar a classificação.
    /// </summary>
    public string ReferenciaClassificacao { get; set; } =
        string.Empty;


    // =========================================================
    // OBSERVAÇÕES
    // =========================================================

    public string Observacoes { get; set; } = string.Empty;


    // =========================================================
    // CONTROLE
    // =========================================================

    public DateTime DataCadastro { get; set; } =
        DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    // =========================================================
    // IMC
    // =========================================================

    public decimal? Imc
    {
        get
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


            return Math.Round(
                PesoKg.Value /
                (alturaMetros * alturaMetros),
                2);
        }
    }
}