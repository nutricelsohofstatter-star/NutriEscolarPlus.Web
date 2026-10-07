namespace NutriEscolarPlus.Web.Data.Antropometria;

public class ParametroOms
{
    public string Indicador { get; set; } = string.Empty;

    public string Sexo { get; set; } = string.Empty;

    public int IdadeMeses { get; set; }

    public double L { get; set; }

    public double M { get; set; }

    public double S { get; set; }

    public string Referencia { get; set; } = string.Empty;
}