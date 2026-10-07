namespace NutriEscolarPlus.Web.Data.Antropometria;

public static class CalculadoraLms
{
    /// <summary>
    /// Calcula o escore-Z utilizando os parâmetros LMS.
    ///
    /// L = Box-Cox power
    /// M = mediana
    /// S = coeficiente de variação
    /// </summary>
    public static double CalcularZ(
        double valor,
        double l,
        double m,
        double s)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(valor),
                "O valor antropométrico deve ser maior que zero.");
        }

        if (m <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(m),
                "O parâmetro M deve ser maior que zero.");
        }

        if (s <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(s),
                "O parâmetro S deve ser maior que zero.");
        }

        double z;

        if (Math.Abs(l) < 0.0000001)
        {
            z =
                Math.Log(valor / m) /
                s;
        }
        else
        {
            z =
                (Math.Pow(valor / m, l) - 1.0) /
                (l * s);
        }

        return Math.Round(
            z,
            2,
            MidpointRounding.AwayFromZero);
    }

    public static string ClassificarImcIdade5A19(
        double z)
    {
        if (z < -3.0)
        {
            return "Magreza acentuada";
        }

        if (z < -2.0)
        {
            return "Magreza";
        }

        if (z <= 1.0)
        {
            return "Eutrofia";
        }

        if (z <= 2.0)
        {
            return "Sobrepeso";
        }

        return "Obesidade";
    }

    public static string ClassificarImcIdade0A5(
        double z)
    {
        if (z < -3.0)
        {
            return "Magreza acentuada";
        }

        if (z < -2.0)
        {
            return "Magreza";
        }

        if (z <= 1.0)
        {
            return "Eutrofia";
        }

        if (z <= 2.0)
        {
            return "Risco de sobrepeso";
        }

        if (z <= 3.0)
        {
            return "Sobrepeso";
        }

        return "Obesidade";
    }

    public static string ClassificarEstaturaIdade(
        double z)
    {
        if (z < -3.0)
        {
            return "Muito baixa estatura para a idade";
        }

        if (z < -2.0)
        {
            return "Baixa estatura para a idade";
        }

        return "Estatura adequada para a idade";
    }

    public static string ClassificarPesoIdade(
        double z)
    {
        if (z < -3.0)
        {
            return "Muito baixo peso para a idade";
        }

        if (z < -2.0)
        {
            return "Baixo peso para a idade";
        }

        if (z <= 2.0)
        {
            return "Peso adequado para a idade";
        }

        return "Peso elevado para a idade";
    }

    public static string FormatarZ(
        double? z)
    {
        if (!z.HasValue)
        {
            return "-";
        }

        if (z.Value > 0)
        {
            return $"+{z.Value:0.00}";
        }

        return $"{z.Value:0.00}";
    }
}