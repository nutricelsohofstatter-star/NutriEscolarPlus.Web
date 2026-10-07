namespace NutriEscolarPlus.Web.Models;

public class GrupoEsperanca
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; } = 2;

    public string Nome { get; set; } = string.Empty;

    public DiaDaSemanaGrupoEsperanca DiaSemana { get; set; }

    public int NumeroGrupo { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public bool Ativo { get; set; } = true;

    public string Observacoes { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.Now;


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


public enum DiaDaSemanaGrupoEsperanca
{
    Quarta = 1,
    Sexta = 2
}