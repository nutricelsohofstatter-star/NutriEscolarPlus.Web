using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class EducacaoAlimentarService
{
    private readonly List<EducacaoAlimentar> _acoes =
        new();

    private int _proximoId =
        1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public EducacaoAlimentarService()
    {
        CriarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosDemonstracao()
    {
        if (_acoes.Any())
        {
            return;
        }


        // =====================================================
        // 1 - DESCOBRINDO AS CORES DOS ALIMENTOS
        // REALIZADA
        // =====================================================

        Adicionar(
            new EducacaoAlimentar
            {
                InstituicaoId =
                    1,

                Tema =
                    "Descobrindo as cores dos alimentos",

                DataAcao =
                    new DateTime(2026, 9, 16),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Situacao =
                    StatusEducacaoAlimentar.Realizada,

                PublicoAlvo =
                    "Alunos da Educação Infantil",

                Turma =
                    "Maternal II e Maternal III",

                FaixaEtaria =
                    "4 a 5 anos",

                NumeroParticipantes =
                    24,

                Objetivo =
                    "Estimular o reconhecimento de diferentes alimentos e incentivar o contato das crianças com frutas, verduras e legumes de diferentes cores.",

                ConteudoTrabalhado =
                    "Variedade alimentar, cores dos alimentos, identificação de frutas, verduras e legumes e importância de experimentar novos alimentos.",

                Metodologia =
                    "Atividade lúdica com apresentação dos alimentos, conversa em roda e dinâmica de associação entre alimentos e suas respectivas cores.",

                MateriaisUtilizados =
                    "Cartazes coloridos, imagens de alimentos, frutas e legumes utilizados para demonstração.",

                DuracaoMinutos =
                    45,

                ParticipacaoPublico =
                    "As crianças participaram ativamente da atividade, identificando cores e relatando alimentos que já conheciam.",

                ResultadosObservados =
                    "Boa interação do grupo e curiosidade em conhecer diferentes alimentos. Algumas crianças demonstraram interesse em experimentar alimentos que anteriormente relatavam não consumir.",

                Observacoes =
                    "Atividade realizada conforme planejamento, com boa participação das turmas."
            }
        );


        // =====================================================
        // 2 - MONTANDO UM PRATO COLORIDO
        // REALIZADA
        // =====================================================

        Adicionar(
            new EducacaoAlimentar
            {
                InstituicaoId =
                    1,

                Tema =
                    "Montando um prato colorido",

                DataAcao =
                    new DateTime(2026, 9, 30),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Situacao =
                    StatusEducacaoAlimentar.Realizada,

                PublicoAlvo =
                    "Alunos da Educação Infantil",

                Turma =
                    "Pré I e Pré II",

                FaixaEtaria =
                    "5 a 6 anos",

                NumeroParticipantes =
                    27,

                Objetivo =
                    "Trabalhar de forma lúdica a importância da variedade alimentar e incentivar a presença de diferentes grupos de alimentos nas refeições.",

                ConteudoTrabalhado =
                    "Variedade alimentar, frutas, verduras, legumes, cereais, feijões e alimentos presentes nas refeições da escola.",

                Metodologia =
                    "Cada criança recebeu um prato ilustrado e imagens de diferentes alimentos para montar sua própria refeição. Após a montagem, foi realizada uma conversa sobre as escolhas feitas pelo grupo.",

                MateriaisUtilizados =
                    "Pratos ilustrados, figuras plastificadas de alimentos, cartazes e material educativo.",

                DuracaoMinutos =
                    50,

                ParticipacaoPublico =
                    "Participação muito boa. As crianças demonstraram interesse na montagem dos pratos e compartilharam experiências relacionadas às refeições realizadas em casa e na escola.",

                ResultadosObservados =
                    "Os alunos conseguiram reconhecer diferentes grupos de alimentos e compreenderam a proposta de variar as escolhas durante as refeições.",

                Observacoes =
                    "A atividade poderá ser repetida futuramente utilizando alimentos reais para ampliar a experiência sensorial."
            }
        );


        // =====================================================
        // 3 - CONHECENDO AS FRUTAS
        // AGENDADA PARA 14/10
        // =====================================================

        Adicionar(
            new EducacaoAlimentar
            {
                InstituicaoId =
                    1,

                Tema =
                    "Conhecendo as frutas",

                DataAcao =
                    new DateTime(2026, 10, 14),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                Situacao =
                    StatusEducacaoAlimentar.Agendada,

                PublicoAlvo =
                    "Alunos da Educação Infantil",

                Turma =
                    "Maternal II, Maternal III, Pré I e Pré II",

                FaixaEtaria =
                    "4 a 6 anos",

                NumeroParticipantes =
                    0,

                Objetivo =
                    "Estimular a curiosidade e ampliar o contato das crianças com diferentes frutas por meio de uma experiência lúdica e sensorial.",

                ConteudoTrabalhado =
                    "Tipos de frutas, cores, aromas, texturas, sabores e importância da variedade alimentar.",

                Metodologia =
                    "Apresentação de diferentes frutas, identificação pelos alunos, exploração de cores, aromas e texturas e atividade lúdica de reconhecimento.",

                MateriaisUtilizados =
                    "Frutas variadas, bandejas, cartazes educativos, figuras ilustrativas e materiais para dinâmica em grupo.",

                DuracaoMinutos =
                    60,

                ParticipacaoPublico =
                    string.Empty,

                ResultadosObservados =
                    string.Empty,

                Observacoes =
                    "Atividade programada para 14/10. Os resultados e o número de participantes serão registrados após a realização."
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<EducacaoAlimentar> ObterTodos()
    {
        return _acoes
            .OrderByDescending(x =>
                x.DataAcao)
            .ToList();
    }


    public List<EducacaoAlimentar> ObterPorInstituicao(
        int instituicaoId)
    {
        return _acoes
            .Where(x =>
                x.InstituicaoId ==
                instituicaoId)
            .OrderByDescending(x =>
                x.DataAcao)
            .ToList();
    }


    public EducacaoAlimentar? ObterPorId(
        int id)
    {
        return _acoes
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        EducacaoAlimentar acao)
    {
        acao.Id =
            _proximoId++;

        acao.DataCadastro =
            DateTime.Now;

        acao.DataAtualizacao =
            null;

        PrepararDados(
            acao);

        _acoes.Add(
            acao);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        EducacaoAlimentar acaoAtualizada)
    {
        var acaoExistente =
            _acoes.FirstOrDefault(x =>
                x.Id ==
                acaoAtualizada.Id);


        if (acaoExistente is null)
        {
            return false;
        }


        acaoExistente.InstituicaoId =
            acaoAtualizada.InstituicaoId;

        acaoExistente.Tema =
            acaoAtualizada.Tema.Trim();

        acaoExistente.DataAcao =
            acaoAtualizada.DataAcao;

        acaoExistente.Responsavel =
            acaoAtualizada.Responsavel.Trim();

        acaoExistente.Situacao =
            acaoAtualizada.Situacao;

        acaoExistente.PublicoAlvo =
            acaoAtualizada.PublicoAlvo.Trim();

        acaoExistente.Turma =
            acaoAtualizada.Turma.Trim();

        acaoExistente.FaixaEtaria =
            acaoAtualizada.FaixaEtaria.Trim();

        acaoExistente.NumeroParticipantes =
            acaoAtualizada.NumeroParticipantes;

        acaoExistente.Objetivo =
            acaoAtualizada.Objetivo.Trim();

        acaoExistente.ConteudoTrabalhado =
            acaoAtualizada.ConteudoTrabalhado.Trim();

        acaoExistente.Metodologia =
            acaoAtualizada.Metodologia.Trim();

        acaoExistente.MateriaisUtilizados =
            acaoAtualizada.MateriaisUtilizados.Trim();

        acaoExistente.DuracaoMinutos =
            acaoAtualizada.DuracaoMinutos;

        acaoExistente.ParticipacaoPublico =
            acaoAtualizada.ParticipacaoPublico.Trim();

        acaoExistente.ResultadosObservados =
            acaoAtualizada.ResultadosObservados.Trim();

        acaoExistente.Observacoes =
            acaoAtualizada.Observacoes.Trim();

        acaoExistente.DataAtualizacao =
            DateTime.Now;


        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var acao =
            _acoes.FirstOrDefault(x =>
                x.Id == id);


        if (acao is null)
        {
            return false;
        }


        _acoes.Remove(
            acao);


        return true;
    }


    // =========================================================
    // INDICADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _acoes.Count(x =>
            x.InstituicaoId ==
            instituicaoId);
    }


    public int ContarRealizadas(
        int instituicaoId)
    {
        return _acoes.Count(x =>
            x.InstituicaoId ==
                instituicaoId &&
            x.Situacao ==
                StatusEducacaoAlimentar.Realizada);
    }


    public int ContarAgendadas(
        int instituicaoId)
    {
        return _acoes.Count(x =>
            x.InstituicaoId ==
                instituicaoId &&
            x.Situacao ==
                StatusEducacaoAlimentar.Agendada);
    }


    public int ContarCanceladas(
        int instituicaoId)
    {
        return _acoes.Count(x =>
            x.InstituicaoId ==
                instituicaoId &&
            x.Situacao ==
                StatusEducacaoAlimentar.Cancelada);
    }


    public int ContarParticipantesAlcancados(
        int instituicaoId)
    {
        return _acoes
            .Where(x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusEducacaoAlimentar.Realizada)
            .Sum(x =>
                x.NumeroParticipantes);
    }


    // =========================================================
    // PRÓXIMA AÇÃO
    // =========================================================

    public EducacaoAlimentar? ObterProximaAcao(
        int instituicaoId)
    {
        var hoje =
            DateTime.Today;


        return _acoes
            .Where(x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusEducacaoAlimentar.Agendada &&
                x.DataAcao.Date >= hoje)
            .OrderBy(x =>
                x.DataAcao)
            .FirstOrDefault();
    }


    // =========================================================
    // PREPARAÇÃO DOS DADOS
    // =========================================================

    private void PrepararDados(
        EducacaoAlimentar acao)
    {
        acao.Tema =
            acao.Tema.Trim();

        acao.Responsavel =
            acao.Responsavel.Trim();

        acao.PublicoAlvo =
            acao.PublicoAlvo.Trim();

        acao.Turma =
            acao.Turma.Trim();

        acao.FaixaEtaria =
            acao.FaixaEtaria.Trim();

        acao.Objetivo =
            acao.Objetivo.Trim();

        acao.ConteudoTrabalhado =
            acao.ConteudoTrabalhado.Trim();

        acao.Metodologia =
            acao.Metodologia.Trim();

        acao.MateriaisUtilizados =
            acao.MateriaisUtilizados.Trim();

        acao.ParticipacaoPublico =
            acao.ParticipacaoPublico.Trim();

        acao.ResultadosObservados =
            acao.ResultadosObservados.Trim();

        acao.Observacoes =
            acao.Observacoes.Trim();
    }
}