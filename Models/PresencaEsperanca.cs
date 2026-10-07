namespace NutriEscolarPlus.Web.Models;

public class PresencaEsperanca
{
    public int Id { get; set; }

    public int EncontroId { get; set; }

    public int AlunoId { get; set; }

    public SituacaoPresencaEsperanca Situacao { get; set; }
        = SituacaoPresencaEsperanca.NaoInformada;

    public string Observacao { get; set; } = string.Empty;

    public DateTime? DataRegistro { get; set; }
}


public enum SituacaoPresencaEsperanca
{
    NaoInformada = 0,
    Presente = 1,
    Falta = 2
}