using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AntropometriaService
{
    public ResultadoAntropometrico Avaliar(
        Aluno aluno,
        DateTime dataAvaliacao,
        decimal pesoKg,
        decimal alturaCm)
    {
        var resultado = new ResultadoAntropometrico();

        // =========================================================
        // VALIDAÇÕES
        // =========================================================

        if (aluno is null)
        {
            resultado.Mensagem =
                "Aluno não informado.";

            return resultado;
        }

        if (!aluno.DataNascimento.HasValue)
        {
            resultado.Mensagem =
                "O aluno não possui data de nascimento cadastrada.";

            return resultado;
        }

        if (string.IsNullOrWhiteSpace(aluno.Sexo))
        {
            resultado.Mensagem =
                "O aluno não possui sexo cadastrado.";

            return resultado;
        }

        if (!SexoValido(aluno.Sexo))
        {
            resultado.Mensagem =
                "O sexo cadastrado para o aluno não é válido para a referência antropométrica.";

            return resultado;
        }

        if (dataAvaliacao.Date >
            DateTime.Today)
        {
            resultado.Mensagem =
                "A data da avaliação não pode ser futura.";

            return resultado;
        }

        if (dataAvaliacao.Date <
            aluno.DataNascimento.Value.Date)
        {
            resultado.Mensagem =
                "A data da avaliação é anterior à data de nascimento do aluno.";

            return resultado;
        }

        if (pesoKg <= 0)
        {
            resultado.Mensagem =
                "O peso deve ser maior que zero.";

            return resultado;
        }

        if (alturaCm <= 0)
        {
            resultado.Mensagem =
                "A altura deve ser maior que zero.";

            return resultado;
        }

        // =========================================================
        // IDADE
        // =========================================================

        var idadeMeses =
            CalcularIdadeMeses(
                aluno.DataNascimento.Value,
                dataAvaliacao);

        resultado.IdadeMeses =
            idadeMeses;

        resultado.PesoKg =
            pesoKg;

        resultado.AlturaCm =
            alturaCm;

        // =========================================================
        // IMC
        // =========================================================

        var alturaMetros =
            alturaCm / 100m;

        resultado.Imc =
            Math.Round(
                pesoKg /
                (alturaMetros * alturaMetros),
                2);

        // =========================================================
        // REFERÊNCIA OMS
        // =========================================================

        if (idadeMeses <= 60)
        {
            resultado.Referencia =
                "OMS 2006 - Padrões de Crescimento Infantil (0 a 60 meses)";
        }
        else if (idadeMeses <= 228)
        {
            resultado.Referencia =
                "OMS 2007 - Referência de Crescimento (61 a 228 meses)";
        }
        else
        {
            resultado.EstadoNutricional =
                "Não classificado";

            resultado.ClassificacaoImcIdade =
                "Não aplicável";

            resultado.ClassificacaoEstaturaIdade =
                "Não aplicável";

            resultado.ClassificacaoPesoIdade =
                "Não aplicável";

            resultado.CalculoConcluido =
                false;

            resultado.Mensagem =
                "A idade está acima de 228 meses e não pertence à referência pediátrica OMS utilizada pelo sistema.";

            return resultado;
        }

        // =========================================================
        // RESULTADO TEMPORÁRIO
        //
        // IMPORTANTE:
        // O IMC já é matematicamente calculado.
        //
        // Entretanto, o estado nutricional pediátrico NÃO pode ser
        // definido utilizando os pontos de corte de IMC de adultos.
        //
        // Precisamos comparar o IMC com sexo + idade utilizando
        // os parâmetros oficiais da OMS.
        // =========================================================

        resultado.EscoreZImcIdade =
            null;

        resultado.EscoreZEstaturaIdade =
            null;

        resultado.EscoreZPesoIdade =
            null;

        resultado.ClassificacaoImcIdade =
            "Aguardando cálculo do escore-Z OMS";

        resultado.ClassificacaoEstaturaIdade =
            "Aguardando cálculo do escore-Z OMS";

        if (idadeMeses <= 120)
        {
            resultado.ClassificacaoPesoIdade =
                "Aguardando cálculo do escore-Z OMS";
        }
        else
        {
            resultado.ClassificacaoPesoIdade =
                "Indicador não utilizado após 120 meses";
        }

        resultado.EstadoNutricional =
            "Aguardando classificação OMS";

        resultado.CalculoConcluido =
            false;

        resultado.Mensagem =
            "Peso, altura e IMC calculados. A classificação nutricional será determinada pelos escores-Z oficiais da OMS.";

        return resultado;
    }

    // =============================================================
    // IDADE EM MESES COMPLETOS
    // =============================================================

    public int CalcularIdadeMeses(
        DateTime nascimento,
        DateTime referencia)
    {
        nascimento =
            nascimento.Date;

        referencia =
            referencia.Date;

        var meses =
            (referencia.Year -
             nascimento.Year) * 12
            +
            referencia.Month -
            nascimento.Month;

        if (referencia.Day <
            nascimento.Day)
        {
            meses--;
        }

        return Math.Max(
            0,
            meses);
    }

    // =============================================================
    // IDADE EM DIAS
    // =============================================================

    public int CalcularIdadeDias(
        DateTime nascimento,
        DateTime referencia)
    {
        nascimento =
            nascimento.Date;

        referencia =
            referencia.Date;

        if (referencia < nascimento)
        {
            return 0;
        }

        return
            (referencia - nascimento).Days;
    }

    // =============================================================
    // SEXO
    // =============================================================

    public string NormalizarSexo(
        string sexo)
    {
        if (string.IsNullOrWhiteSpace(sexo))
        {
            return string.Empty;
        }

        var valor =
            sexo.Trim()
                .ToUpperInvariant();

        if (valor == "M" ||
            valor == "MASCULINO" ||
            valor == "MENINO")
        {
            return "M";
        }

        if (valor == "F" ||
            valor == "FEMININO" ||
            valor == "MENINA")
        {
            return "F";
        }

        return string.Empty;
    }

    public bool SexoValido(
        string sexo)
    {
        return
            !string.IsNullOrWhiteSpace(
                NormalizarSexo(sexo));
    }
}