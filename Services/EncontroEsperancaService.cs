using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class EncontroEsperancaService
{
    private readonly List<EncontroEsperanca> _encontros =
        new();

    private readonly List<PresencaEsperanca> _presencas =
        new();

    private readonly List<EvolucaoGeralEsperanca> _evolucoes =
        new();


    private int _proximoEncontroId = 1;

    private int _proximaPresencaId = 1;

    private int _proximaEvolucaoId = 1;


    public EncontroEsperancaService()
    {
        CriarEncontrosIniciais();
    }


    // =========================================================
    // ENCONTROS
    // =========================================================

    public List<EncontroEsperanca> ObterTodos(
        int instituicaoId = 2)
    {
        return _encontros
            .Where(e =>
                e.InstituicaoId == instituicaoId)
            .OrderByDescending(e => e.Data)
            .ThenBy(e => e.HoraInicio)
            .ToList();
    }


    public List<EncontroEsperanca> ObterDoDia(
        DateTime data,
        int instituicaoId = 2)
    {
        return _encontros
            .Where(e =>
                e.InstituicaoId == instituicaoId &&
                e.Data.Date == data.Date)
            .OrderBy(e => e.HoraInicio)
            .ToList();
    }


    public List<EncontroEsperanca> ObterDoMes(
        int ano,
        int mes,
        int instituicaoId = 2)
    {
        return _encontros
            .Where(e =>
                e.InstituicaoId == instituicaoId &&
                e.Data.Year == ano &&
                e.Data.Month == mes)
            .OrderBy(e => e.Data)
            .ThenBy(e => e.HoraInicio)
            .ToList();
    }


    public List<EncontroEsperanca> ObterPorGrupo(
        int grupoId)
    {
        return _encontros
            .Where(e =>
                e.GrupoId == grupoId)
            .OrderByDescending(e => e.Data)
            .ThenByDescending(e => e.HoraInicio)
            .ToList();
    }


    public EncontroEsperanca? ObterPorId(
        int id)
    {
        return _encontros
            .FirstOrDefault(e =>
                e.Id == id);
    }


    public List<EncontroEsperanca> ObterProximos(
        int quantidade = 5,
        int instituicaoId = 2)
    {
        return _encontros
            .Where(e =>
                e.InstituicaoId == instituicaoId &&
                e.Data.Date >= DateTime.Today &&
                e.Status ==
                    StatusEncontroEsperanca.Agendado)
            .OrderBy(e => e.Data)
            .ThenBy(e => e.HoraInicio)
            .Take(quantidade)
            .ToList();
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarHoje(
        int instituicaoId = 2)
    {
        return _encontros.Count(e =>
            e.InstituicaoId == instituicaoId &&
            e.Data.Date == DateTime.Today);
    }


    public int ContarNoMes(
        DateTime referencia,
        int instituicaoId = 2)
    {
        return _encontros.Count(e =>
            e.InstituicaoId == instituicaoId &&
            e.Data.Year == referencia.Year &&
            e.Data.Month == referencia.Month);
    }


    public int ContarAgendados(
        int instituicaoId = 2)
    {
        return _encontros.Count(e =>
            e.InstituicaoId == instituicaoId &&
            e.Status ==
                StatusEncontroEsperanca.Agendado);
    }


    public int ContarRealizadosNoMes(
        DateTime referencia,
        int instituicaoId = 2)
    {
        return _encontros.Count(e =>
            e.InstituicaoId == instituicaoId &&
            e.Data.Year == referencia.Year &&
            e.Data.Month == referencia.Month &&
            e.Status ==
                StatusEncontroEsperanca.Realizado);
    }


    // =========================================================
    // ADICIONAR ENCONTRO
    // =========================================================

    public EncontroEsperanca Adicionar(
        EncontroEsperanca encontro)
    {
        encontro.Id =
            _proximoEncontroId++;

        encontro.DataCadastro =
            DateTime.Now;

        _encontros.Add(encontro);

        return encontro;
    }


    // =========================================================
    // ATUALIZAR ENCONTRO
    // =========================================================

    public bool Atualizar(
        EncontroEsperanca encontro)
    {
        var existente =
            ObterPorId(encontro.Id);

        if (existente is null)
            return false;

        existente.GrupoId =
            encontro.GrupoId;

        existente.Data =
            encontro.Data;

        existente.HoraInicio =
            encontro.HoraInicio;

        existente.HoraFim =
            encontro.HoraFim;

        existente.Status =
            encontro.Status;

        existente.Tema =
            encontro.Tema;

        existente.Observacoes =
            encontro.Observacoes;

        existente.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    // =========================================================
    // STATUS
    // =========================================================

    public bool MarcarRealizado(
        int encontroId)
    {
        var encontro =
            ObterPorId(encontroId);

        if (encontro is null)
            return false;

        encontro.Status =
            StatusEncontroEsperanca.Realizado;

        encontro.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    public bool MarcarCancelado(
        int encontroId)
    {
        var encontro =
            ObterPorId(encontroId);

        if (encontro is null)
            return false;

        encontro.Status =
            StatusEncontroEsperanca.Cancelado;

        encontro.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    public bool MarcarAgendado(
        int encontroId)
    {
        var encontro =
            ObterPorId(encontroId);

        if (encontro is null)
            return false;

        encontro.Status =
            StatusEncontroEsperanca.Agendado;

        encontro.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int encontroId)
    {
        var encontro =
            ObterPorId(encontroId);

        if (encontro is null)
            return false;

        _presencas.RemoveAll(p =>
            p.EncontroId == encontroId);

        _evolucoes.RemoveAll(e =>
            e.EncontroId == encontroId);

        _encontros.Remove(encontro);

        return true;
    }


    // =========================================================
    // PRESENÇAS
    // =========================================================

    public List<PresencaEsperanca> ObterPresencas(
        int encontroId)
    {
        return _presencas
            .Where(p =>
                p.EncontroId == encontroId)
            .ToList();
    }


    public PresencaEsperanca? ObterPresenca(
        int encontroId,
        int alunoId)
    {
        return _presencas
            .FirstOrDefault(p =>
                p.EncontroId == encontroId &&
                p.AlunoId == alunoId);
    }


    public PresencaEsperanca RegistrarPresenca(
        int encontroId,
        int alunoId,
        SituacaoPresencaEsperanca situacao,
        string observacao = "")
    {
        var registro =
            ObterPresenca(
                encontroId,
                alunoId);


        if (registro is null)
        {
            registro =
                new PresencaEsperanca
                {
                    Id =
                        _proximaPresencaId++,

                    EncontroId =
                        encontroId,

                    AlunoId =
                        alunoId
                };

            _presencas.Add(registro);
        }


        registro.Situacao =
            situacao;

        registro.Observacao =
            observacao;

        registro.DataRegistro =
            DateTime.Now;


        return registro;
    }


    public List<PresencaEsperanca> ObterHistoricoAluno(
        int alunoId)
    {
        return _presencas
            .Where(p =>
                p.AlunoId == alunoId)
            .OrderByDescending(p =>
                ObterPorId(p.EncontroId)?.Data ??
                DateTime.MinValue)
            .ToList();
    }


    public int ContarPresentes(
        int encontroId)
    {
        return _presencas.Count(p =>
            p.EncontroId == encontroId &&
            p.Situacao ==
                SituacaoPresencaEsperanca.Presente);
    }


    public int ContarFaltas(
        int encontroId)
    {
        return _presencas.Count(p =>
            p.EncontroId == encontroId &&
            p.Situacao ==
                SituacaoPresencaEsperanca.Falta);
    }


    // =========================================================
    // EVOLUÇÃO GERAL
    // =========================================================

    public EvolucaoGeralEsperanca? ObterEvolucao(
        int encontroId)
    {
        return _evolucoes
            .FirstOrDefault(e =>
                e.EncontroId == encontroId);
    }


    public EvolucaoGeralEsperanca SalvarEvolucao(
        int encontroId,
        int grupoId,
        DateTime data,
        string evolucao,
        string profissional = "")
    {
        var registro =
            ObterEvolucao(encontroId);


        if (registro is null)
        {
            registro =
                new EvolucaoGeralEsperanca
                {
                    Id =
                        _proximaEvolucaoId++,

                    EncontroId =
                        encontroId,

                    GrupoId =
                        grupoId,

                    Data =
                        data,

                    DataRegistro =
                        DateTime.Now
                };

            _evolucoes.Add(registro);
        }
        else
        {
            registro.DataAtualizacao =
                DateTime.Now;
        }


        registro.Evolucao =
            evolucao.Trim();

        registro.Profissional =
            profissional.Trim();


        return registro;
    }


    public List<EvolucaoGeralEsperanca> ObterEvolucoesGrupo(
        int grupoId)
    {
        return _evolucoes
            .Where(e =>
                e.GrupoId == grupoId)
            .OrderByDescending(e =>
                e.Data)
            .ToList();
    }


    public bool PossuiEvolucao(
        int encontroId)
    {
        return _evolucoes.Any(e =>
            e.EncontroId == encontroId);
    }


    // =========================================================
    // DADOS INICIAIS
    // =========================================================

    private void CriarEncontrosIniciais()
    {
        var hoje =
            DateTime.Today;


        var proximaQuarta =
            ProximoDiaDaSemana(
                hoje,
                DayOfWeek.Wednesday);


        var proximaSexta =
            ProximoDiaDaSemana(
                hoje,
                DayOfWeek.Friday);


        Adicionar(
            new EncontroEsperanca
            {
                GrupoId = 1,
                Data = proximaQuarta,
                HoraInicio =
                    new TimeSpan(13, 30, 0),
                HoraFim =
                    new TimeSpan(14, 30, 0),
                Status =
                    StatusEncontroEsperanca.Agendado
            });


        Adicionar(
            new EncontroEsperanca
            {
                GrupoId = 2,
                Data = proximaQuarta,
                HoraInicio =
                    new TimeSpan(15, 0, 0),
                HoraFim =
                    new TimeSpan(16, 0, 0),
                Status =
                    StatusEncontroEsperanca.Agendado
            });


        Adicionar(
            new EncontroEsperanca
            {
                GrupoId = 3,
                Data = proximaSexta,
                HoraInicio =
                    new TimeSpan(13, 30, 0),
                HoraFim =
                    new TimeSpan(14, 30, 0),
                Status =
                    StatusEncontroEsperanca.Agendado
            });


        Adicionar(
            new EncontroEsperanca
            {
                GrupoId = 4,
                Data = proximaSexta,
                HoraInicio =
                    new TimeSpan(15, 0, 0),
                HoraFim =
                    new TimeSpan(16, 0, 0),
                Status =
                    StatusEncontroEsperanca.Agendado
            });
    }


    // =========================================================
    // AUXILIAR
    // =========================================================

    private static DateTime ProximoDiaDaSemana(
        DateTime inicio,
        DayOfWeek diaDesejado)
    {
        var diferenca =
            ((int)diaDesejado -
             (int)inicio.DayOfWeek +
             7) % 7;

        return inicio.AddDays(diferenca);
    }
}