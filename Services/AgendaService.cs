using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AgendaService
{
    private readonly List<CompromissoAgenda> _compromissos =
        new();

    private int _proximoId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public AgendaService()
    {
        CriarDadosIniciais();
    }


    // =========================================================
    // LISTAGEM
    // =========================================================

    public List<CompromissoAgenda> ObterTodos()
    {
        return _compromissos
            .OrderBy(c => c.Data)
            .ThenBy(c => c.HoraInicio)
            .ToList();
    }


    public List<CompromissoAgenda> ObterPorInstituicao(
        int instituicaoId)
    {
        return _compromissos
            .Where(c =>
                c.InstituicaoId == instituicaoId)
            .OrderBy(c => c.Data)
            .ThenBy(c => c.HoraInicio)
            .ToList();
    }


    public CompromissoAgenda? ObterPorId(
        int id)
    {
        return _compromissos
            .FirstOrDefault(c =>
                c.Id == id);
    }


    // =========================================================
    // PERÍODO
    // =========================================================

    public List<CompromissoAgenda> ObterPorPeriodo(
        int instituicaoId,
        DateTime inicio,
        DateTime fim)
    {
        return _compromissos
            .Where(c =>
                c.InstituicaoId == instituicaoId &&
                c.Data.Date >= inicio.Date &&
                c.Data.Date <= fim.Date)
            .OrderBy(c => c.Data)
            .ThenBy(c => c.HoraInicio)
            .ToList();
    }


    public List<CompromissoAgenda> ObterDoMes(
        int instituicaoId,
        int ano,
        int mes)
    {
        return _compromissos
            .Where(c =>
                c.InstituicaoId == instituicaoId &&
                c.Data.Year == ano &&
                c.Data.Month == mes)
            .OrderBy(c => c.Data)
            .ThenBy(c => c.HoraInicio)
            .ToList();
    }


    public List<CompromissoAgenda> ObterDoDia(
        int instituicaoId,
        DateTime data)
    {
        return _compromissos
            .Where(c =>
                c.InstituicaoId == instituicaoId &&
                c.Data.Date == data.Date)
            .OrderBy(c => c.HoraInicio)
            .ToList();
    }


    // =========================================================
    // PRÓXIMOS
    // =========================================================

    public List<CompromissoAgenda> ObterProximos(
        int instituicaoId,
        int quantidade = 5)
    {
        var hoje =
            DateTime.Today;

        return _compromissos
            .Where(c =>
                c.InstituicaoId == instituicaoId &&
                c.Data.Date >= hoje &&
                c.Status != StatusCompromissoAgenda.Cancelado)
            .OrderBy(c => c.Data)
            .ThenBy(c => c.HoraInicio)
            .Take(quantidade)
            .ToList();
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarHoje(
        int instituicaoId)
    {
        var hoje =
            DateTime.Today;

        return _compromissos.Count(c =>
            c.InstituicaoId == instituicaoId &&
            c.Data.Date == hoje &&
            c.Status != StatusCompromissoAgenda.Cancelado);
    }


    public int ContarNoMes(
        int instituicaoId,
        int ano,
        int mes)
    {
        return _compromissos.Count(c =>
            c.InstituicaoId == instituicaoId &&
            c.Data.Year == ano &&
            c.Data.Month == mes &&
            c.Status != StatusCompromissoAgenda.Cancelado);
    }


    public int ContarPendentes(
        int instituicaoId)
    {
        return _compromissos.Count(c =>
            c.InstituicaoId == instituicaoId &&
            c.Data.Date >= DateTime.Today &&
            c.Status == StatusCompromissoAgenda.Agendado);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public CompromissoAgenda Adicionar(
        CompromissoAgenda compromisso)
    {
        compromisso.Id =
            _proximoId++;

        compromisso.DataCadastro =
            DateTime.Now;

        compromisso.DataAtualizacao =
            null;

        compromisso.Titulo =
            compromisso.Titulo.Trim();

        compromisso.Descricao =
            compromisso.Descricao.Trim();

        compromisso.Local =
            compromisso.Local.Trim();

        compromisso.Responsavel =
            compromisso.Responsavel.Trim();

        compromisso.Observacoes =
            compromisso.Observacoes.Trim();

        compromisso.ModuloOrigem =
            compromisso.ModuloOrigem.Trim();

        _compromissos.Add(
            compromisso);

        return compromisso;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        CompromissoAgenda compromisso)
    {
        var existente =
            ObterPorId(compromisso.Id);

        if (existente is null)
        {
            return false;
        }


        existente.InstituicaoId =
            compromisso.InstituicaoId;

        existente.Titulo =
            compromisso.Titulo.Trim();

        existente.Descricao =
            compromisso.Descricao.Trim();

        existente.Data =
            compromisso.Data;

        existente.HoraInicio =
            compromisso.HoraInicio;

        existente.HoraFim =
            compromisso.HoraFim;

        existente.Tipo =
            compromisso.Tipo;

        existente.Status =
            compromisso.Status;

        existente.Local =
            compromisso.Local.Trim();

        existente.Responsavel =
            compromisso.Responsavel.Trim();

        existente.Observacoes =
            compromisso.Observacoes.Trim();

        existente.DiaInteiro =
            compromisso.DiaInteiro;

        existente.CriadoAutomaticamente =
            compromisso.CriadoAutomaticamente;

        existente.ModuloOrigem =
            compromisso.ModuloOrigem.Trim();

        existente.RegistroOrigemId =
            compromisso.RegistroOrigemId;

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
        var compromisso =
            ObterPorId(id);

        if (compromisso is null)
        {
            return false;
        }


        return _compromissos.Remove(
            compromisso);
    }


    // =========================================================
    // CONCLUIR
    // =========================================================

    public bool MarcarComoConcluido(
        int id)
    {
        var compromisso =
            ObterPorId(id);

        if (compromisso is null)
        {
            return false;
        }


        compromisso.Status =
            StatusCompromissoAgenda.Concluido;

        compromisso.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    // =========================================================
    // DADOS INICIAIS PARA DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosIniciais()
    {
        if (_compromissos.Any())
        {
            return;
        }


        // =====================================================
        // 01/10 - REVISÃO DO CARDÁPIO - CONCLUÍDO
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Revisão do cardápio mensal",

                Descricao =
                    "Conferência final do cardápio de outubro e revisão das preparações planejadas.",

                Data =
                    new DateTime(2026, 10, 1),

                HoraInicio =
                    new TimeSpan(10, 0, 0),

                HoraFim =
                    new TimeSpan(11, 0, 0),

                Tipo =
                    TipoCompromissoAgenda.Cardapio,

                Status =
                    StatusCompromissoAgenda.Concluido,

                Local =
                    "Atividade administrativa",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Cardápio revisado e disponibilizado para a instituição.",

                CriadoAutomaticamente =
                    false,

                ModuloOrigem =
                    "Cardápios"
            }
        );


        // =====================================================
        // 05/10 - VISITA TÉCNICA - CONCLUÍDA
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Visita técnica de acompanhamento",

                Descricao =
                    "Acompanhamento da execução do cardápio, armazenamento dos alimentos e cuidados relacionados às dietas especiais.",

                Data =
                    new DateTime(2026, 10, 5),

                HoraInicio =
                    new TimeSpan(14, 0, 0),

                HoraFim =
                    new TimeSpan(15, 30, 0),

                Tipo =
                    TipoCompromissoAgenda.VisitaTecnica,

                Status =
                    StatusCompromissoAgenda.Concluido,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Visita realizada. Registrada orientação para reforçar a identificação das dietas especiais.",

                CriadoAutomaticamente =
                    true,

                ModuloOrigem =
                    "Visitas Técnicas",

                RegistroOrigemId =
                    2
            }
        );


        // =====================================================
        // 06/10 - CAPACITAÇÃO - CONCLUÍDA
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Capacitação sobre dietas especiais",

                Descricao =
                    "Orientação da equipe sobre alergias alimentares, intolerâncias e prevenção de contato cruzado.",

                Data =
                    new DateTime(2026, 10, 6),

                HoraInicio =
                    new TimeSpan(13, 30, 0),

                HoraFim =
                    new TimeSpan(15, 0, 0),

                Tipo =
                    TipoCompromissoAgenda.Capacitacao,

                Status =
                    StatusCompromissoAgenda.Concluido,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Capacitação realizada com participação da equipe da cozinha e coordenação.",

                CriadoAutomaticamente =
                    true,

                ModuloOrigem =
                    "Capacitações",

                RegistroOrigemId =
                    2
            }
        );


        // =====================================================
        // 07/10 - AVALIAÇÕES NUTRICIONAIS
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Avaliações nutricionais",

                Descricao =
                    "Continuidade das avaliações antropométricas dos alunos da instituição.",

                Data =
                    new DateTime(2026, 10, 7),

                HoraInicio =
                    new TimeSpan(9, 0, 0),

                HoraFim =
                    new TimeSpan(11, 0, 0),

                Tipo =
                    TipoCompromissoAgenda.Outro,

                Status =
                    StatusCompromissoAgenda.Concluido,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Avaliações realizadas conforme programação."
            }
        );


        // =====================================================
        // 09/10 - REUNIÃO
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Reunião com a coordenação",

                Descricao =
                    "Alinhamento das ações nutricionais, dietas especiais e atividades previstas para o mês.",

                Data =
                    new DateTime(2026, 10, 9),

                HoraInicio =
                    new TimeSpan(15, 0, 0),

                HoraFim =
                    new TimeSpan(16, 0, 0),

                Tipo =
                    TipoCompromissoAgenda.Reuniao,

                Status =
                    StatusCompromissoAgenda.Agendado,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Revisar pendências e programação das próximas ações."
            }
        );


        // =====================================================
        // 14/10 - EDUCAÇÃO ALIMENTAR
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Educação Alimentar - Conhecendo as frutas",

                Descricao =
                    "Atividade lúdica com os alunos sobre variedade, cores e importância das frutas na alimentação.",

                Data =
                    new DateTime(2026, 10, 14),

                HoraInicio =
                    new TimeSpan(9, 0, 0),

                HoraFim =
                    new TimeSpan(10, 0, 0),

                Tipo =
                    TipoCompromissoAgenda.EducacaoAlimentar,

                Status =
                    StatusCompromissoAgenda.Agendado,

                Local =
                    "Sala de atividades",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Atividade planejada para turmas da educação infantil."
            }
        );


        // =====================================================
        // 19/10 - VISITA TÉCNICA DE RETORNO
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Visita técnica de retorno",

                Descricao =
                    "Acompanhamento das orientações e pendências registradas nas visitas anteriores.",

                Data =
                    new DateTime(2026, 10, 19),

                HoraInicio =
                    new TimeSpan(14, 0, 0),

                HoraFim =
                    new TimeSpan(15, 30, 0),

                Tipo =
                    TipoCompromissoAgenda.VisitaTecnica,

                Status =
                    StatusCompromissoAgenda.Agendado,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Verificar identificação das dietas especiais e registros de controle.",

                CriadoAutomaticamente =
                    true,

                ModuloOrigem =
                    "Visitas Técnicas",

                RegistroOrigemId =
                    3
            }
        );


        // =====================================================
        // 22/10 - REVISÃO DE POP
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Revisão dos POPs",

                Descricao =
                    "Revisão dos Procedimentos Operacionais Padronizados utilizados na unidade.",

                Data =
                    new DateTime(2026, 10, 22),

                Tipo =
                    TipoCompromissoAgenda.RevisaoPop,

                Status =
                    StatusCompromissoAgenda.Agendado,

                DiaInteiro =
                    true,

                Local =
                    "Atividade administrativa",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Revisar procedimentos de higienização, armazenamento e controle de equipamentos."
            }
        );


        // =====================================================
        // 26/10 - CAPACITAÇÃO
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Capacitação - Higienização e controle higiênico-sanitário",

                Descricao =
                    "Capacitação teórico-prática sobre higienização do ambiente, equipamentos, utensílios e alimentos.",

                Data =
                    new DateTime(2026, 10, 26),

                HoraInicio =
                    new TimeSpan(13, 30, 0),

                HoraFim =
                    new TimeSpan(15, 30, 0),

                Tipo =
                    TipoCompromissoAgenda.Capacitacao,

                Status =
                    StatusCompromissoAgenda.Agendado,

                Local =
                    "Escola Girassol",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Capacitação prevista como continuidade das ações de boas práticas.",

                CriadoAutomaticamente =
                    true,

                ModuloOrigem =
                    "Capacitações",

                RegistroOrigemId =
                    3
            }
        );


        // =====================================================
        // 29/10 - CARDÁPIO DE NOVEMBRO
        // =====================================================

        Adicionar(
            new CompromissoAgenda
            {
                InstituicaoId = 1,

                Titulo =
                    "Planejamento do cardápio de novembro",

                Descricao =
                    "Planejamento e revisão das refeições previstas para o próximo mês.",

                Data =
                    new DateTime(2026, 10, 29),

                HoraInicio =
                    new TimeSpan(10, 0, 0),

                HoraFim =
                    new TimeSpan(11, 30, 0),

                Tipo =
                    TipoCompromissoAgenda.Cardapio,

                Status =
                    StatusCompromissoAgenda.Agendado,

                Local =
                    "Atividade administrativa",

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Observacoes =
                    "Considerar sazonalidade dos alimentos e dietas especiais cadastradas."
            }
        );
    }
}