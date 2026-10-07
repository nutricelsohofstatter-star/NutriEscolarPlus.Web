namespace NutriEscolarPlus.Web.Models;

public class VisitaTecnica
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    // =========================================================
    // IDENTIFICAÇÃO
    // =========================================================

    public DateTime DataVisita { get; set; } = DateTime.Today;

    public string ResponsavelTecnico { get; set; } = string.Empty;

    public TipoVisitaTecnica Tipo { get; set; } =
        TipoVisitaTecnica.Rotina;

    public string Objetivo { get; set; } = string.Empty;

    public string Acompanhantes { get; set; } = string.Empty;


    // =========================================================
    // REGISTRO DA VISITA
    // =========================================================

    public string AtividadesRealizadas { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;

    public string Orientacoes { get; set; } = string.Empty;


    // =========================================================
    // BOAS PRÁTICAS
    // =========================================================

    public bool HouveVerificacaoBoasPraticas { get; set; }

    public int? VerificacaoBoasPraticasId { get; set; }


    // =========================================================
    // PENDÊNCIAS / PLANO DE AÇÃO
    // =========================================================

    public List<PendenciaVisitaTecnica> Pendencias { get; set; } = new();


    // =========================================================
    // PRÓXIMA VISITA
    // =========================================================

    public bool AgendarProximaVisita { get; set; }

    public DateTime? DataProximaVisita { get; set; }

    public string ObservacaoProximaVisita { get; set; } = string.Empty;


    // =========================================================
    // SITUAÇÃO
    // =========================================================

    public StatusVisitaTecnica Situacao { get; set; } =
        StatusVisitaTecnica.Realizada;


    // =========================================================
    // CONTROLE
    // =========================================================

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    // =========================================================
    // CAMPOS CALCULADOS
    // =========================================================

    public int TotalPendencias =>
        Pendencias.Count;

    public int TotalPendenciasAbertas =>
        Pendencias.Count(x =>
            x.Situacao == StatusPendenciaVisitaTecnica.Pendente);

    public int TotalPendenciasConcluidas =>
        Pendencias.Count(x =>
            x.Situacao == StatusPendenciaVisitaTecnica.Concluida);

    public bool PossuiPendencias =>
        TotalPendenciasAbertas > 0;
}


public class PendenciaVisitaTecnica
{
    public int Id { get; set; }

    public string Descricao { get; set; } = string.Empty;

    public string AcaoCorretiva { get; set; } = string.Empty;

    public string Responsavel { get; set; } = string.Empty;

    public DateTime? Prazo { get; set; }

    public StatusPendenciaVisitaTecnica Situacao { get; set; } =
        StatusPendenciaVisitaTecnica.Pendente;
}


public enum TipoVisitaTecnica
{
    Rotina = 1,

    Supervisao = 2,

    Acompanhamento = 3,

    Orientacao = 4,

    Retorno = 5,

    Extraordinaria = 6,

    Outra = 7
}


public enum StatusVisitaTecnica
{
    Agendada = 1,

    Realizada = 2,

    Cancelada = 3
}


public enum StatusPendenciaVisitaTecnica
{
    Pendente = 1,

    Concluida = 2
}