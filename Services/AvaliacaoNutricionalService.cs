using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AvaliacaoNutricionalService
{
    private readonly List<AvaliacaoNutricional> _avaliacoes = new();

    private int _proximoId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public AvaliacaoNutricionalService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_avaliacoes.Any())
        {
            return;
        }


        // =====================================================
        // ALICE MARTINS
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 1,
            AlunoNome = "Alice Martins",
            DataAvaliacao = new DateTime(2026, 10, 1),

            PesoKg = 17.80m,
            AlturaCm = 106.00m,

            EscoreZImcIdade = 0.20m,
            Classificacao = "Eutrofia",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Crescimento e desenvolvimento compatíveis com a faixa etária. Manter acompanhamento nutricional periódico."
        });


        // =====================================================
        // BERNARDO OLIVEIRA
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 2,
            AlunoNome = "Bernardo Oliveira",
            DataAvaliacao = new DateTime(2026, 10, 2),

            PesoKg = 20.40m,
            AlturaCm = 113.00m,

            EscoreZImcIdade = 0.55m,
            Classificacao = "Eutrofia",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Estado nutricional adequado. Aluno com intolerância à lactose registrada. Manter atenção às substituições alimentares oferecidas pela instituição."
        });


        // =====================================================
        // CLARA FERREIRA
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 3,
            AlunoNome = "Clara Ferreira",
            DataAvaliacao = new DateTime(2026, 10, 5),

            PesoKg = 22.10m,
            AlturaCm = 119.00m,

            EscoreZImcIdade = 0.10m,
            Classificacao = "Eutrofia",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Avaliação antropométrica sem alterações relevantes. Recomendada manutenção da alimentação variada e acompanhamento do crescimento."
        });


        // =====================================================
        // DAVI RODRIGUES
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 4,
            AlunoNome = "Davi Rodrigues",
            DataAvaliacao = new DateTime(2026, 10, 5),

            PesoKg = 16.20m,
            AlturaCm = 103.00m,

            EscoreZImcIdade = -0.35m,
            Classificacao = "Eutrofia",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Estado nutricional adequado. Possui APLV registrada, sendo necessário manter controle rigoroso dos alimentos e preparações oferecidos."
        });


        // =====================================================
        // ELISA COSTA
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 5,
            AlunoNome = "Elisa Costa",
            DataAvaliacao = new DateTime(2026, 10, 6),

            PesoKg = 24.90m,
            AlturaCm = 115.00m,

            EscoreZImcIdade = 1.35m,
            Classificacao = "Risco de sobrepeso",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Identificado risco de sobrepeso. Recomenda-se acompanhamento da evolução antropométrica e incentivo à alimentação equilibrada e atividades adequadas à faixa etária."
        });


        // =====================================================
        // GABRIEL ALMEIDA
        // =====================================================

        Adicionar(new AvaliacaoNutricional
        {
            InstituicaoId = 1,
            AlunoId = 6,
            AlunoNome = "Gabriel Almeida",
            DataAvaliacao = new DateTime(2026, 10, 6),

            PesoKg = 21.30m,
            AlturaCm = 118.00m,

            EscoreZImcIdade = -0.10m,
            Classificacao = "Eutrofia",
            IndicadorClassificacao = "IMC para idade",
            ReferenciaClassificacao = "OMS",

            Observacoes =
                "Estado nutricional adequado. Alergia a ovo registrada. Manter identificação das preparações e substituições seguras no ambiente escolar."
        });
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<AvaliacaoNutricional> ObterTodas()
    {
        return _avaliacoes
            .OrderByDescending(a => a.DataAvaliacao)
            .ThenBy(a => a.AlunoNome)
            .ToList();
    }


    public List<AvaliacaoNutricional> ObterPorInstituicao(
        int instituicaoId)
    {
        return _avaliacoes
            .Where(a =>
                a.InstituicaoId == instituicaoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ThenBy(a =>
                a.AlunoNome)
            .ToList();
    }


    public List<AvaliacaoNutricional> ObterPorAluno(
        int alunoId)
    {
        return _avaliacoes
            .Where(a =>
                a.AlunoId == alunoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ToList();
    }


    public AvaliacaoNutricional? ObterPorId(
        int id)
    {
        return _avaliacoes
            .FirstOrDefault(a =>
                a.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public AvaliacaoNutricional Adicionar(
        AvaliacaoNutricional avaliacao)
    {
        avaliacao.Id =
            _proximoId++;

        avaliacao.DataCadastro =
            DateTime.Now;

        avaliacao.AlunoNome =
            avaliacao.AlunoNome.Trim();

        avaliacao.Classificacao =
            avaliacao.Classificacao.Trim();

        avaliacao.IndicadorClassificacao =
            avaliacao.IndicadorClassificacao.Trim();

        avaliacao.ReferenciaClassificacao =
            avaliacao.ReferenciaClassificacao.Trim();

        avaliacao.Observacoes =
            avaliacao.Observacoes.Trim();

        _avaliacoes.Add(avaliacao);

        return avaliacao;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public AvaliacaoNutricional? Atualizar(
        AvaliacaoNutricional avaliacao)
    {
        var existente =
            ObterPorId(avaliacao.Id);

        if (existente is null)
        {
            return null;
        }


        existente.InstituicaoId =
            avaliacao.InstituicaoId;

        existente.AlunoId =
            avaliacao.AlunoId;

        existente.AlunoNome =
            avaliacao.AlunoNome.Trim();

        existente.DataAvaliacao =
            avaliacao.DataAvaliacao;

        existente.PesoKg =
            avaliacao.PesoKg;

        existente.AlturaCm =
            avaliacao.AlturaCm;

        existente.EscoreZImcIdade =
            avaliacao.EscoreZImcIdade;

        existente.Classificacao =
            avaliacao.Classificacao.Trim();

        existente.IndicadorClassificacao =
            avaliacao.IndicadorClassificacao.Trim();

        existente.ReferenciaClassificacao =
            avaliacao.ReferenciaClassificacao.Trim();

        existente.Observacoes =
            avaliacao.Observacoes.Trim();

        existente.DataAtualizacao =
            DateTime.Now;


        return existente;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(int id)
    {
        var avaliacao =
            ObterPorId(id);

        if (avaliacao is null)
        {
            return false;
        }

        _avaliacoes.Remove(avaliacao);

        return true;
    }


    // =========================================================
    // INDICADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _avaliacoes.Count(a =>
            a.InstituicaoId == instituicaoId);
    }


    public int ContarAlunosAvaliados(
        int instituicaoId)
    {
        return _avaliacoes
            .Where(a =>
                a.InstituicaoId == instituicaoId)
            .Select(a =>
                a.AlunoId)
            .Distinct()
            .Count();
    }


    // =========================================================
    // ÚLTIMA AVALIAÇÃO DO ALUNO
    // =========================================================

    public AvaliacaoNutricional? ObterUltimaAvaliacaoAluno(
        int alunoId)
    {
        return _avaliacoes
            .Where(a =>
                a.AlunoId == alunoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .FirstOrDefault();
    }
}