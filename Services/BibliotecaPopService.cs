using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class BibliotecaPopService
{
    private readonly List<ModeloPop> _modelos;


    public BibliotecaPopService()
    {
        _modelos = CriarBiblioteca();
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<ModeloPop> ObterTodos()
    {
        return _modelos
            .OrderBy(x => x.Codigo)
            .ToList();
    }


    public ModeloPop? ObterPorId(
        int id)
    {
        return _modelos
            .FirstOrDefault(
                x => x.Id == id);
    }


    public List<ModeloPop> ObterPorCategoria(
        CategoriaPop categoria)
    {
        return _modelos
            .Where(x =>
                x.Categoria == categoria)
            .OrderBy(x => x.Titulo)
            .ToList();
    }


    // =========================================================
    // TRANSFORMAR MODELO EM POP DA INSTITUIÇÃO
    // =========================================================

    public Pop CriarAPartirDoModelo(
        int modeloId,
        int instituicaoId)
    {
        var modelo =
            ObterPorId(modeloId);

        if (modelo is null)
        {
            throw new InvalidOperationException(
                "Modelo de POP não encontrado.");
        }


        var pop = new Pop
        {
            InstituicaoId =
                instituicaoId,

            Codigo =
                modelo.Codigo,

            Titulo =
                modelo.Titulo,

            Categoria =
                modelo.Categoria,

            Versao =
                "1.0",

            DataElaboracao =
                DateTime.Today,

            Situacao =
                StatusPop.Rascunho,

            Objetivo =
                modelo.Objetivo,

            CampoAplicacao =
                modelo.CampoAplicacao,

            Responsabilidades =
                modelo.Responsabilidades,

            Frequencia =
                modelo.Frequencia,

            Monitoramento =
                modelo.Monitoramento,

            Registros =
                modelo.Registros,

            AcoesCorretivas =
                modelo.AcoesCorretivas,

            Observacoes =
                modelo.Observacoes,

            Referencias =
                modelo.Referencias,

            CriadoAPartirDeModelo =
                true,

            ModeloOrigemId =
                modelo.Id
        };


        foreach (
            var material in modelo.Materiais)
        {
            pop.Materiais.Add(
                new MaterialPop
                {
                    Descricao =
                        material
                });
        }


        var ordem = 1;

        foreach (
            var etapa in modelo.Etapas)
        {
            pop.Etapas.Add(
                new EtapaPop
                {
                    Ordem =
                        ordem++,

                    Descricao =
                        etapa
                });
        }


        return pop;
    }


    // =========================================================
    // BIBLIOTECA
    // =========================================================

    private static List<ModeloPop>
        CriarBiblioteca()
    {
        return new List<ModeloPop>
        {

            // =================================================
            // POP 01
            // =================================================

            new()
            {
                Id = 1,

                Codigo = "POP 01",

                Titulo =
                    "Higienização das mãos",

                Categoria =
                    CategoriaPop.HigieneManipuladores,

                Descricao =
                    "Modelo para padronização da higienização das mãos dos manipuladores de alimentos.",

                Objetivo =
                    "Padronizar o procedimento de higienização das mãos, contribuindo para a prevenção da contaminação dos alimentos durante as etapas de manipulação.",

                CampoAplicacao =
                    "Aplica-se aos manipuladores de alimentos e demais profissionais que tenham contato com alimentos, utensílios, equipamentos e superfícies da área de produção.",

                Responsabilidades =
                    "Os manipuladores são responsáveis pela execução correta do procedimento. O responsável técnico e/ou profissional designado deve orientar, acompanhar e verificar o cumprimento das práticas estabelecidas.",

                Frequencia =
                    "Antes de iniciar as atividades, após utilizar o sanitário, após manipular resíduos, após tocar superfícies potencialmente contaminadas, após interrupções do trabalho e sempre que necessário.",

                Monitoramento =
                    "Observação periódica da técnica de higienização das mãos e das condições dos lavatórios destinados aos manipuladores.",

                Registros =
                    "Registrar treinamentos, orientações e eventuais não conformidades identificadas durante o acompanhamento.",

                AcoesCorretivas =
                    "Orientar imediatamente o manipulador quando o procedimento não estiver sendo realizado corretamente e corrigir indisponibilidade de insumos ou inadequações identificadas.",

                Observacoes =
                    "O procedimento deve ser adaptado às condições e à estrutura da instituição.",

                Materiais = new()
                {
                    "Água corrente",
                    "Sabonete líquido apropriado",
                    "Papel-toalha descartável",
                    "Lixeira adequada"
                },

                Etapas = new()
                {
                    "Retirar adornos das mãos e dos braços quando aplicável.",
                    "Molhar as mãos em água corrente.",
                    "Aplicar sabonete líquido.",
                    "Friccionar palmas, dorsos, espaços entre os dedos, polegares, unhas e punhos.",
                    "Enxaguar completamente em água corrente.",
                    "Secar as mãos com papel-toalha descartável.",
                    "Descartar o papel utilizado de forma adequada."
                }
            },


            // =================================================
            // POP 02
            // =================================================

            new()
            {
                Id = 2,

                Codigo = "POP 02",

                Titulo =
                    "Higienização de frutas, verduras e legumes",

                Categoria =
                    CategoriaPop.HigienizacaoAlimentos,

                Descricao =
                    "Modelo para padronização da higienização de hortifrutícolas utilizados nas refeições.",

                Objetivo =
                    "Padronizar a seleção, lavagem e higienização de frutas, verduras e legumes, reduzindo riscos de contaminação.",

                CampoAplicacao =
                    "Área de pré-preparo e preparo de alimentos da instituição.",

                Responsabilidades =
                    "Os manipuladores responsáveis pelo pré-preparo devem executar o procedimento conforme orientação do responsável técnico.",

                Frequencia =
                    "Sempre que houver preparo ou oferta de frutas, verduras e legumes que necessitem higienização.",

                Monitoramento =
                    "Verificar visualmente a seleção, lavagem, higienização e condições dos produtos utilizados.",

                Registros =
                    "Registrar intercorrências e não conformidades quando identificadas.",

                AcoesCorretivas =
                    "Repetir o procedimento quando realizado inadequadamente e descartar produtos que apresentem condições impróprias para utilização.",

                Observacoes =
                    "O produto utilizado, sua concentração e o tempo de contato devem seguir a orientação do fabricante e os procedimentos definidos pelo responsável técnico.",

                Materiais = new()
                {
                    "Água potável",
                    "Recipiente higienizado",
                    "Produto regularizado indicado para higienização de alimentos",
                    "Utensílios higienizados"
                },

                Etapas = new()
                {
                    "Selecionar os alimentos e retirar partes deterioradas ou impróprias.",
                    "Realizar lavagem em água potável para remoção de sujidades.",
                    "Preparar a solução de higienização conforme orientação do produto utilizado.",
                    "Manter os alimentos em contato com a solução pelo período indicado.",
                    "Realizar o procedimento de enxágue quando indicado para o produto utilizado.",
                    "Manter os alimentos protegidos até sua utilização."
                }
            },


            // =================================================
            // POP 03
            // =================================================

            new()
            {
                Id = 3,

                Codigo = "POP 03",

                Titulo =
                    "Higienização de instalações, equipamentos, móveis e utensílios",

                Categoria =
                    CategoriaPop.HigienizacaoAmbiente,

                Descricao =
                    "Modelo para organização dos procedimentos de limpeza e higienização da unidade de alimentação.",

                Objetivo =
                    "Padronizar a higienização das instalações, equipamentos, móveis e utensílios utilizados no serviço de alimentação.",

                CampoAplicacao =
                    "Cozinha, estoque, área de distribuição, equipamentos, bancadas, móveis e utensílios utilizados na produção das refeições.",

                Responsabilidades =
                    "Os profissionais designados para limpeza e manipulação devem executar as atividades conforme definição da instituição e supervisão do responsável.",

                Frequencia =
                    "De acordo com o tipo de superfície, equipamento ou utensílio e sempre que houver necessidade de higienização.",

                Monitoramento =
                    "Inspeção visual das condições de limpeza e acompanhamento do cumprimento da rotina estabelecida.",

                Registros =
                    "Utilizar planilhas ou registros de higienização quando definidos pela instituição.",

                AcoesCorretivas =
                    "Realizar nova higienização quando forem identificadas sujidades, resíduos ou execução inadequada do procedimento.",

                Observacoes =
                    "Equipamentos devem ser higienizados respeitando as orientações de segurança e as recomendações de seus fabricantes.",

                Materiais = new()
                {
                    "Água potável",
                    "Detergente apropriado",
                    "Produto saneante regularizado",
                    "Esponjas, panos ou materiais definidos para cada finalidade",
                    "Equipamentos de proteção quando necessários"
                },

                Etapas = new()
                {
                    "Retirar resíduos e sujidades visíveis.",
                    "Desmontar equipamentos quando aplicável e permitido pelo fabricante.",
                    "Realizar a limpeza utilizando produto apropriado.",
                    "Enxaguar quando necessário.",
                    "Aplicar o procedimento de sanitização quando indicado.",
                    "Aguardar o tempo necessário de ação do produto utilizado.",
                    "Finalizar o procedimento e manter os itens protegidos contra nova contaminação."
                }
            },


            // =================================================
            // POP 04
            // =================================================

            new()
            {
                Id = 4,

                Codigo = "POP 04",

                Titulo =
                    "Controle da potabilidade da água",

                Categoria =
                    CategoriaPop.Agua,

                Descricao =
                    "Modelo para acompanhamento da qualidade da água utilizada na instituição.",

                Objetivo =
                    "Estabelecer procedimentos para acompanhamento das condições da água utilizada no preparo de alimentos, higienização e consumo.",

                CampoAplicacao =
                    "Pontos de utilização de água relacionados ao serviço de alimentação.",

                Responsabilidades =
                    "A instituição deve garantir condições adequadas de abastecimento. O responsável técnico acompanha os registros e orienta as medidas relacionadas ao serviço de alimentação.",

                Frequencia =
                    "Conforme planejamento da instituição, características do abastecimento e controles aplicáveis.",

                Monitoramento =
                    "Acompanhar condições do abastecimento, reservatórios, registros de higienização e documentos relacionados à qualidade da água.",

                Registros =
                    "Manter registros de higienização dos reservatórios e documentos ou resultados de controle quando aplicáveis.",

                AcoesCorretivas =
                    "Investigar alterações identificadas, comunicar os responsáveis e impedir a utilização da água para fins alimentares quando houver indicação de risco até que a situação seja regularizada.",

                Observacoes =
                    "Os controles específicos devem considerar a origem da água e as exigências aplicáveis à instituição.",

                Materiais = new()
                {
                    "Registros de controle",
                    "Documentação referente ao abastecimento",
                    "Materiais necessários para verificações definidas pela instituição"
                },

                Etapas = new()
                {
                    "Identificar a origem do abastecimento de água.",
                    "Verificar as condições dos reservatórios e pontos relacionados ao serviço de alimentação.",
                    "Acompanhar a higienização periódica dos reservatórios.",
                    "Verificar documentos e controles disponíveis.",
                    "Registrar não conformidades identificadas.",
                    "Adotar as medidas corretivas necessárias."
                }
            },


            // =================================================
            // POP 05
            // =================================================

            new()
            {
                Id = 5,

                Codigo = "POP 05",

                Titulo =
                    "Manejo de resíduos",

                Categoria =
                    CategoriaPop.Residuos,

                Descricao =
                    "Modelo para padronização do acondicionamento, retirada e destinação interna dos resíduos.",

                Objetivo =
                    "Organizar o manejo de resíduos de forma a reduzir riscos de contaminação das áreas de manipulação de alimentos.",

                CampoAplicacao =
                    "Áreas de recebimento, armazenamento, preparo, distribuição e demais locais relacionados ao serviço de alimentação.",

                Responsabilidades =
                    "Os profissionais designados devem realizar o acondicionamento e a retirada dos resíduos de acordo com a rotina da instituição.",

                Frequencia =
                    "Durante as atividades e sempre que os recipientes necessitarem esvaziamento.",

                Monitoramento =
                    "Verificar limpeza, integridade, fechamento e localização dos recipientes destinados aos resíduos.",

                Registros =
                    "Registrar situações de não conformidade quando necessário.",

                AcoesCorretivas =
                    "Realizar retirada imediata quando houver acúmulo, higienizar recipientes e áreas afetadas e substituir recipientes inadequados ou danificados.",

                Observacoes =
                    "O fluxo de retirada deve evitar contaminação das áreas de preparo e dos alimentos.",

                Materiais = new()
                {
                    "Recipientes adequados para resíduos",
                    "Sacos apropriados",
                    "Materiais para higienização",
                    "Equipamentos de proteção quando necessários"
                },

                Etapas = new()
                {
                    "Acondicionar os resíduos nos recipientes destinados para essa finalidade.",
                    "Evitar acúmulo excessivo nos recipientes.",
                    "Retirar os resíduos seguindo o fluxo estabelecido pela instituição.",
                    "Evitar contato dos resíduos com alimentos, utensílios e superfícies limpas.",
                    "Higienizar os recipientes conforme a rotina estabelecida.",
                    "Manter a área destinada aos resíduos limpa e organizada."
                }
            },


            // =================================================
            // POP 06
            // =================================================

            new()
            {
                Id = 6,

                Codigo = "POP 06",

                Titulo =
                    "Controle integrado de vetores e pragas",

                Categoria =
                    CategoriaPop.Pragas,

                Descricao =
                    "Modelo para prevenção, identificação e controle de vetores e pragas nas áreas relacionadas à alimentação.",

                Objetivo =
                    "Estabelecer medidas preventivas e corretivas para minimizar a presença de vetores e pragas na unidade.",

                CampoAplicacao =
                    "Áreas internas e externas relacionadas ao recebimento, armazenamento, preparo e distribuição dos alimentos.",

                Responsabilidades =
                    "Todos os profissionais devem comunicar sinais de infestação. A instituição é responsável pelas medidas estruturais e pela contratação de serviço especializado quando necessário.",

                Frequencia =
                    "Monitoramento contínuo e ações de controle conforme necessidade e planejamento da instituição.",

                Monitoramento =
                    "Observar sinais de presença de pragas, condições estruturais, portas, janelas, ralos, áreas de armazenamento e possíveis pontos de acesso.",

                Registros =
                    "Manter registros das ocorrências, ações corretivas e documentação de serviços especializados quando realizados.",

                AcoesCorretivas =
                    "Eliminar fontes de alimento e abrigo, corrigir falhas estruturais, reforçar higienização e solicitar controle especializado quando necessário.",

                Observacoes =
                    "Produtos químicos para controle de pragas não devem ser aplicados de forma que possam contaminar alimentos, utensílios ou superfícies.",

                Materiais = new()
                {
                    "Formulários ou registros de inspeção",
                    "Barreiras físicas existentes",
                    "Documentação do serviço especializado quando aplicável"
                },

                Etapas = new()
                {
                    "Inspecionar periodicamente as áreas relacionadas ao serviço de alimentação.",
                    "Identificar possíveis sinais de vetores ou pragas.",
                    "Verificar possíveis pontos de acesso e abrigo.",
                    "Corrigir condições que favoreçam a presença de pragas.",
                    "Acionar serviço especializado quando necessário.",
                    "Registrar as medidas realizadas."
                }
            },


            // =================================================
            // POP 07
            // =================================================

            new()
            {
                Id = 7,

                Codigo = "POP 07",

                Titulo =
                    "Higiene e saúde dos manipuladores",

                Categoria =
                    CategoriaPop.HigieneManipuladores,

                Descricao =
                    "Modelo para organização das práticas de higiene pessoal e cuidados relacionados aos manipuladores.",

                Objetivo =
                    "Estabelecer práticas de higiene e conduta que contribuam para a manipulação segura dos alimentos.",

                CampoAplicacao =
                    "Todos os profissionais que atuam direta ou indiretamente na manipulação de alimentos.",

                Responsabilidades =
                    "Os manipuladores devem cumprir as práticas estabelecidas. O responsável técnico deve orientar e acompanhar as condições relacionadas às boas práticas.",

                Frequencia =
                    "Durante todo o período de trabalho e sempre que houver manipulação de alimentos.",

                Monitoramento =
                    "Observação das condições de higiene pessoal, uniformização, condutas durante a manipulação e comunicação de situações que possam comprometer a segurança dos alimentos.",

                Registros =
                    "Registrar capacitações, orientações e ocorrências relevantes.",

                AcoesCorretivas =
                    "Orientar o profissional e corrigir imediatamente condutas inadequadas. Situações de saúde que possam comprometer a segurança dos alimentos devem ser avaliadas conforme os procedimentos da instituição.",

                Observacoes =
                    "As regras devem ser compatíveis com as atividades executadas e com as orientações do responsável técnico.",

                Materiais = new()
                {
                    "Uniforme adequado",
                    "Itens de higiene pessoal",
                    "Equipamentos de proteção quando aplicáveis"
                },

                Etapas = new()
                {
                    "Apresentar-se com uniforme limpo e adequado à atividade.",
                    "Manter cabelos protegidos conforme a atividade.",
                    "Manter unhas limpas e em condições adequadas.",
                    "Evitar adornos durante a manipulação.",
                    "Higienizar corretamente as mãos.",
                    "Evitar condutas que possam contaminar os alimentos.",
                    "Comunicar situações de saúde relevantes ao responsável."
                }
            },


            // =================================================
            // POP 08
            // =================================================

            new()
            {
                Id = 8,

                Codigo = "POP 08",

                Titulo =
                    "Recebimento de gêneros alimentícios",

                Categoria =
                    CategoriaPop.Recebimento,

                Descricao =
                    "Modelo para padronização da conferência dos alimentos no momento do recebimento.",

                Objetivo =
                    "Estabelecer critérios para conferência e recebimento dos gêneros alimentícios utilizados pela instituição.",

                CampoAplicacao =
                    "Área destinada ao recebimento de alimentos e produtos relacionados ao serviço de alimentação.",

                Responsabilidades =
                    "O profissional responsável pelo recebimento deve realizar as verificações previstas e comunicar irregularidades.",

                Frequencia =
                    "Em todos os recebimentos de gêneros alimentícios.",

                Monitoramento =
                    "Verificar condições de transporte, embalagem, identificação, validade, integridade e demais características relevantes dos produtos.",

                Registros =
                    "Registrar recebimentos e não conformidades conforme os controles adotados pela instituição.",

                AcoesCorretivas =
                    "Recusar ou segregar produtos que apresentem condições inadequadas e comunicar o fornecedor ou responsável pela aquisição.",

                Observacoes =
                    "Os critérios de recebimento devem ser adaptados aos tipos de alimentos adquiridos pela instituição.",

                Materiais = new()
                {
                    "Registro de recebimento",
                    "Termômetro quando aplicável",
                    "Caneta ou dispositivo para registro"
                },

                Etapas = new()
                {
                    "Conferir o fornecedor e os produtos entregues.",
                    "Avaliar as condições gerais do transporte.",
                    "Verificar integridade das embalagens.",
                    "Conferir identificação e prazo de validade.",
                    "Verificar temperatura quando aplicável.",
                    "Separar produtos não conformes.",
                    "Registrar o recebimento.",
                    "Encaminhar os produtos para armazenamento adequado."
                }
            },


            // =================================================
            // POP 09
            // =================================================

            new()
            {
                Id = 9,

                Codigo = "POP 09",

                Titulo =
                    "Armazenamento de alimentos",

                Categoria =
                    CategoriaPop.Armazenamento,

                Descricao =
                    "Modelo para organização e conservação dos gêneros alimentícios armazenados.",

                Objetivo =
                    "Padronizar o armazenamento dos alimentos visando preservar sua qualidade e reduzir riscos de contaminação.",

                CampoAplicacao =
                    "Estoque seco, refrigeradores, congeladores e demais locais utilizados para armazenamento de alimentos.",

                Responsabilidades =
                    "Os profissionais responsáveis pelo estoque e pela produção devem manter os produtos organizados e armazenados conforme suas características.",

                Frequencia =
                    "Continuamente durante o armazenamento e sempre que houver entrada, retirada ou reorganização de produtos.",

                Monitoramento =
                    "Verificar organização, validade, integridade das embalagens, identificação e condições de armazenamento.",

                Registros =
                    "Utilizar controles de estoque, validade e temperatura quando adotados pela instituição.",

                AcoesCorretivas =
                    "Reorganizar produtos armazenados inadequadamente, identificar produtos abertos e separar itens vencidos ou impróprios.",

                Observacoes =
                    "Produtos devem ser armazenados de forma a permitir organização, limpeza e circulação adequada.",

                Materiais = new()
                {
                    "Prateleiras ou estruturas adequadas",
                    "Etiquetas de identificação",
                    "Recipientes apropriados",
                    "Controles de estoque quando aplicáveis"
                },

                Etapas = new()
                {
                    "Receber os produtos previamente conferidos.",
                    "Separar os alimentos conforme suas condições de conservação.",
                    "Organizar os produtos de forma a facilitar o controle de validade.",
                    "Identificar adequadamente produtos abertos ou fracionados.",
                    "Manter alimentos protegidos e afastados de fontes de contaminação.",
                    "Verificar periodicamente validade e integridade dos produtos."
                }
            },


            // =================================================
            // POP 10
            // =================================================

            new()
            {
                Id = 10,

                Codigo = "POP 10",

                Titulo =
                    "Controle de temperatura",

                Categoria =
                    CategoriaPop.ControleTemperatura,

                Descricao =
                    "Modelo para acompanhamento das temperaturas relacionadas ao armazenamento, preparo e distribuição de alimentos.",

                Objetivo =
                    "Organizar o controle de temperatura nos processos em que esse acompanhamento seja necessário.",

                CampoAplicacao =
                    "Equipamentos de conservação e etapas de produção e distribuição definidas pela instituição.",

                Responsabilidades =
                    "Os profissionais designados devem realizar as verificações e registros. O responsável técnico acompanha os resultados e orienta medidas corretivas.",

                Frequencia =
                    "Conforme os pontos de controle e horários estabelecidos pela instituição.",

                Monitoramento =
                    "Realizar medições nos equipamentos, alimentos ou etapas definidas no plano de controle da unidade.",

                Registros =
                    "Registrar as temperaturas verificadas em formulário ou sistema próprio.",

                AcoesCorretivas =
                    "Investigar resultados inadequados, verificar funcionamento de equipamentos, condições dos alimentos e adotar as medidas necessárias conforme avaliação do responsável.",

                Observacoes =
                    "Os limites e critérios adotados devem ser definidos conforme o tipo de alimento, processo e requisitos aplicáveis.",

                Materiais = new()
                {
                    "Termômetro apropriado",
                    "Planilha ou sistema de registro",
                    "Material para higienização do instrumento quando aplicável"
                },

                Etapas = new()
                {
                    "Verificar se o instrumento está em condições adequadas de uso.",
                    "Realizar a medição no ponto definido.",
                    "Aguardar estabilização da leitura quando necessário.",
                    "Registrar o resultado obtido.",
                    "Comparar o resultado com o critério definido pela instituição.",
                    "Adotar ação corretiva quando houver resultado inadequado.",
                    "Higienizar e armazenar o instrumento adequadamente."
                }
            },


            // =================================================
            // POP 11
            // =================================================

            new()
            {
                Id = 11,

                Codigo = "POP 11",

                Titulo =
                    "Coleta e armazenamento de amostras",

                Categoria =
                    CategoriaPop.Amostras,

                Descricao =
                    "Modelo para padronização da coleta, identificação e armazenamento de amostras de preparações quando esse controle for adotado.",

                Objetivo =
                    "Padronizar a coleta e o armazenamento de amostras das preparações servidas pela instituição quando previsto em seu controle.",

                CampoAplicacao =
                    "Preparações produzidas e distribuídas pelo serviço de alimentação para as quais esteja definida coleta de amostra.",

                Responsabilidades =
                    "O profissional designado deve realizar a coleta, identificação e armazenamento conforme o procedimento definido pela instituição.",

                Frequencia =
                    "Nos dias e refeições em que houver previsão de coleta de amostras.",

                Monitoramento =
                    "Verificar identificação, acondicionamento, armazenamento e descarte das amostras.",

                Registros =
                    "Registrar as informações necessárias para identificação das amostras coletadas.",

                AcoesCorretivas =
                    "Corrigir imediatamente falhas de identificação ou acondicionamento quando possível e registrar ocorrências que comprometam a amostra.",

                Observacoes =
                    "Quantidade, período e condições de armazenamento devem seguir os critérios definidos pelo responsável técnico e requisitos aplicáveis à instituição.",

                Materiais = new()
                {
                    "Recipientes ou embalagens apropriadas",
                    "Etiquetas de identificação",
                    "Utensílio higienizado para coleta",
                    "Equipamento de conservação adequado"
                },

                Etapas = new()
                {
                    "Separar os materiais necessários para a coleta.",
                    "Identificar previamente o recipiente da amostra.",
                    "Realizar a coleta utilizando utensílio higienizado.",
                    "Fechar corretamente o recipiente.",
                    "Registrar as informações necessárias.",
                    "Armazenar a amostra nas condições estabelecidas.",
                    "Descartar a amostra após o período definido."
                }
            },


            // =================================================
            // POP 12
            // =================================================

            new()
            {
                Id = 12,

                Codigo = "POP 12",

                Titulo =
                    "Uso e diluição de produtos saneantes",

                Categoria =
                    CategoriaPop.ProdutosSaneantes,

                Descricao =
                    "Modelo para utilização segura e padronizada dos produtos empregados na limpeza e higienização.",

                Objetivo =
                    "Padronizar o armazenamento, preparo e utilização dos produtos saneantes empregados no serviço de alimentação.",

                CampoAplicacao =
                    "Áreas de armazenamento de produtos de limpeza e locais onde esses produtos são utilizados.",

                Responsabilidades =
                    "Os profissionais responsáveis pela limpeza devem seguir as orientações dos produtos utilizados e as instruções estabelecidas pela instituição.",

                Frequencia =
                    "Sempre que houver preparo ou utilização de produtos saneantes.",

                Monitoramento =
                    "Verificar identificação, armazenamento, condições das embalagens e utilização adequada dos produtos.",

                Registros =
                    "Registrar orientações, treinamentos e ocorrências quando necessário.",

                AcoesCorretivas =
                    "Descartar soluções preparadas incorretamente quando necessário, refazer a diluição conforme orientação e corrigir armazenamento ou identificação inadequados.",

                Observacoes =
                    "As instruções do fabricante devem ser observadas quanto à finalidade, diluição, tempo de contato e cuidados de segurança.",

                Materiais = new()
                {
                    "Produto saneante regularizado",
                    "Recipiente apropriado quando necessário",
                    "Medidor ou dosador quando indicado",
                    "Equipamentos de proteção conforme necessidade"
                },

                Etapas = new()
                {
                    "Conferir a identificação do produto a ser utilizado.",
                    "Ler as orientações de uso e diluição.",
                    "Utilizar os equipamentos de proteção necessários.",
                    "Preparar a solução na concentração indicada.",
                    "Identificar recipientes preparados quando aplicável.",
                    "Utilizar o produto somente para a finalidade indicada.",
                    "Armazenar o produto adequadamente após o uso."
                }
            }
        };
    }
}