using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class FichaTecnicaService
{
    private readonly List<FichaTecnica> _fichas = new();

    private int _proximoId = 1;

    private int _proximoIngredienteId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public FichaTecnicaService()
    {
        CriarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CriarDadosDemonstracao()
    {
        if (_fichas.Any())
        {
            return;
        }


        // =====================================================
        // 1 - ARROZ BRANCO
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Arroz branco",

                Categoria =
                    CategoriaFichaTecnica.Almoco,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    80,

                UnidadePesoPorcao =
                    "g",

                ModoPreparo =
                    "Selecionar e higienizar os utensílios. Refogar o alho no óleo, acrescentar o arroz e misturar. Adicionar água quente e cozinhar em fogo baixo até que os grãos estejam macios e a água tenha sido absorvida.",

                Observacoes =
                    "Preparação básica utilizada como acompanhamento das refeições principais.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Arroz",
                            Quantidade = 1,
                            UnidadeMedida = "kg"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Água",
                            Quantidade = 2,
                            UnidadeMedida = "L"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Óleo vegetal",
                            Quantidade = 30,
                            UnidadeMedida = "mL"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Alho",
                            Quantidade = 15,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Sal",
                            Quantidade = 10,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );


        // =====================================================
        // 2 - FEIJÃO CARIOCA
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Feijão carioca",

                Categoria =
                    CategoriaFichaTecnica.Almoco,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    80,

                UnidadePesoPorcao =
                    "g",

                ModoPreparo =
                    "Selecionar os grãos, retirando possíveis sujidades. Lavar em água corrente e realizar o remolho conforme rotina da unidade. Descartar a água do remolho, adicionar água limpa e cozinhar até os grãos ficarem macios. Temperar com alho e finalizar o cozimento.",

                Observacoes =
                    "Manter o alimento protegido após o preparo e observar o controle de tempo e temperatura até a distribuição.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Feijão carioca",
                            Quantidade = 800,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Água",
                            Quantidade = 2.5m,
                            UnidadeMedida = "L"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Alho",
                            Quantidade = 15,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Óleo vegetal",
                            Quantidade = 20,
                            UnidadeMedida = "mL"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Sal",
                            Quantidade = 8,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );


        // =====================================================
        // 3 - FRANGO ENSOPADO COM LEGUMES
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Frango ensopado com legumes",

                Categoria =
                    CategoriaFichaTecnica.Almoco,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    90,

                UnidadePesoPorcao =
                    "g",

                ModoPreparo =
                    "Higienizar os vegetais conforme procedimento da unidade. Cortar os ingredientes. Refogar o alho e a cebola, adicionar o frango e cozinhar adequadamente. Acrescentar tomate, cenoura e abobrinha e finalizar o cozimento até que todos os ingredientes estejam completamente cozidos.",

                Observacoes =
                    "Preparação sem adição de leite ou ovo, podendo ser utilizada no planejamento das refeições dos alunos com as restrições cadastradas, desde que os ingredientes utilizados sejam conferidos.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Peito de frango",
                            Quantidade = 1.8m,
                            UnidadeMedida = "kg"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Cenoura",
                            Quantidade = 400,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Abobrinha",
                            Quantidade = 400,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Tomate",
                            Quantidade = 300,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Cebola",
                            Quantidade = 150,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Alho",
                            Quantidade = 20,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Óleo vegetal",
                            Quantidade = 30,
                            UnidadeMedida = "mL"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Sal",
                            Quantidade = 12,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );


        // =====================================================
        // 4 - SOPA DE LEGUMES COM FRANGO
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Sopa de legumes com frango",

                Categoria =
                    CategoriaFichaTecnica.Jantar,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    200,

                UnidadePesoPorcao =
                    "g",

                ModoPreparo =
                    "Higienizar e cortar os vegetais. Cozinhar o frango e desfiar. Refogar os temperos, acrescentar os legumes, o frango e a água. Cozinhar até que os vegetais estejam macios e finalizar a preparação mantendo consistência adequada para o público infantil.",

                Observacoes =
                    "A consistência pode ser ajustada conforme a faixa etária das crianças atendidas.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Peito de frango",
                            Quantidade = 800,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Batata",
                            Quantidade = 600,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Cenoura",
                            Quantidade = 400,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Abóbora",
                            Quantidade = 500,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Cebola",
                            Quantidade = 120,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Alho",
                            Quantidade = 15,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Água",
                            Quantidade = 3,
                            UnidadeMedida = "L"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Sal",
                            Quantidade = 10,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );


        // =====================================================
        // 5 - BOLO DE BANANA
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Bolo de banana",

                Categoria =
                    CategoriaFichaTecnica.Lanche,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    50,

                UnidadePesoPorcao =
                    "g",

                ModoPreparo =
                    "Higienizar as bananas antes do descascamento. Amassar as bananas e misturar com os demais ingredientes até obter massa homogênea. Distribuir em forma higienizada e assar até atingir cocção completa.",

                Observacoes =
                    "Preparação padrão contém ovo e leite. Para alunos com alergia a ovo, APLV ou intolerância à lactose, utilizar preparação substituta previamente definida e devidamente identificada.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Banana",
                            Quantidade = 800,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Farinha de trigo",
                            Quantidade = 500,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Leite",
                            Quantidade = 400,
                            UnidadeMedida = "mL"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Ovo",
                            Quantidade = 4,
                            UnidadeMedida = "unidades"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Açúcar",
                            Quantidade = 200,
                            UnidadeMedida = "g"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Óleo vegetal",
                            Quantidade = 100,
                            UnidadeMedida = "mL"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Fermento químico",
                            Quantidade = 20,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );


        // =====================================================
        // 6 - VITAMINA DE BANANA COM AVEIA
        // =====================================================

        Adicionar(
            new FichaTecnica
            {
                InstituicaoId = 1,

                NomePreparacao =
                    "Vitamina de banana com aveia",

                Categoria =
                    CategoriaFichaTecnica.Bebida,

                Rendimento =
                    20,

                UnidadeRendimento =
                    "porções",

                PesoPorcao =
                    150,

                UnidadePesoPorcao =
                    "mL",

                ModoPreparo =
                    "Higienizar as bananas antes do descascamento. Adicionar o leite, as bananas e a aveia ao liquidificador higienizado. Bater até obter consistência homogênea e distribuir imediatamente conforme rotina da unidade.",

                Observacoes =
                    "Para alunos com intolerância à lactose, utilizar leite sem lactose. Para aluno com APLV, utilizar substituto previamente autorizado e adequado à dieta cadastrada.",

                Situacao =
                    StatusFichaTecnica.Ativa,

                Ingredientes =
                    new List<IngredienteFichaTecnica>
                    {
                        new IngredienteFichaTecnica
                        {
                            Nome = "Leite",
                            Quantidade = 2.5m,
                            UnidadeMedida = "L"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Banana",
                            Quantidade = 1,
                            UnidadeMedida = "kg"
                        },

                        new IngredienteFichaTecnica
                        {
                            Nome = "Aveia em flocos",
                            Quantidade = 200,
                            UnidadeMedida = "g"
                        }
                    }
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<FichaTecnica> ObterTodos()
    {
        return _fichas
            .OrderBy(x => x.NomePreparacao)
            .ToList();
    }


    public List<FichaTecnica> ObterPorInstituicao(
        int instituicaoId)
    {
        return _fichas
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .OrderBy(x =>
                x.NomePreparacao)
            .ToList();
    }


    public FichaTecnica? ObterPorId(
        int id)
    {
        return _fichas
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        FichaTecnica ficha)
    {
        ficha.Id =
            _proximoId++;

        ficha.DataCadastro =
            DateTime.Now;

        ficha.DataAtualizacao =
            null;

        ficha.NomePreparacao =
            ficha.NomePreparacao.Trim();

        ficha.UnidadeRendimento =
            ficha.UnidadeRendimento.Trim();

        ficha.UnidadePesoPorcao =
            ficha.UnidadePesoPorcao.Trim();

        ficha.ModoPreparo =
            ficha.ModoPreparo.Trim();

        ficha.Observacoes =
            ficha.Observacoes.Trim();

        PrepararIngredientes(
            ficha);

        _fichas.Add(
            ficha);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        FichaTecnica fichaAtualizada)
    {
        var fichaExistente =
            _fichas.FirstOrDefault(x =>
                x.Id == fichaAtualizada.Id);

        if (fichaExistente is null)
        {
            return false;
        }


        fichaExistente.InstituicaoId =
            fichaAtualizada.InstituicaoId;

        fichaExistente.NomePreparacao =
            fichaAtualizada.NomePreparacao.Trim();

        fichaExistente.Categoria =
            fichaAtualizada.Categoria;

        fichaExistente.Rendimento =
            fichaAtualizada.Rendimento;

        fichaExistente.UnidadeRendimento =
            fichaAtualizada.UnidadeRendimento.Trim();

        fichaExistente.PesoPorcao =
            fichaAtualizada.PesoPorcao;

        fichaExistente.UnidadePesoPorcao =
            fichaAtualizada.UnidadePesoPorcao.Trim();

        fichaExistente.ModoPreparo =
            fichaAtualizada.ModoPreparo.Trim();

        fichaExistente.Observacoes =
            fichaAtualizada.Observacoes.Trim();

        fichaExistente.Situacao =
            fichaAtualizada.Situacao;

        fichaExistente.Ingredientes =
            fichaAtualizada.Ingredientes;

        fichaExistente.DataAtualizacao =
            DateTime.Now;


        PrepararIngredientes(
            fichaExistente);

        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var ficha =
            _fichas.FirstOrDefault(x =>
                x.Id == id);

        if (ficha is null)
        {
            return false;
        }


        _fichas.Remove(
            ficha);

        return true;
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _fichas.Count(
            x =>
                x.InstituicaoId == instituicaoId
        );
    }


    public int ContarAtivas(
        int instituicaoId)
    {
        return _fichas.Count(
            x =>
                x.InstituicaoId == instituicaoId &&
                x.Situacao ==
                    StatusFichaTecnica.Ativa
        );
    }


    public int ContarInativas(
        int instituicaoId)
    {
        return _fichas.Count(
            x =>
                x.InstituicaoId == instituicaoId &&
                x.Situacao ==
                    StatusFichaTecnica.Inativa
        );
    }


    public int ContarCategorias(
        int instituicaoId)
    {
        return _fichas
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .Select(x =>
                x.Categoria)
            .Distinct()
            .Count();
    }


    // =========================================================
    // INGREDIENTES
    // =========================================================

    private void PrepararIngredientes(
        FichaTecnica ficha)
    {
        foreach (var ingrediente
                 in ficha.Ingredientes)
        {
            if (ingrediente.Id == 0)
            {
                ingrediente.Id =
                    _proximoIngredienteId++;
            }

            ingrediente.Nome =
                ingrediente.Nome.Trim();

            ingrediente.UnidadeMedida =
                ingrediente.UnidadeMedida.Trim();
        }
    }
}