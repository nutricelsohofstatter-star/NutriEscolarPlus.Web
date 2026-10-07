namespace NutriEscolarPlus.Web.Models;

public class SolicitacaoInstituicao
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public string InstituicaoNome { get; set; } = string.Empty;

    public TipoSolicitacaoInstituicao Tipo { get; set; }
        = TipoSolicitacaoInstituicao.Outro;

    public string Assunto { get; set; } = string.Empty;

    public string Mensagem { get; set; } = string.Empty;

    public string EnviadoPor { get; set; } = string.Empty;

    public DateTime DataEnvio { get; set; } = DateTime.Now;

    public StatusSolicitacaoInstituicao Status { get; set; }
        = StatusSolicitacaoInstituicao.Nova;

    public string RespostaNutricionista { get; set; } = string.Empty;

    public DateTime? DataResposta { get; set; }

    public DateTime? DataAtualizacao { get; set; }


    public bool PossuiResposta =>
        !string.IsNullOrWhiteSpace(RespostaNutricionista);


    public bool EstaFinalizada =>
        Status == StatusSolicitacaoInstituicao.Concluida;
}


public enum TipoSolicitacaoInstituicao
{
    Duvida = 1,

    Alteracao = 2,

    RestricaoAlimentar = 3,

    SolicitarVisita = 4,

    Cardapio = 5,

    Documento = 6,

    Outro = 7,

    ConversaPaisResponsaveis = 8
}


public enum StatusSolicitacaoInstituicao
{
    Nova = 1,

    EmAnalise = 2,

    Respondida = 3,

    Concluida = 4
}