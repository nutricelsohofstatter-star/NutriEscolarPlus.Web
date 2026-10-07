namespace NutriEscolarPlus.Web.Data.Antropometria;

public static class DadosOms
{
    public const string ImcIdade = "IMC_IDADE";

    public const string EstaturaIdade = "ESTATURA_IDADE";

    public const string PesoIdade = "PESO_IDADE";

    public const string Masculino = "M";

    public const string Feminino = "F";

    public const string Oms2006 =
        "OMS 2006 - Padrões de Crescimento Infantil";

    public const string Oms2007 =
        "OMS 2007 - Referência de Crescimento";

    public static bool UsaOms2006(int idadeMeses)
    {
        return idadeMeses >= 0 &&
               idadeMeses <= 60;
    }

    public static bool UsaOms2007(int idadeMeses)
    {
        return idadeMeses >= 61 &&
               idadeMeses <= 228;
    }

    public static bool PermitePesoIdade(int idadeMeses)
    {
        return idadeMeses >= 0 &&
               idadeMeses <= 120;
    }

    public static string ObterReferencia(int idadeMeses)
    {
        if (UsaOms2006(idadeMeses))
        {
            return Oms2006;
        }

        if (UsaOms2007(idadeMeses))
        {
            return Oms2007;
        }

        return "Fora da faixa de referência OMS utilizada";
    }

    public static string ClassificarImcIdade5A19(double escoreZ)
    {
        if (escoreZ < -3)
        {
            return "Magreza acentuada";
        }

        if (escoreZ < -2)
        {
            return "Magreza";
        }

        if (escoreZ <= 1)
        {
            return "Eutrofia";
        }

        if (escoreZ <= 2)
        {
            return "Sobrepeso";
        }

        return "Obesidade";
    }
}