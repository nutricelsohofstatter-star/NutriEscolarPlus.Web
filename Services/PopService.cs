using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class PopService
{
    private readonly List<Pop> _pops =
        new();

    private int _proximoId =
        1;

    private int _proximoMaterialId =
        1;

    private int _proximoEtapaId =
        1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public PopService()
    {
        CriarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosDemonstracao()
    {
        if (_pops.Any())
        {
            return;
        }


        // =====================================================
        // POP 01 - HIGIENE DAS MÃOS
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 01",

                Titulo =
                    "Higienização das mãos dos manipuladores",

                Categoria =
                    CategoriaPop.HigieneManipuladores,

                Versao =
                    "1.0",

                DataElaboracao =
                    new DateTime(2026, 2, 10),

                DataUltimaRevisao =
                    new DateTime(2026, 8, 10),

                DataProximaRevisao =
                    new DateTime(2027, 2, 10),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Padronizar a correta higienização das mãos dos manipuladores de alimentos, reduzindo o risco de contaminação durante o preparo e a distribuição das refeições.",

                CampoAplicacao =
                    "Cozinha, área de preparo, distribuição e demais locais onde ocorra manipulação de alimentos.",

                Responsabilidades =
                    "Todos os manipuladores devem cumprir o procedimento. O responsável pela cozinha deve acompanhar sua execução e o nutricionista deve orientar e verificar periodicamente o cumprimento.",

                Frequencia =
                    "Antes de iniciar as atividades, após utilizar o sanitário, após manipular alimentos crus, resíduos ou materiais contaminados e sempre que necessário.",

                Monitoramento =
                    "Observação direta da técnica de higienização das mãos durante as visitas e atividades de supervisão.",

                Registros =
                    "Checklist de boas práticas e registros de capacitação da equipe.",

                AcoesCorretivas =
                    "Orientar imediatamente o manipulador quando identificada execução inadequada e reforçar a técnica correta de higienização.",

                Observacoes =
                    "Manter sabonete líquido, papel-toalha e condições adequadas para higienização disponíveis.",

                Referencias =
                    "Legislação sanitária e Manual de Boas Práticas da instituição.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Água corrente"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Sabonete líquido"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Papel-toalha descartável"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Retirar adornos das mãos e dos braços antes de iniciar o procedimento."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Molhar as mãos e os antebraços em água corrente."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Aplicar sabonete líquido e friccionar palmas, dorso, espaços entre os dedos, unhas, polegares e punhos."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Enxaguar completamente em água corrente."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Secar as mãos utilizando papel-toalha descartável."
                        }
                    }
            }
        );


        // =====================================================
        // POP 02 - HIGIENIZAÇÃO DE FRUTAS E HORTALIÇAS
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 02",

                Titulo =
                    "Higienização de frutas, verduras e legumes",

                Categoria =
                    CategoriaPop.HigienizacaoAlimentos,

                Versao =
                    "1.1",

                DataElaboracao =
                    new DateTime(2026, 2, 12),

                DataUltimaRevisao =
                    new DateTime(2026, 9, 5),

                DataProximaRevisao =
                    new DateTime(2027, 3, 5),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Padronizar as etapas de seleção, lavagem e higienização de frutas, verduras e legumes utilizados nas preparações da instituição.",

                CampoAplicacao =
                    "Área de pré-preparo e preparo de alimentos.",

                Responsabilidades =
                    "A equipe responsável pelo pré-preparo deve seguir todas as etapas estabelecidas e utilizar produtos regularizados e adequados para higienização de alimentos.",

                Frequencia =
                    "Sempre que frutas, verduras ou legumes necessitarem higienização antes do consumo ou preparo.",

                Monitoramento =
                    "Acompanhamento do procedimento durante visitas técnicas e conferência do produto utilizado.",

                Registros =
                    "Checklist de boas práticas e registros internos da unidade.",

                AcoesCorretivas =
                    "Repetir o procedimento quando houver falha na execução e orientar novamente o colaborador responsável.",

                Observacoes =
                    "A diluição e o tempo de contato do produto saneante devem seguir rigorosamente as instruções do fabricante.",

                Referencias =
                    "Legislação sanitária aplicável e orientações do fabricante do produto utilizado.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Água potável"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Recipiente higienizado"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Produto regularizado para higienização de alimentos"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Selecionar os alimentos, retirando partes deterioradas ou impróprias."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar lavagem inicial em água corrente para retirada de sujidades visíveis."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Preparar a solução higienizante conforme as orientações do fabricante."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Manter os alimentos em contato com a solução pelo período recomendado pelo fabricante."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar o procedimento final conforme orientação específica do produto utilizado e acondicionar adequadamente."
                        }
                    }
            }
        );


        // =====================================================
        // POP 03 - HIGIENIZAÇÃO DO AMBIENTE
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 03",

                Titulo =
                    "Higienização de instalações, superfícies e utensílios",

                Categoria =
                    CategoriaPop.HigienizacaoAmbiente,

                Versao =
                    "1.0",

                DataElaboracao =
                    new DateTime(2026, 3, 2),

                DataUltimaRevisao =
                    new DateTime(2026, 9, 15),

                DataProximaRevisao =
                    new DateTime(2027, 3, 15),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Padronizar os procedimentos de limpeza e higienização das instalações, superfícies, equipamentos e utensílios utilizados no serviço de alimentação.",

                CampoAplicacao =
                    "Cozinha, despensa, área de distribuição e demais áreas relacionadas à produção das refeições.",

                Responsabilidades =
                    "A equipe da cozinha é responsável pela execução do procedimento e pelo cumprimento das frequências estabelecidas.",

                Frequencia =
                    "Diariamente e sempre que houver necessidade, conforme o tipo de superfície ou equipamento.",

                Monitoramento =
                    "Inspeção visual das condições de limpeza e acompanhamento por meio do checklist de boas práticas.",

                Registros =
                    "Planilha ou registro de higienização e checklist de boas práticas.",

                AcoesCorretivas =
                    "Repetir a higienização quando forem observadas sujidades ou falhas no procedimento.",

                Observacoes =
                    "Os produtos utilizados devem ser apropriados para a finalidade e mantidos identificados em local específico.",

                Referencias =
                    "Manual de Boas Práticas e legislação sanitária aplicável.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Detergente"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Produto saneante adequado"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Panos e materiais de limpeza identificados"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Água"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Retirar resíduos e sujidades visíveis da superfície."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar a limpeza utilizando água e produto adequado."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Remover completamente os resíduos do produto de limpeza quando aplicável."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Aplicar o procedimento de higienização definido para a superfície ou equipamento."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Manter o local organizado e protegido após a conclusão do procedimento."
                        }
                    }
            }
        );


        // =====================================================
        // POP 04 - RECEBIMENTO DE ALIMENTOS
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 04",

                Titulo =
                    "Recebimento e conferência de alimentos",

                Categoria =
                    CategoriaPop.Recebimento,

                Versao =
                    "1.0",

                DataElaboracao =
                    new DateTime(2026, 3, 10),

                DataUltimaRevisao =
                    new DateTime(2026, 9, 20),

                DataProximaRevisao =
                    new DateTime(2027, 3, 20),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Estabelecer critérios para recebimento e conferência dos alimentos entregues à instituição.",

                CampoAplicacao =
                    "Área destinada ao recebimento de gêneros alimentícios.",

                Responsabilidades =
                    "O colaborador responsável pelo recebimento deve avaliar as condições dos produtos antes de aceitá-los e encaminhá-los ao armazenamento.",

                Frequencia =
                    "Em todas as entregas de alimentos.",

                Monitoramento =
                    "Conferência visual dos produtos, validade, integridade das embalagens e condições do transporte.",

                Registros =
                    "Registro de recebimento, notas fiscais e controles internos quando aplicáveis.",

                AcoesCorretivas =
                    "Recusar produtos que apresentem alterações, embalagens violadas, validade inadequada ou condições incompatíveis com o padrão estabelecido.",

                Observacoes =
                    "Produtos que necessitam refrigeração ou congelamento devem ser encaminhados rapidamente ao armazenamento adequado.",

                Referencias =
                    "Manual de Boas Práticas da instituição.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Registro de recebimento"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Caneta"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Termômetro, quando aplicável"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Conferir o fornecedor e os produtos entregues."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Verificar prazo de validade e integridade das embalagens."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Avaliar aparência, odor e condições gerais dos produtos quando aplicável."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Verificar as condições dos produtos refrigerados ou congelados."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Registrar eventuais não conformidades e encaminhar os produtos aprovados para armazenamento."
                        }
                    }
            }
        );


        // =====================================================
        // POP 05 - ARMAZENAMENTO
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 05",

                Titulo =
                    "Armazenamento e identificação de alimentos",

                Categoria =
                    CategoriaPop.Armazenamento,

                Versao =
                    "1.1",

                DataElaboracao =
                    new DateTime(2026, 3, 18),

                DataUltimaRevisao =
                    new DateTime(2026, 9, 21),

                DataProximaRevisao =
                    new DateTime(2027, 3, 21),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Padronizar o armazenamento e a identificação dos alimentos, contribuindo para organização, conservação e controle dos produtos utilizados na unidade.",

                CampoAplicacao =
                    "Despensa, refrigeradores, congeladores e demais locais destinados ao armazenamento de alimentos.",

                Responsabilidades =
                    "A equipe da cozinha deve manter os produtos organizados, protegidos, identificados e dentro dos respectivos prazos de utilização.",

                Frequencia =
                    "Diariamente e sempre que houver recebimento, abertura ou fracionamento de produtos.",

                Monitoramento =
                    "Inspeção visual da organização, identificação, integridade e validade dos alimentos.",

                Registros =
                    "Checklist de boas práticas e registros de controle da unidade.",

                AcoesCorretivas =
                    "Identificar imediatamente produtos abertos ou fracionados sem informação adequada e retirar produtos impróprios ou vencidos.",

                Observacoes =
                    "Este POP foi revisado após orientação realizada durante visita técnica de setembro.",

                Referencias =
                    "Manual de Boas Práticas e procedimentos internos da Escola Girassol.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Etiquetas de identificação"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Caneta permanente"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Recipientes adequados para armazenamento"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Conferir as condições dos produtos antes do armazenamento."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Organizar os produtos de acordo com suas características e necessidades de conservação."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Identificar produtos abertos ou fracionados com as informações definidas pela rotina da unidade."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Organizar os alimentos de forma a facilitar o controle dos prazos de utilização."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar conferência periódica da organização, integridade e validade dos produtos."
                        }
                    }
            }
        );


        // =====================================================
        // POP 06 - CONTROLE DE TEMPERATURA
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 06",

                Titulo =
                    "Controle de temperatura de alimentos e equipamentos",

                Categoria =
                    CategoriaPop.ControleTemperatura,

                Versao =
                    "1.0",

                DataElaboracao =
                    new DateTime(2026, 4, 8),

                DataUltimaRevisao =
                    new DateTime(2026, 9, 25),

                DataProximaRevisao =
                    new DateTime(2027, 3, 25),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.Vigente,

                Objetivo =
                    "Padronizar o monitoramento das temperaturas relacionadas ao armazenamento, preparo e distribuição dos alimentos.",

                CampoAplicacao =
                    "Refrigeradores, congeladores e alimentos submetidos ao controle de temperatura.",

                Responsabilidades =
                    "A equipe responsável deve realizar as medições previstas e comunicar alterações ao responsável técnico.",

                Frequencia =
                    "Conforme rotina de monitoramento estabelecida para cada equipamento ou etapa do processo.",

                Monitoramento =
                    "Medição utilizando termômetro adequado e avaliação dos registros realizados.",

                Registros =
                    "Planilhas de controle de temperatura.",

                AcoesCorretivas =
                    "Avaliar imediatamente situações fora do padrão definido, verificar o equipamento ou alimento envolvido e registrar a medida adotada.",

                Observacoes =
                    "O termômetro deve ser mantido limpo, conservado e utilizado conforme orientação específica.",

                Referencias =
                    "Manual de Boas Práticas e legislação sanitária aplicável.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Termômetro adequado"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Planilha de controle de temperatura"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Caneta"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Verificar as condições do termômetro antes da utilização."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar a medição conforme o equipamento ou alimento monitorado."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Registrar o valor obtido na planilha correspondente."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Avaliar o resultado conforme o padrão definido pela instituição."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Registrar e executar ação corretiva quando identificado resultado inadequado."
                        }
                    }
            }
        );


        // =====================================================
        // POP 07 - RESÍDUOS
        // EM REVISÃO
        // =========================================================

        Adicionar(
            new Pop
            {
                InstituicaoId = 1,

                Codigo =
                    "POP 07",

                Titulo =
                    "Manejo e descarte de resíduos",

                Categoria =
                    CategoriaPop.Residuos,

                Versao =
                    "1.0",

                DataElaboracao =
                    new DateTime(2026, 4, 15),

                DataUltimaRevisao =
                    new DateTime(2026, 4, 15),

                DataProximaRevisao =
                    new DateTime(2026, 10, 22),

                ElaboradoPor =
                    "Celso Felipe Roos Hofstatter",

                AprovadoPor =
                    "Coordenação - Escola Girassol",

                Situacao =
                    StatusPop.EmRevisao,

                Objetivo =
                    "Padronizar o acondicionamento, retirada e descarte dos resíduos gerados durante as atividades do serviço de alimentação.",

                CampoAplicacao =
                    "Cozinha, áreas de pré-preparo, preparo, distribuição e armazenamento temporário de resíduos.",

                Responsabilidades =
                    "A equipe da cozinha deve realizar o acondicionamento e retirada dos resíduos de forma organizada, evitando contaminação das áreas de manipulação.",

                Frequencia =
                    "Sempre que necessário e ao término das atividades de produção.",

                Monitoramento =
                    "Inspeção das condições dos recipientes e observação da rotina de retirada dos resíduos.",

                Registros =
                    "Checklist de boas práticas.",

                AcoesCorretivas =
                    "Realizar retirada imediata em situações de acúmulo e higienizar recipientes ou áreas quando necessário.",

                Observacoes =
                    "POP atualmente em revisão. Revisão programada na agenda para 22/10/2026.",

                Referencias =
                    "Manual de Boas Práticas e legislação sanitária aplicável.",

                Materiais =
                    new List<MaterialPop>
                    {
                        new MaterialPop
                        {
                            Descricao =
                                "Coletores de resíduos"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Sacos apropriados"
                        },

                        new MaterialPop
                        {
                            Descricao =
                                "Materiais de higienização"
                        }
                    },

                Etapas =
                    new List<EtapaPop>
                    {
                        new EtapaPop
                        {
                            Descricao =
                                "Acondicionar os resíduos nos recipientes destinados a essa finalidade."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Evitar acúmulo de resíduos nas áreas de manipulação."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar a retirada dos resíduos de forma a evitar contato com alimentos e superfícies limpas."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Encaminhar os resíduos ao local definido para armazenamento temporário ou coleta."
                        },

                        new EtapaPop
                        {
                            Descricao =
                                "Realizar a higienização dos recipientes conforme rotina da unidade."
                        }
                    }
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<Pop> ObterTodos()
    {
        return _pops
            .OrderBy(x =>
                x.Codigo)
            .ThenBy(x =>
                x.Titulo)
            .ToList();
    }


    public List<Pop> ObterPorInstituicao(
        int instituicaoId)
    {
        return _pops
            .Where(x =>
                x.InstituicaoId ==
                instituicaoId)
            .OrderBy(x =>
                x.Codigo)
            .ThenBy(x =>
                x.Titulo)
            .ToList();
    }


    public Pop? ObterPorId(
        int id)
    {
        return _pops
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        Pop pop)
    {
        pop.Id =
            _proximoId++;

        pop.DataCadastro =
            DateTime.Now;

        pop.DataAtualizacao =
            null;

        PrepararDados(
            pop);

        PrepararMateriais(
            pop);

        PrepararEtapas(
            pop);

        _pops.Add(
            pop);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        Pop popAtualizado)
    {
        var popExistente =
            _pops.FirstOrDefault(
                x =>
                    x.Id ==
                    popAtualizado.Id);

        if (popExistente is null)
        {
            return false;
        }


        popExistente.InstituicaoId =
            popAtualizado.InstituicaoId;

        popExistente.Codigo =
            popAtualizado.Codigo.Trim();

        popExistente.Titulo =
            popAtualizado.Titulo.Trim();

        popExistente.Categoria =
            popAtualizado.Categoria;

        popExistente.Versao =
            popAtualizado.Versao.Trim();

        popExistente.DataElaboracao =
            popAtualizado.DataElaboracao;

        popExistente.DataUltimaRevisao =
            popAtualizado.DataUltimaRevisao;

        popExistente.DataProximaRevisao =
            popAtualizado.DataProximaRevisao;

        popExistente.ElaboradoPor =
            popAtualizado.ElaboradoPor.Trim();

        popExistente.AprovadoPor =
            popAtualizado.AprovadoPor.Trim();

        popExistente.Situacao =
            popAtualizado.Situacao;

        popExistente.Objetivo =
            popAtualizado.Objetivo.Trim();

        popExistente.CampoAplicacao =
            popAtualizado.CampoAplicacao.Trim();

        popExistente.Responsabilidades =
            popAtualizado.Responsabilidades.Trim();

        popExistente.Frequencia =
            popAtualizado.Frequencia.Trim();

        popExistente.Monitoramento =
            popAtualizado.Monitoramento.Trim();

        popExistente.Registros =
            popAtualizado.Registros.Trim();

        popExistente.AcoesCorretivas =
            popAtualizado.AcoesCorretivas.Trim();

        popExistente.Observacoes =
            popAtualizado.Observacoes.Trim();

        popExistente.Referencias =
            popAtualizado.Referencias.Trim();

        popExistente.Materiais =
            popAtualizado.Materiais;

        popExistente.Etapas =
            popAtualizado.Etapas;

        popExistente.CriadoAPartirDeModelo =
            popAtualizado.CriadoAPartirDeModelo;

        popExistente.ModeloOrigemId =
            popAtualizado.ModeloOrigemId;

        popExistente.DataAtualizacao =
            DateTime.Now;


        PrepararMateriais(
            popExistente);

        PrepararEtapas(
            popExistente);

        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var pop =
            _pops.FirstOrDefault(
                x =>
                    x.Id == id);

        if (pop is null)
        {
            return false;
        }


        _pops.Remove(
            pop);

        return true;
    }


    // =========================================================
    // INDICADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                instituicaoId);
    }


    public int ContarVigentes(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusPop.Vigente);
    }


    public int ContarEmRevisao(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusPop.EmRevisao);
    }


    public int ContarRascunhos(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusPop.Rascunho);
    }


    public int ContarRevisoesProximas(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusPop.Vigente &&
                x.RevisaoProxima);
    }


    public int ContarRevisoesVencidas(
        int instituicaoId)
    {
        return _pops.Count(
            x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao !=
                    StatusPop.Inativo &&
                x.RevisaoVencida);
    }


    // =========================================================
    // PRÓXIMA REVISÃO
    // =========================================================

    public Pop? ObterProximaRevisao(
        int instituicaoId)
    {
        var hoje =
            DateTime.Today;

        return _pops
            .Where(x =>
                x.InstituicaoId ==
                    instituicaoId &&
                x.Situacao ==
                    StatusPop.Vigente &&
                x.DataProximaRevisao.HasValue &&
                x.DataProximaRevisao.Value.Date >=
                    hoje)
            .OrderBy(x =>
                x.DataProximaRevisao)
            .FirstOrDefault();
    }


    // =========================================================
    // GERAR CÓDIGO
    // =========================================================

    public string GerarProximoCodigo(
        int instituicaoId)
    {
        var quantidade =
            _pops.Count(
                x =>
                    x.InstituicaoId ==
                    instituicaoId);

        var numero =
            quantidade + 1;

        return $"POP {numero:00}";
    }


    // =========================================================
    // PREPARAR DADOS
    // =========================================================

    private void PrepararDados(
        Pop pop)
    {
        pop.Codigo =
            pop.Codigo.Trim();

        pop.Titulo =
            pop.Titulo.Trim();

        pop.Versao =
            pop.Versao.Trim();

        pop.ElaboradoPor =
            pop.ElaboradoPor.Trim();

        pop.AprovadoPor =
            pop.AprovadoPor.Trim();

        pop.Objetivo =
            pop.Objetivo.Trim();

        pop.CampoAplicacao =
            pop.CampoAplicacao.Trim();

        pop.Responsabilidades =
            pop.Responsabilidades.Trim();

        pop.Frequencia =
            pop.Frequencia.Trim();

        pop.Monitoramento =
            pop.Monitoramento.Trim();

        pop.Registros =
            pop.Registros.Trim();

        pop.AcoesCorretivas =
            pop.AcoesCorretivas.Trim();

        pop.Observacoes =
            pop.Observacoes.Trim();

        pop.Referencias =
            pop.Referencias.Trim();
    }


    // =========================================================
    // PREPARAR MATERIAIS
    // =========================================================

    private void PrepararMateriais(
        Pop pop)
    {
        foreach (
            var material in pop.Materiais)
        {
            if (material.Id == 0)
            {
                material.Id =
                    _proximoMaterialId++;
            }

            material.Descricao =
                material.Descricao.Trim();
        }
    }


    // =========================================================
    // PREPARAR ETAPAS
    // =========================================================

    private void PrepararEtapas(
        Pop pop)
    {
        var ordem =
            1;

        foreach (
            var etapa in pop.Etapas)
        {
            if (etapa.Id == 0)
            {
                etapa.Id =
                    _proximoEtapaId++;
            }

            etapa.Ordem =
                ordem++;

            etapa.Descricao =
                etapa.Descricao.Trim();
        }
    }
}