namespace NutriEscolarPlus.Web.Models;

public class EducacaoAlimentar
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }


    // =========================================================
    // IDENTIFICAÇÃO DA AÇÃO
    // =========================================================

    public string Tema { get; set; } = string.Empty;

    public DateTime DataAcao { get; set; } = DateTime.Today;

    public string Responsavel { get; set; } = string.Empty;

    public StatusEducacaoAlimentar Situacao { get; set; } =
        StatusEducacaoAlimentar.Realizada;


    // =========================================================
    // PÚBLICO
    // =========================================================

    public string PublicoAlvo { get; set; } = string.Empty;

    public string Turma { get; set; } = string.Empty;

    public string FaixaEtaria { get; set; } = string.Empty;

    public int NumeroParticipantes { get; set; }


    // =========================================================
    // PLANEJAMENTO
    // =========================================================

    public string Objetivo { get; set; } = string.Empty;

    public string ConteudoTrabalhado { get; set; } = string.Empty;

    public string Metodologia { get; set; } = string.Empty;

    public string MateriaisUtilizados { get; set; } = string.Empty;

    public int? DuracaoMinutos { get; set; }


    // =========================================================
    // AVALIAÇÃO DA ATIVIDADE
    // =========================================================

    public string ParticipacaoPublico { get; set; } = string.Empty;

    public string ResultadosObservados { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;


    // =========================================================
    // CONTROLE
    // =========================================================

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    // =========================================================
    // CAMPOS CALCULADOS
    // =========================================================

    public bool PossuiParticipantes =>
        NumeroParticipantes > 0;

    public string DuracaoFormatada
    {
        get
        {
            if (!DuracaoMinutos.HasValue ||
                DuracaoMinutos.Value <= 0)
            {
                return "Não informada";
            }

            var minutos =
                DuracaoMinutos.Value;

            if (minutos < 60)
            {
                return $"{minutos} min";
            }

            var horas =
                minutos / 60;

            var restante =
                minutos % 60;

            if (restante == 0)
            {
                return horas == 1
                    ? "1 hora"
                    : $"{horas} horas";
            }

            return $"{horas}h {restante}min";
        }
    }
}


public enum StatusEducacaoAlimentar
{
    Agendada = 1,

    Realizada = 2,

    Cancelada = 3
}