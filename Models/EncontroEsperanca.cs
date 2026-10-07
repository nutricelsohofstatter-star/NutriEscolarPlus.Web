namespace NutriEscolarPlus.Web.Models;

public class EncontroEsperanca
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; } = 2;

    public int GrupoId { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public StatusEncontroEsperanca Status { get; set; }
        = StatusEncontroEsperanca.Agendado;

    public string Tema { get; set; } = string.Empty;

    public string Observacoes { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    public string HorarioFormatado
    {
        get
        {
            if (!HoraInicio.HasValue)
                return "Horário não definido";

            if (!HoraFim.HasValue)
                return HoraInicio.Value.ToString(@"hh\:mm");

            return
                $"{HoraInicio.Value:hh\\:mm} às {HoraFim.Value:hh\\:mm}";
        }
    }
}


public enum StatusEncontroEsperanca
{
    Agendado = 1,
    Realizado = 2,
    Cancelado = 3
}