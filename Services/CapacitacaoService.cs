using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class CapacitacaoService
{
    private readonly List<Capacitacao> _capacitacoes = new();

    private int _proximoId = 1;

    private int _proximoParticipanteId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public CapacitacaoService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_capacitacoes.Any())
        {
            return;
        }


        // =====================================================
        // CAPACITAÇÃO 1 - REALIZADA
        // =====================================================

        Adicionar(
            new Capacitacao
            {
                InstituicaoId = 1,

                Tema =
                    "Boas Práticas na Manipulação de Alimentos",

                DataCapacitacao =
                    new DateTime(2026, 9, 21),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                PublicoAlvo =
                    "Equipe responsável pelo preparo e distribuição das refeições",

                CargaHoraria =
                    2.0m,

                Local =
                    "Escola Girassol",

                Objetivo =
                    "Capacitar a equipe quanto às boas práticas de manipulação de alimentos, prevenção de contaminações e organização adequada do ambiente de produção.",

                ConteudoAbordado =
                    "Higiene pessoal; higienização das mãos; uso adequado de uniforme; prevenção de contaminação cruzada; armazenamento dos alimentos; identificação de produtos abertos; controle de validade; higienização de superfícies e utensílios.",

                Metodologia =
                    "Capacitação dialogada com apresentação dos principais cuidados, exemplos práticos da rotina da cozinha e discussão de situações observadas durante a visita técnica.",

                Observacoes =
                    "Equipe participativa e receptiva às orientações. Reforçada a necessidade de manter todos os produtos abertos devidamente identificados.",

                Situacao =
                    StatusCapacitacao.Realizada,

                Participantes =
                    new List<ParticipanteCapacitacao>
                    {
                        new ParticipanteCapacitacao
                        {
                            Nome = "Mariana Lopes",
                            Funcao = "Cozinheira",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Sandra Ribeiro",
                            Funcao = "Auxiliar de cozinha",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Patrícia Gomes",
                            Funcao = "Auxiliar de cozinha",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Fernanda Alves",
                            Funcao = "Coordenadora",
                            Presente = true
                        }
                    }
            }
        );


        // =====================================================
        // CAPACITAÇÃO 2 - REALIZADA
        // =====================================================

        Adicionar(
            new Capacitacao
            {
                InstituicaoId = 1,

                Tema =
                    "Dietas Especiais e Alergias Alimentares no Ambiente Escolar",

                DataCapacitacao =
                    new DateTime(2026, 10, 6),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                PublicoAlvo =
                    "Equipe da cozinha, auxiliares e coordenação",

                CargaHoraria =
                    1.5m,

                Local =
                    "Escola Girassol",

                Objetivo =
                    "Orientar a equipe sobre os cuidados necessários no atendimento de alunos com alergias, intolerâncias e outras necessidades alimentares específicas.",

                ConteudoAbordado =
                    "Diferença entre alergia e intolerância alimentar; leitura de rótulos; identificação de ingredientes; prevenção de contato cruzado; organização das dietas especiais; armazenamento; preparo separado; identificação das refeições e cuidados durante a distribuição.",

                Metodologia =
                    "Exposição dialogada, apresentação de exemplos de rótulos e discussão dos casos fictícios cadastrados no sistema para treinamento da equipe.",

                Observacoes =
                    "Foram reforçados os cuidados relacionados à APLV, intolerância à lactose e alergia a ovo, bem como a importância da identificação das preparações especiais.",

                Situacao =
                    StatusCapacitacao.Realizada,

                Participantes =
                    new List<ParticipanteCapacitacao>
                    {
                        new ParticipanteCapacitacao
                        {
                            Nome = "Mariana Lopes",
                            Funcao = "Cozinheira",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Sandra Ribeiro",
                            Funcao = "Auxiliar de cozinha",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Patrícia Gomes",
                            Funcao = "Auxiliar de cozinha",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Fernanda Alves",
                            Funcao = "Coordenadora",
                            Presente = true
                        },

                        new ParticipanteCapacitacao
                        {
                            Nome = "Juliana Martins",
                            Funcao = "Professora",
                            Presente = true
                        }
                    }
            }
        );


        // =====================================================
        // CAPACITAÇÃO 3 - AGENDADA
        // =====================================================

        Adicionar(
            new Capacitacao
            {
                InstituicaoId = 1,

                Tema =
                    "Higienização e Controle Higiênico-Sanitário",

                DataCapacitacao =
                    new DateTime(2026, 10, 26),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                PublicoAlvo =
                    "Manipuladores de alimentos e auxiliares",

                CargaHoraria =
                    2.0m,

                Local =
                    "Escola Girassol",

                Objetivo =
                    "Reforçar os procedimentos adequados de higienização do ambiente, equipamentos, utensílios e alimentos.",

                ConteudoAbordado =
                    "Higienização de superfícies; equipamentos e utensílios; higienização de frutas, verduras e legumes; diluição e utilização adequada de produtos; frequência de limpeza e registros de controle.",

                Metodologia =
                    "Capacitação teórico-prática com demonstração dos procedimentos utilizados na rotina da unidade.",

                Observacoes =
                    "Capacitação programada como continuidade das ações de melhoria das boas práticas da instituição.",

                Situacao =
                    StatusCapacitacao.Agendada,

                Participantes =
                    new List<ParticipanteCapacitacao>()
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<Capacitacao> ObterTodos()
    {
        return _capacitacoes
            .OrderByDescending(x => x.DataCapacitacao)
            .ToList();
    }


    public List<Capacitacao> ObterPorInstituicao(
        int instituicaoId)
    {
        return _capacitacoes
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .OrderByDescending(x =>
                x.DataCapacitacao)
            .ToList();
    }


    public Capacitacao? ObterPorId(int id)
    {
        return _capacitacoes
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        Capacitacao capacitacao)
    {
        capacitacao.Id =
            _proximoId++;

        capacitacao.DataCadastro =
            DateTime.Now;

        capacitacao.DataAtualizacao =
            null;

        capacitacao.Tema =
            capacitacao.Tema.Trim();

        capacitacao.Responsavel =
            capacitacao.Responsavel.Trim();

        capacitacao.PublicoAlvo =
            capacitacao.PublicoAlvo.Trim();

        capacitacao.Local =
            capacitacao.Local.Trim();

        capacitacao.Objetivo =
            capacitacao.Objetivo.Trim();

        capacitacao.ConteudoAbordado =
            capacitacao.ConteudoAbordado.Trim();

        capacitacao.Metodologia =
            capacitacao.Metodologia.Trim();

        capacitacao.Observacoes =
            capacitacao.Observacoes.Trim();

        PrepararParticipantes(
            capacitacao);

        _capacitacoes.Add(
            capacitacao);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        Capacitacao capacitacaoAtualizada)
    {
        var capacitacaoExistente =
            _capacitacoes.FirstOrDefault(x =>
                x.Id == capacitacaoAtualizada.Id);

        if (capacitacaoExistente is null)
        {
            return false;
        }


        capacitacaoExistente.InstituicaoId =
            capacitacaoAtualizada.InstituicaoId;

        capacitacaoExistente.Tema =
            capacitacaoAtualizada.Tema.Trim();

        capacitacaoExistente.DataCapacitacao =
            capacitacaoAtualizada.DataCapacitacao;

        capacitacaoExistente.Responsavel =
            capacitacaoAtualizada.Responsavel.Trim();

        capacitacaoExistente.PublicoAlvo =
            capacitacaoAtualizada.PublicoAlvo.Trim();

        capacitacaoExistente.CargaHoraria =
            capacitacaoAtualizada.CargaHoraria;

        capacitacaoExistente.Local =
            capacitacaoAtualizada.Local.Trim();

        capacitacaoExistente.Objetivo =
            capacitacaoAtualizada.Objetivo.Trim();

        capacitacaoExistente.ConteudoAbordado =
            capacitacaoAtualizada.ConteudoAbordado.Trim();

        capacitacaoExistente.Metodologia =
            capacitacaoAtualizada.Metodologia.Trim();

        capacitacaoExistente.Observacoes =
            capacitacaoAtualizada.Observacoes.Trim();

        capacitacaoExistente.Situacao =
            capacitacaoAtualizada.Situacao;

        capacitacaoExistente.Participantes =
            capacitacaoAtualizada.Participantes;

        capacitacaoExistente.DataAtualizacao =
            DateTime.Now;


        PrepararParticipantes(
            capacitacaoExistente);


        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(int id)
    {
        var capacitacao =
            _capacitacoes.FirstOrDefault(x =>
                x.Id == id);

        if (capacitacao is null)
        {
            return false;
        }


        _capacitacoes.Remove(
            capacitacao);

        return true;
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _capacitacoes.Count(x =>
            x.InstituicaoId == instituicaoId);
    }


    public int ContarRealizadas(
        int instituicaoId)
    {
        return _capacitacoes.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusCapacitacao.Realizada);
    }


    public int ContarAgendadas(
        int instituicaoId)
    {
        return _capacitacoes.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusCapacitacao.Agendada);
    }


    public int ContarCanceladas(
        int instituicaoId)
    {
        return _capacitacoes.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusCapacitacao.Cancelada);
    }


    public int ContarParticipantesCapacitados(
        int instituicaoId)
    {
        return _capacitacoes
            .Where(x =>
                x.InstituicaoId == instituicaoId &&
                x.Situacao ==
                    StatusCapacitacao.Realizada)
            .SelectMany(x =>
                x.Participantes)
            .Count(x =>
                x.Presente);
    }


    // =========================================================
    // PRÓXIMA CAPACITAÇÃO
    // =========================================================

    public Capacitacao? ObterProximaCapacitacao(
        int instituicaoId)
    {
        var hoje =
            DateTime.Today;


        return _capacitacoes
            .Where(x =>
                x.InstituicaoId == instituicaoId &&
                x.Situacao ==
                    StatusCapacitacao.Agendada &&
                x.DataCapacitacao.Date >= hoje)
            .OrderBy(x =>
                x.DataCapacitacao)
            .FirstOrDefault();
    }


    // =========================================================
    // PARTICIPANTES
    // =========================================================

    private void PrepararParticipantes(
        Capacitacao capacitacao)
    {
        foreach (var participante
                 in capacitacao.Participantes)
        {
            if (participante.Id == 0)
            {
                participante.Id =
                    _proximoParticipanteId++;
            }

            participante.Nome =
                participante.Nome.Trim();

            participante.Funcao =
                participante.Funcao.Trim();
        }
    }
}