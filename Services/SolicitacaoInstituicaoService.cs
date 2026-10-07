using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class SolicitacaoInstituicaoService
{
    private readonly List<SolicitacaoInstituicao> _solicitacoes =
        new();

    private int _proximoId =
        1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public SolicitacaoInstituicaoService()
    {
        CriarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosDemonstracao()
    {
        if (_solicitacoes.Any())
        {
            return;
        }


        // =====================================================
        // 1 - RESTRIÇÃO ALIMENTAR - CONCLUÍDA
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.RestricaoAlimentar,

                Assunto =
                    "Atualização de restrição alimentar - Bernardo Oliveira",

                Mensagem =
                    "A família do aluno Bernardo Oliveira informou diagnóstico de intolerância à lactose. Solicitamos orientação para adequação das refeições oferecidas pela escola.",

                EnviadoPor =
                    "Fernanda Alves - Coordenação",

                DataEnvio =
                    new DateTime(2026, 9, 10, 9, 15, 0),

                Status =
                    StatusSolicitacaoInstituicao.Concluida,

                RespostaNutricionista =
                    "Restrição registrada. As preparações deverão utilizar alternativas sem lactose quando necessário. A equipe deve conferir os rótulos dos produtos e manter a refeição do aluno corretamente identificada.",

                DataResposta =
                    new DateTime(2026, 9, 10, 14, 30, 0),

                DataAtualizacao =
                    new DateTime(2026, 9, 11, 10, 0, 0)
            }
        );


        // =====================================================
        // 2 - CARDÁPIO - CONCLUÍDA
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.Cardapio,

                Assunto =
                    "Cardápio do mês de outubro",

                Mensagem =
                    "Gostaríamos de confirmar se o cardápio de outubro já está disponível para consulta e envio às famílias.",

                EnviadoPor =
                    "Fernanda Alves - Coordenação",

                DataEnvio =
                    new DateTime(2026, 9, 28, 8, 40, 0),

                Status =
                    StatusSolicitacaoInstituicao.Concluida,

                RespostaNutricionista =
                    "Sim. O cardápio de outubro foi finalizado e já está disponível no sistema para consulta da instituição.",

                DataResposta =
                    new DateTime(2026, 9, 28, 11, 10, 0),

                DataAtualizacao =
                    new DateTime(2026, 9, 28, 11, 15, 0)
            }
        );


        // =====================================================
        // 3 - CONVERSA COM PAIS/RESPONSÁVEIS - RESPONDIDA
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.ConversaPaisResponsaveis,

                Assunto =
                    "Orientação à família sobre alimentação escolar",

                Mensagem =
                    "A família de uma aluna solicitou orientações sobre a aceitação de frutas e verduras. Podemos organizar uma conversa com o nutricionista para orientar os responsáveis?",

                EnviadoPor =
                    "Fernanda Alves - Coordenação",

                DataEnvio =
                    new DateTime(2026, 10, 2, 13, 20, 0),

                Status =
                    StatusSolicitacaoInstituicao.Respondida,

                RespostaNutricionista =
                    "Sim. Podemos organizar uma conversa com a família para orientar estratégias de exposição e incentivo alimentar sem pressão. Podemos alinhar o melhor horário com a coordenação.",

                DataResposta =
                    new DateTime(2026, 10, 2, 17, 10, 0),

                DataAtualizacao =
                    new DateTime(2026, 10, 2, 17, 10, 0)
            }
        );


        // =====================================================
        // 4 - SOLICITAÇÃO DE VISITA - EM ANÁLISE
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.SolicitarVisita,

                Assunto =
                    "Acompanhamento das dietas especiais",

                Mensagem =
                    "Gostaríamos de aproveitar a próxima visita para revisar com a equipe a identificação e distribuição das refeições dos alunos com dietas especiais.",

                EnviadoPor =
                    "Fernanda Alves - Coordenação",

                DataEnvio =
                    new DateTime(2026, 10, 6, 16, 25, 0),

                Status =
                    StatusSolicitacaoInstituicao.EmAnalise,

                RespostaNutricionista =
                    string.Empty,

                DataResposta =
                    null,

                DataAtualizacao =
                    new DateTime(2026, 10, 7, 8, 30, 0)
            }
        );


        // =====================================================
        // 5 - DOCUMENTO - NOVA
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.Documento,

                Assunto =
                    "Lista atualizada de POPs",

                Mensagem =
                    "Poderia disponibilizar para a escola a relação atualizada dos POPs utilizados na unidade? Estamos organizando a documentação da cozinha.",

                EnviadoPor =
                    "Fernanda Alves - Coordenação",

                DataEnvio =
                    new DateTime(2026, 10, 7, 10, 45, 0),

                Status =
                    StatusSolicitacaoInstituicao.Nova,

                RespostaNutricionista =
                    string.Empty,

                DataResposta =
                    null,

                DataAtualizacao =
                    null
            }
        );


        // =====================================================
        // 6 - ALTERAÇÃO - NOVA
        // =====================================================

        AdicionarDemonstracao(
            new SolicitacaoInstituicao
            {
                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Tipo =
                    TipoSolicitacaoInstituicao.Alteracao,

                Assunto =
                    "Substituição de fruta no cardápio",

                Mensagem =
                    "O fornecedor informou indisponibilidade de mamão para esta semana. Podemos substituir por banana nas refeições previstas?",

                EnviadoPor =
                    "Mariana Lopes - Cozinha",

                DataEnvio =
                    new DateTime(2026, 10, 7, 14, 20, 0),

                Status =
                    StatusSolicitacaoInstituicao.Nova,

                RespostaNutricionista =
                    string.Empty,

                DataResposta =
                    null,

                DataAtualizacao =
                    null
            }
        );
    }


    // =========================================================
    // MÉTODO INTERNO PARA DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void AdicionarDemonstracao(
        SolicitacaoInstituicao solicitacao)
    {
        solicitacao.Id =
            _proximoId++;

        solicitacao.InstituicaoNome =
            solicitacao.InstituicaoNome.Trim();

        solicitacao.Assunto =
            solicitacao.Assunto.Trim();

        solicitacao.Mensagem =
            solicitacao.Mensagem.Trim();

        solicitacao.EnviadoPor =
            solicitacao.EnviadoPor.Trim();

        solicitacao.RespostaNutricionista =
            solicitacao.RespostaNutricionista.Trim();

        _solicitacoes.Add(
            solicitacao);
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<SolicitacaoInstituicao> ObterTodas()
    {
        return _solicitacoes
            .OrderByDescending(x => x.DataEnvio)
            .ThenByDescending(x => x.Id)
            .ToList();
    }


    public List<SolicitacaoInstituicao> ObterPorInstituicao(
        int instituicaoId)
    {
        return _solicitacoes
            .Where(x =>
                x.InstituicaoId ==
                instituicaoId)
            .OrderByDescending(x =>
                x.DataEnvio)
            .ThenByDescending(x =>
                x.Id)
            .ToList();
    }


    public SolicitacaoInstituicao? ObterPorId(
        int id)
    {
        return _solicitacoes
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public SolicitacaoInstituicao Adicionar(
        SolicitacaoInstituicao solicitacao)
    {
        solicitacao.Id =
            _proximoId++;

        solicitacao.DataEnvio =
            DateTime.Now;

        solicitacao.DataAtualizacao =
            null;

        solicitacao.DataResposta =
            null;

        solicitacao.Status =
            StatusSolicitacaoInstituicao.Nova;

        solicitacao.InstituicaoNome =
            solicitacao.InstituicaoNome.Trim();

        solicitacao.Assunto =
            solicitacao.Assunto.Trim();

        solicitacao.Mensagem =
            solicitacao.Mensagem.Trim();

        solicitacao.EnviadoPor =
            solicitacao.EnviadoPor.Trim();

        solicitacao.RespostaNutricionista =
            string.Empty;

        _solicitacoes.Add(
            solicitacao);

        return solicitacao;
    }


    // =========================================================
    // STATUS
    // =========================================================

    public bool MarcarEmAnalise(
        int id)
    {
        var solicitacao =
            ObterPorId(id);

        if (solicitacao is null)
        {
            return false;
        }


        solicitacao.Status =
            StatusSolicitacaoInstituicao.EmAnalise;

        solicitacao.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    public bool MarcarComoRespondida(
        int id,
        string resposta)
    {
        var solicitacao =
            ObterPorId(id);

        if (solicitacao is null)
        {
            return false;
        }


        solicitacao.RespostaNutricionista =
            resposta?.Trim()
            ??
            string.Empty;

        solicitacao.DataResposta =
            DateTime.Now;

        solicitacao.DataAtualizacao =
            DateTime.Now;

        solicitacao.Status =
            StatusSolicitacaoInstituicao.Respondida;

        return true;
    }


    public bool Concluir(
        int id)
    {
        var solicitacao =
            ObterPorId(id);

        if (solicitacao is null)
        {
            return false;
        }


        solicitacao.Status =
            StatusSolicitacaoInstituicao.Concluida;

        solicitacao.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    public bool Reabrir(
        int id)
    {
        var solicitacao =
            ObterPorId(id);

        if (solicitacao is null)
        {
            return false;
        }


        solicitacao.Status =
            StatusSolicitacaoInstituicao.EmAnalise;

        solicitacao.DataAtualizacao =
            DateTime.Now;

        return true;
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _solicitacoes.Count(x =>
            x.InstituicaoId ==
            instituicaoId);
    }


    public int ContarNovas(
        int? instituicaoId = null)
    {
        return _solicitacoes.Count(x =>
            (!instituicaoId.HasValue ||
             x.InstituicaoId ==
             instituicaoId.Value)
            &&
            x.Status ==
            StatusSolicitacaoInstituicao.Nova);
    }


    public int ContarEmAberto(
        int? instituicaoId = null)
    {
        return _solicitacoes.Count(x =>
            (!instituicaoId.HasValue ||
             x.InstituicaoId ==
             instituicaoId.Value)
            &&
            x.Status !=
            StatusSolicitacaoInstituicao.Concluida);
    }


    public int ContarRespondidas(
        int? instituicaoId = null)
    {
        return _solicitacoes.Count(x =>
            (!instituicaoId.HasValue ||
             x.InstituicaoId ==
             instituicaoId.Value)
            &&
            x.Status ==
            StatusSolicitacaoInstituicao.Respondida);
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var solicitacao =
            ObterPorId(id);

        if (solicitacao is null)
        {
            return false;
        }


        return _solicitacoes.Remove(
            solicitacao);
    }
}