namespace NutriEscolarPlus.Web.Services;

public class PortfolioService
{
    public PortfolioConfiguracao Configuracao { get; private set; } = new();

    public void Salvar(PortfolioConfiguracao configuracao)
    {
        Configuracao = configuracao;
    }

    public void RestaurarPadrao()
    {
        Configuracao = new PortfolioConfiguracao();
    }
}


public class PortfolioConfiguracao
{
    // =========================================================
    // INSTITUIÇÃO
    // =========================================================

    public string NomeInstituicao { get; set; } = string.Empty;

    public string TipoInstituicao { get; set; } = "Escola";


    // =========================================================
    // PROFISSIONAL
    // =========================================================

    public string NomeProfissional { get; set; }
        = "Celso Felipe Roos Hofstatter";

    public string Profissao { get; set; }
        = "Nutricionista";

    public string Crn { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Instagram { get; set; } = string.Empty;


    // =========================================================
    // PROPOSTA
    // =========================================================

    public string FrequenciaVisitas { get; set; } = string.Empty;

    public string CargaHoraria { get; set; } = string.Empty;

    public string Investimento { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;


    // =========================================================
    // SERVIÇOS
    // =========================================================

    public bool ResponsabilidadeTecnica { get; set; } = true;

    public bool Cardapios { get; set; } = true;

    public bool FichasTecnicas { get; set; } = true;

    public bool Pops { get; set; } = true;

    public bool BoasPraticas { get; set; } = true;

    public bool VisitasTecnicas { get; set; } = true;

    public bool Capacitacoes { get; set; } = true;

    public bool DietasEspeciais { get; set; } = true;

    public bool EducacaoAlimentar { get; set; } = true;

    public bool AvaliacaoNutricional { get; set; } = true;
}