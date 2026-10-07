namespace NutriEscolarPlus.Web.Models;

public class ResultadoAntropometrico
{
    public int IdadeMeses { get; set; }

    public decimal PesoKg { get; set; }

    public decimal AlturaCm { get; set; }

    public decimal Imc { get; set; }


    // =========================================================
    // IMC / IDADE
    // =========================================================

    public double? EscoreZImcIdade { get; set; }

    public string ClassificacaoImcIdade { get; set; } =
        string.Empty;


    // =========================================================
    // ESTATURA / IDADE
    // =========================================================

    public double? EscoreZEstaturaIdade { get; set; }

    public string ClassificacaoEstaturaIdade { get; set; } =
        string.Empty;


    // =========================================================
    // PESO / IDADE
    // =========================================================

    public double? EscoreZPesoIdade { get; set; }

    public string ClassificacaoPesoIdade { get; set; } =
        string.Empty;


    // =========================================================
    // RESULTADO PRINCIPAL
    // =========================================================

    public string EstadoNutricional { get; set; } =
        string.Empty;

    public string Referencia { get; set; } =
        string.Empty;

    public bool CalculoConcluido { get; set; }

    public string Mensagem { get; set; } =
        string.Empty;
}