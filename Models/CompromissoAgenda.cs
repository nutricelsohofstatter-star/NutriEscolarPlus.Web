namespace NutriEscolarPlus.Web.Models;

public class CompromissoAgenda
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public string Titulo { get; set; } =
        string.Empty;

    public string Descricao { get; set; } =
        string.Empty;

    public DateTime Data { get; set; } =
        DateTime.Today;

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public TipoCompromissoAgenda Tipo { get; set; } =
        TipoCompromissoAgenda.Outro;

    public StatusCompromissoAgenda Status { get; set; } =
        StatusCompromissoAgenda.Agendado;

    public string Local { get; set; } =
        string.Empty;

    public string Responsavel { get; set; } =
        string.Empty;

    public string Observacoes { get; set; } =
        string.Empty;

    public bool DiaInteiro { get; set; }

    public bool CriadoAutomaticamente { get; set; }

    public string ModuloOrigem { get; set; } =
        string.Empty;

    public int? RegistroOrigemId { get; set; }

    public DateTime DataCadastro { get; set; } =
        DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    public DateTime DataHoraInicio
    {
        get
        {
            return Data.Date.Add(
                HoraInicio ?? TimeSpan.Zero);
        }
    }


    public string HorarioFormatado
    {
        get
        {
            if (DiaInteiro)
            {
                return "Dia inteiro";
            }

            if (!HoraInicio.HasValue)
            {
                return "Horário não informado";
            }

            if (!HoraFim.HasValue)
            {
                return HoraInicio.Value
                    .ToString(@"hh\:mm");
            }

            return
                $"{HoraInicio.Value:hh\\:mm} às {HoraFim.Value:hh\\:mm}";
        }
    }
}


public enum TipoCompromissoAgenda
{
    VisitaTecnica = 1,
    Capacitacao = 2,
    EducacaoAlimentar = 3,
    RevisaoPop = 4,
    Cardapio = 5,
    Reuniao = 6,
    Outro = 7
}


public enum StatusCompromissoAgenda
{
    Agendado = 1,
    Concluido = 2,
    Cancelado = 3
}