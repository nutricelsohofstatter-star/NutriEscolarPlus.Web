using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AvaliacaoNutricionalEsperancaService
{
    private readonly List<AvaliacaoNutricionalEsperanca> _avaliacoes =
        new();

    private int _proximoId = 1;


    // =========================================================
    // LISTAGEM
    // =========================================================

    public List<AvaliacaoNutricionalEsperanca> ObterTodas(
        int instituicaoId = 2)
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


    public List<AvaliacaoNutricionalEsperanca> ObterPorAluno(
        int alunoId)
    {
        return _avaliacoes
            .Where(a =>
                a.AlunoId == alunoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ToList();
    }


    public List<AvaliacaoNutricionalEsperanca> ObterPorGrupo(
        int grupoId)
    {
        return _avaliacoes
            .Where(a =>
                a.GrupoId == grupoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ThenBy(a =>
                a.AlunoNome)
            .ToList();
    }


    public AvaliacaoNutricionalEsperanca? ObterPorId(
        int id)
    {
        return _avaliacoes
            .FirstOrDefault(a =>
                a.Id == id);
    }


    public AvaliacaoNutricionalEsperanca? ObterUltimaPorAluno(
        int alunoId)
    {
        return _avaliacoes
            .Where(a =>
                a.AlunoId == alunoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ThenByDescending(a =>
                a.Id)
            .FirstOrDefault();
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int Contar(
        int instituicaoId = 2)
    {
        return _avaliacoes.Count(a =>
            a.InstituicaoId == instituicaoId);
    }


    public int ContarAlunosAvaliados(
        int instituicaoId = 2)
    {
        return _avaliacoes
            .Where(a =>
                a.InstituicaoId == instituicaoId)
            .Select(a =>
                a.AlunoId)
            .Distinct()
            .Count();
    }


    public bool AlunoPossuiAvaliacao(
        int alunoId)
    {
        return _avaliacoes.Any(a =>
            a.AlunoId == alunoId);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public AvaliacaoNutricionalEsperanca Adicionar(
        AvaliacaoNutricionalEsperanca avaliacao)
    {
        avaliacao.Id =
            _proximoId++;

        avaliacao.InstituicaoId =
            avaliacao.InstituicaoId <= 0
                ? 2
                : avaliacao.InstituicaoId;

        avaliacao.Imc =
            avaliacao.CalcularImc();

        avaliacao.DataCadastro =
            DateTime.Now;

        _avaliacoes.Add(
            avaliacao
        );

        return avaliacao;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        AvaliacaoNutricionalEsperanca avaliacao)
    {
        var existente =
            ObterPorId(
                avaliacao.Id
            );

        if (existente is null)
            return false;


        existente.AlunoId =
            avaliacao.AlunoId;

        existente.AlunoNome =
            avaliacao.AlunoNome;

        existente.GrupoId =
            avaliacao.GrupoId;

        existente.GrupoNome =
            avaliacao.GrupoNome;

        existente.DataAvaliacao =
            avaliacao.DataAvaliacao;

        existente.PesoKg =
            avaliacao.PesoKg;

        existente.AlturaCm =
            avaliacao.AlturaCm;

        existente.Classificacao =
            avaliacao.Classificacao;

        existente.Observacoes =
            avaliacao.Observacoes;

        existente.Imc =
            avaliacao.CalcularImc();

        existente.DataAtualizacao =
            DateTime.Now;


        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var avaliacao =
            ObterPorId(
                id
            );

        if (avaliacao is null)
            return false;


        _avaliacoes.Remove(
            avaliacao
        );

        return true;
    }


    // =========================================================
    // HISTÓRICO
    // =========================================================

    public List<AvaliacaoNutricionalEsperanca> ObterHistoricoAluno(
        int alunoId)
    {
        return _avaliacoes
            .Where(a =>
                a.AlunoId == alunoId)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ThenByDescending(a =>
                a.Id)
            .ToList();
    }


    public List<AvaliacaoNutricionalEsperanca> ObterNoPeriodo(
        DateTime inicio,
        DateTime fim,
        int instituicaoId = 2)
    {
        inicio =
            inicio.Date;

        fim =
            fim.Date;


        return _avaliacoes
            .Where(a =>
                a.InstituicaoId == instituicaoId &&
                a.DataAvaliacao.Date >= inicio &&
                a.DataAvaliacao.Date <= fim)
            .OrderByDescending(a =>
                a.DataAvaliacao)
            .ThenBy(a =>
                a.AlunoNome)
            .ToList();
    }
}