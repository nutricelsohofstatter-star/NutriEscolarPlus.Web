using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class BoasPraticasService
{
    private readonly List<VerificacaoBoasPraticas> _verificacoes =
        new();

    private int _proximoId = 1;

    private int _proximoItemId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public BoasPraticasService()
    {
        CriarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosDemonstracao()
    {
        if (_verificacoes.Any())
        {
            return;
        }


        // =====================================================
        // 1 - VERIFICAÇÃO DE 14/09/2026
        // =====================================================

        Adicionar(
            new VerificacaoBoasPraticas
            {
                InstituicaoId = 1,

                DataVerificacao =
                    new DateTime(2026, 9, 14),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                ObservacoesGerais =
                    "Verificação realizada durante visita técnica de rotina. A unidade apresentou boas condições gerais de higiene e organização. Foi identificada necessidade de melhorar a identificação de produtos após abertura.",

                Situacao =
                    StatusVerificacaoBoasPraticas.Concluida,

                Itens =
                    new List<ItemVerificacaoBoasPraticas>
                    {
                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.HigieneManipuladores,

                            Descricao =
                                "Manipuladores apresentam condições adequadas de higiene pessoal e utilizam vestimenta apropriada.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Equipe apresentou boa higiene pessoal e utilização adequada dos uniformes."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Recebimento,

                            Descricao =
                                "Os alimentos são conferidos no momento do recebimento quanto à integridade, validade e condições gerais.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Produtos recebidos em condições adequadas."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Armazenamento,

                            Descricao =
                                "Produtos abertos e fracionados estão devidamente identificados.",

                            Resultado =
                                ResultadoItemBoasPraticas.NaoConforme,

                            Observacao =
                                "Foram encontrados alguns produtos abertos sem identificação completa.",

                            AcaoCorretiva =
                                "Implantar identificação contendo nome do produto, data de abertura e prazo de utilização.",

                            ResponsavelCorrecao =
                                "Equipe da cozinha",

                            PrazoCorrecao =
                                new DateTime(2026, 9, 21)
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.PreparoAlimentos,

                            Descricao =
                                "O preparo dos alimentos é realizado de forma organizada, reduzindo riscos de contaminação cruzada.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Fluxo de preparo adequado."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.EquipamentosUtensilios,

                            Descricao =
                                "Equipamentos e utensílios encontram-se em boas condições de conservação e utilização.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Equipamentos avaliados em condições adequadas."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.LimpezaHigienizacao,

                            Descricao =
                                "A cozinha e as superfícies de manipulação apresentam condições adequadas de limpeza.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Ambiente limpo e organizado."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.ControlePragas,

                            Descricao =
                                "Não foram observados sinais aparentes de presença de pragas no ambiente.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Sem evidências aparentes durante a inspeção."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Agua,

                            Descricao =
                                "A água utilizada nas atividades da unidade apresenta condições adequadas para utilização.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Sem intercorrências relatadas."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Residuos,

                            Descricao =
                                "Os resíduos são acondicionados e retirados de forma adequada.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Coletores adequados e rotina de retirada organizada."
                        }
                    }
            }
        );


        // =====================================================
        // 2 - VERIFICAÇÃO DE 05/10/2026
        // =====================================================

        Adicionar(
            new VerificacaoBoasPraticas
            {
                InstituicaoId = 1,

                DataVerificacao =
                    new DateTime(2026, 10, 5),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                ObservacoesGerais =
                    "Verificação de acompanhamento realizada após as orientações da visita anterior. A identificação dos produtos foi regularizada. Foi observada oportunidade de melhoria na identificação das preparações destinadas aos alunos com dietas especiais.",

                Situacao =
                    StatusVerificacaoBoasPraticas.Concluida,

                Itens =
                    new List<ItemVerificacaoBoasPraticas>
                    {
                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.HigieneManipuladores,

                            Descricao =
                                "Manipuladores realizam higiene adequada das mãos e utilizam vestimenta apropriada.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Procedimentos observados de forma satisfatória."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Recebimento,

                            Descricao =
                                "Produtos recebidos são avaliados quanto à integridade das embalagens e validade.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Rotina de recebimento organizada."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Armazenamento,

                            Descricao =
                                "Produtos abertos e fracionados encontram-se corretamente identificados.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Não conformidade observada na verificação anterior foi corrigida."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.PreparoAlimentos,

                            Descricao =
                                "Preparações destinadas às dietas especiais estão claramente identificadas durante o preparo e distribuição.",

                            Resultado =
                                ResultadoItemBoasPraticas.NaoConforme,

                            Observacao =
                                "As preparações especiais são realizadas, porém a identificação visual pode ser melhorada para reduzir o risco de trocas.",

                            AcaoCorretiva =
                                "Implantar identificação específica e visível nas preparações destinadas aos alunos com dietas especiais.",

                            ResponsavelCorrecao =
                                "Responsável pela cozinha",

                            PrazoCorrecao =
                                new DateTime(2026, 10, 16)
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.EquipamentosUtensilios,

                            Descricao =
                                "Equipamentos e utensílios apresentam condições adequadas de conservação.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Sem alterações relevantes."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.LimpezaHigienizacao,

                            Descricao =
                                "Superfícies, equipamentos e utensílios apresentam condições adequadas de higienização.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Rotina de higienização satisfatória."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.ControlePragas,

                            Descricao =
                                "Ambiente apresenta condições adequadas quanto à prevenção e controle de pragas.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Sem sinais aparentes durante a verificação."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Agua,

                            Descricao =
                                "Abastecimento de água disponível para as atividades de preparo e higienização.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Abastecimento regular."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Residuos,

                            Descricao =
                                "Resíduos são acondicionados em recipientes adequados e retirados regularmente.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Procedimento adequado."
                        }
                    }
            }
        );


        // =====================================================
        // 3 - VERIFICAÇÃO EM ANDAMENTO
        // =====================================================

        Adicionar(
            new VerificacaoBoasPraticas
            {
                InstituicaoId = 1,

                DataVerificacao =
                    new DateTime(2026, 10, 7),

                Responsavel =
                    "Celso Felipe Roos Hofstatter",

                ObservacoesGerais =
                    "Verificação periódica iniciada para acompanhamento dos controles e preparação da próxima visita técnica.",

                Situacao =
                    StatusVerificacaoBoasPraticas.EmAndamento,

                Itens =
                    new List<ItemVerificacaoBoasPraticas>
                    {
                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.HigieneManipuladores,

                            Descricao =
                                "Conferir condições de higiene pessoal e utilização dos uniformes.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Item verificado e conforme."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Armazenamento,

                            Descricao =
                                "Conferir identificação, organização e validade dos produtos armazenados.",

                            Resultado =
                                ResultadoItemBoasPraticas.Conforme,

                            Observacao =
                                "Produtos organizados e identificados."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.PreparoAlimentos,

                            Descricao =
                                "Reavaliar a identificação das preparações destinadas às dietas especiais.",

                            Resultado =
                                ResultadoItemBoasPraticas.Pendente,

                            Observacao =
                                "Item será reavaliado após conclusão da ação corretiva prevista para 16/10."
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.EquipamentosUtensilios,

                            Descricao =
                                "Avaliar condições de conservação dos equipamentos e utensílios.",

                            Resultado =
                                ResultadoItemBoasPraticas.Pendente
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.LimpezaHigienizacao,

                            Descricao =
                                "Avaliar os procedimentos e registros de higienização.",

                            Resultado =
                                ResultadoItemBoasPraticas.Pendente
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.ControlePragas,

                            Descricao =
                                "Verificar condições relacionadas ao controle integrado de pragas.",

                            Resultado =
                                ResultadoItemBoasPraticas.Pendente
                        },

                        new ItemVerificacaoBoasPraticas
                        {
                            Categoria =
                                CategoriaBoasPraticas.Residuos,

                            Descricao =
                                "Avaliar acondicionamento e fluxo de retirada dos resíduos.",

                            Resultado =
                                ResultadoItemBoasPraticas.Pendente
                        }
                    }
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<VerificacaoBoasPraticas> ObterTodos()
    {
        return _verificacoes
            .OrderByDescending(x =>
                x.DataVerificacao)
            .ThenByDescending(x =>
                x.Id)
            .ToList();
    }


    public List<VerificacaoBoasPraticas> ObterPorInstituicao(
        int instituicaoId)
    {
        return _verificacoes
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .OrderByDescending(x =>
                x.DataVerificacao)
            .ThenByDescending(x =>
                x.Id)
            .ToList();
    }


    public VerificacaoBoasPraticas? ObterPorId(
        int id)
    {
        return _verificacoes
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        VerificacaoBoasPraticas verificacao)
    {
        verificacao.Id =
            _proximoId++;

        verificacao.DataCadastro =
            DateTime.Now;

        verificacao.DataAtualizacao =
            null;

        verificacao.Responsavel =
            verificacao.Responsavel.Trim();

        verificacao.ObservacoesGerais =
            verificacao.ObservacoesGerais.Trim();

        PrepararItens(
            verificacao.Itens);

        _verificacoes.Add(
            verificacao);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        VerificacaoBoasPraticas atualizada)
    {
        var existente =
            ObterPorId(atualizada.Id);

        if (existente is null)
        {
            return false;
        }


        existente.InstituicaoId =
            atualizada.InstituicaoId;

        existente.DataVerificacao =
            atualizada.DataVerificacao;

        existente.Responsavel =
            atualizada.Responsavel.Trim();

        existente.ObservacoesGerais =
            atualizada.ObservacoesGerais.Trim();

        existente.Situacao =
            atualizada.Situacao;

        existente.Itens =
            atualizada.Itens
                .Select(x =>
                    new ItemVerificacaoBoasPraticas
                    {
                        Id =
                            x.Id,

                        Categoria =
                            x.Categoria,

                        Descricao =
                            x.Descricao,

                        Resultado =
                            x.Resultado,

                        Observacao =
                            x.Observacao,

                        AcaoCorretiva =
                            x.AcaoCorretiva,

                        ResponsavelCorrecao =
                            x.ResponsavelCorrecao,

                        PrazoCorrecao =
                            x.PrazoCorrecao
                    })
                .ToList();


        PrepararItens(
            existente.Itens);

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
        var verificacao =
            ObterPorId(id);

        if (verificacao is null)
        {
            return false;
        }


        _verificacoes.Remove(
            verificacao);

        return true;
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _verificacoes.Count(x =>
            x.InstituicaoId ==
            instituicaoId);
    }


    public int ContarConcluidas(
        int instituicaoId)
    {
        return _verificacoes.Count(x =>
            x.InstituicaoId ==
                instituicaoId &&
            x.Situacao ==
                StatusVerificacaoBoasPraticas.Concluida);
    }


    public int ContarEmAndamento(
        int instituicaoId)
    {
        return _verificacoes.Count(x =>
            x.InstituicaoId ==
                instituicaoId &&
            x.Situacao ==
                StatusVerificacaoBoasPraticas.EmAndamento);
    }


    public int ContarNaoConformidadesAbertas(
        int instituicaoId)
    {
        return _verificacoes
            .Where(x =>
                x.InstituicaoId ==
                instituicaoId)
            .SelectMany(x =>
                x.Itens)
            .Count(x =>
                x.Resultado ==
                    ResultadoItemBoasPraticas.NaoConforme);
    }


    // =========================================================
    // PREPARAÇÃO DOS ITENS
    // =========================================================

    private void PrepararItens(
        IEnumerable<ItemVerificacaoBoasPraticas> itens)
    {
        foreach (var item in itens)
        {
            if (item.Id <= 0)
            {
                item.Id =
                    _proximoItemId++;
            }

            item.Descricao =
                item.Descricao.Trim();

            item.Observacao =
                item.Observacao.Trim();

            item.AcaoCorretiva =
                item.AcaoCorretiva.Trim();

            item.ResponsavelCorrecao =
                item.ResponsavelCorrecao.Trim();
        }
    }
}