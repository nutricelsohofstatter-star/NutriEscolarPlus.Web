using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class GrupoEsperancaService
{
    private readonly List<GrupoEsperanca> _grupos = new();

    private int _proximoId = 1;


    public GrupoEsperancaService()
    {
        CriarGruposIniciais();
    }


    // =========================================================
    // LISTAGEM
    // =========================================================

    public List<GrupoEsperanca> ObterTodos(
        int instituicaoId = 2)
    {
        return _grupos
            .Where(g =>
                g.InstituicaoId == instituicaoId)
            .OrderBy(g => g.DiaSemana)
            .ThenBy(g => g.NumeroGrupo)
            .ToList();
    }


    public List<GrupoEsperanca> ObterAtivos(
        int instituicaoId = 2)
    {
        return _grupos
            .Where(g =>
                g.InstituicaoId == instituicaoId &&
                g.Ativo)
            .OrderBy(g => g.DiaSemana)
            .ThenBy(g => g.NumeroGrupo)
            .ToList();
    }


    public GrupoEsperanca? ObterPorId(
        int id)
    {
        return _grupos
            .FirstOrDefault(g =>
                g.Id == id);
    }


    public int ContarAtivos(
        int instituicaoId = 2)
    {
        return _grupos.Count(g =>
            g.InstituicaoId == instituicaoId &&
            g.Ativo);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public GrupoEsperanca Adicionar(
        GrupoEsperanca grupo)
    {
        grupo.Id =
            _proximoId++;

        grupo.DataCadastro =
            DateTime.Now;

        _grupos.Add(grupo);

        return grupo;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        GrupoEsperanca grupo)
    {
        var existente =
            ObterPorId(grupo.Id);

        if (existente is null)
            return false;

        existente.Nome =
            grupo.Nome;

        existente.DiaSemana =
            grupo.DiaSemana;

        existente.NumeroGrupo =
            grupo.NumeroGrupo;

        existente.HoraInicio =
            grupo.HoraInicio;

        existente.HoraFim =
            grupo.HoraFim;

        existente.Ativo =
            grupo.Ativo;

        existente.Observacoes =
            grupo.Observacoes;

        return true;
    }


    // =========================================================
    // DADOS INICIAIS
    // =========================================================

    private void CriarGruposIniciais()
    {
        Adicionar(
            new GrupoEsperanca
            {
                Nome = "Quarta 1",
                DiaSemana =
                    DiaDaSemanaGrupoEsperanca.Quarta,
                NumeroGrupo = 1
            });


        Adicionar(
            new GrupoEsperanca
            {
                Nome = "Quarta 2",
                DiaSemana =
                    DiaDaSemanaGrupoEsperanca.Quarta,
                NumeroGrupo = 2
            });


        Adicionar(
            new GrupoEsperanca
            {
                Nome = "Sexta 1",
                DiaSemana =
                    DiaDaSemanaGrupoEsperanca.Sexta,
                NumeroGrupo = 1
            });


        Adicionar(
            new GrupoEsperanca
            {
                Nome = "Sexta 2",
                DiaSemana =
                    DiaDaSemanaGrupoEsperanca.Sexta,
                NumeroGrupo = 2
            });
    }
}