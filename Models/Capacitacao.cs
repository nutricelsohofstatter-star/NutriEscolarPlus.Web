namespace NutriEscolarPlus.Web.Models;

public class Capacitacao
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }


    // =========================================================
    // IDENTIFICAÇÃO
    // =========================================================

    public string Tema { get; set; } = string.Empty;

    public DateTime DataCapacitacao { get; set; } = DateTime.Today;

    public string Responsavel { get; set; } = string.Empty;

    public string PublicoAlvo { get; set; } = string.Empty;

    public decimal? CargaHoraria { get; set; }

    public string Local { get; set; } = string.Empty;


    // =========================================================
    // CONTEÚDO
    // =========================================================

    public string Objetivo { get; set; } = string.Empty;

    public string ConteudoAbordado { get; set; } = string.Empty;

    public string Metodologia { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;


    // =========================================================
    // PARTICIPANTES
    // =========================================================

    public List<ParticipanteCapacitacao> Participantes { get; set; } = new();


    // =========================================================
    // SITUAÇÃO
    // =========================================================

    public StatusCapacitacao Situacao { get; set; } =
        StatusCapacitacao.Realizada;


    // =========================================================
    // CONTROLE
    // =========================================================

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    // =========================================================
    // CAMPOS CALCULADOS
    // =========================================================

    public int TotalParticipantes =>
        Participantes.Count;

    public bool PossuiParticipantes =>
        Participantes.Count > 0;
}


public class ParticipanteCapacitacao
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Funcao { get; set; } = string.Empty;

    public bool Presente { get; set; } = true;
}


public enum StatusCapacitacao
{
    Agendada = 1,

    Realizada = 2,

    Cancelada = 3
}