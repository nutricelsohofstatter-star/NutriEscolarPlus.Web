using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class CardapioService
{
    private readonly List<Cardapio> _cardapios =
        new();

    private int _proximoId =
        1;

    private int _proximoItemId =
        1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public CardapioService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_cardapios.Any())
        {
            return;
        }


        var cardapio =
            new Cardapio
            {
                Id = _proximoId++,

                InstituicaoId = 1,

                InstituicaoNome =
                    "Escola Girassol",

                Mes = 10,

                Ano = 2026,

                Status =
                    StatusCardapio.Finalizado,

                DataCriacao =
                    new DateTime(
                        2026,
                        9,
                        25,
                        14,
                        30,
                        0
                    ),

                DataAtualizacao =
                    new DateTime(
                        2026,
                        9,
                        28,
                        16,
                        0,
                        0
                    ),

                DataFinalizacao =
                    new DateTime(
                        2026,
                        9,
                        28,
                        16,
                        0,
                        0
                    ),

                Observacoes =
                    "Produzir utilizando o mínimo possível de açúcar, gordura e sal. Não utilizar temperos industrializados, somente naturais. Não oferecer açúcar ao N1A e B.",

                Itens =
                    new List<ItemCardapio>()
            };


        // =====================================================
        // SEMANA 1 - 01 E 02 DE OUTUBRO
        // =====================================================

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 1),
            "Lanche da manhã",
            "Pão puro com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 1),
            "Almoço",
            "Arroz e feijão\nFrango ao molho\nPurê de batata\nSalada de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 1),
            "Lanche da tarde 1",
            "Fruta\nBolo de banana"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 1),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 2),
            "Lanche da manhã",
            "Pão puro com requeijão\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 2),
            "Almoço",
            "Arroz e feijão\nCarne moída com legumes\nSalada de cenoura e repolho"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 2),
            "Lanche da tarde 1",
            "Fruta\nBolo de laranja"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 2),
            "Lanche da tarde 2",
            "Biscoito de polvilho"
        );


        // =====================================================
        // SEMANA 2 - 05 A 09 DE OUTUBRO
        // =====================================================

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 5),
            "Lanche da manhã",
            "Pão puro\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 5),
            "Almoço",
            "Arroz e feijão\nBatata cozida\nCarne suína com molho\nSalada de chuchu e cenoura cozidos"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 5),
            "Lanche da tarde 1",
            "Fruta\nLanche da casa"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 5),
            "Lanche da tarde 2",
            "Lanche da casa"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 6),
            "Lanche da manhã",
            "Pão puro com creme de ricota\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 6),
            "Almoço",
            "Arroz e feijão\nAipim cozido\nMolho de carne moída\nSalada de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 6),
            "Lanche da tarde 1",
            "Fruta\nPão de queijo"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 6),
            "Lanche da tarde 2",
            "Cookie de aveia e banana"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 7),
            "Lanche da manhã",
            "Pão puro com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 7),
            "Almoço",
            "Arroz e feijão\nPurê de batata\nFrango ao molho\nSalada de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 7),
            "Lanche da tarde 1",
            "Fruta\nCupcake de cenoura"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 7),
            "Lanche da tarde 2",
            "Biscoito de polvilho"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 8),
            "Lanche da manhã",
            "Pão puro com requeijão\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 8),
            "Almoço",
            "Arroz e lentilha com carne e legumes\nSalada de beterraba e couve-flor"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 8),
            "Lanche da tarde 1",
            "Fruta\nBolo de maçã"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 8),
            "Lanche da tarde 2",
            "Pão puro com geleia caseira sem açúcar"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 9),
            "Lanche da manhã",
            "Pão puro com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 9),
            "Almoço",
            "Carreteiro e feijão\nSalada de tomate e chuchu"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 9),
            "Lanche da tarde 1",
            "Fruta\nBolo de laranja"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 9),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        // =====================================================
        // SEMANA 3 - 13 A 16 DE OUTUBRO
        // =====================================================

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 13),
            "Lanche da manhã",
            "Pão puro com requeijão\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 13),
            "Almoço",
            "Arroz e feijão\nFrango ao molho\nAipim cozido\nSalada de cenoura e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 13),
            "Lanche da tarde 1",
            "Fruta\nBolo de banana"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 13),
            "Lanche da tarde 2",
            "Cookie de banana com aveia"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 14),
            "Lanche da manhã",
            "Pão puro com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 14),
            "Almoço",
            "Arroz e feijão\nCarne bovina ao molho\nPurê de batata\nSalada de tomate e brócolis"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 14),
            "Lanche da tarde 1",
            "Fruta\nCupcake de cenoura"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 14),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 15),
            "Lanche da manhã",
            "Pão puro\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 15),
            "Almoço",
            "Arroz e lentilha com carne e legumes\nSalada de beterraba e couve-flor"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 15),
            "Lanche da tarde 1",
            "Fruta\nPão de queijo"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 15),
            "Lanche da tarde 2",
            "Biscoito de polvilho"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 16),
            "Lanche da manhã",
            "Pão puro com creme de ricota\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 16),
            "Almoço",
            "Galinhada e feijão\nSalada de tomate e brócolis"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 16),
            "Lanche da tarde 1",
            "Fruta\nBolo de cacau"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 16),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        // =====================================================
        // SEMANA 4 - 19 A 23 DE OUTUBRO
        // MODELO PRINCIPAL DA REFERÊNCIA
        // =====================================================

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 19),
            "Lanche da manhã",
            "Pão puro\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 19),
            "Almoço",
            "Arroz e feijão\nBatata cozida\nCarne suína com molho\nSaladas de chuchu e cenoura cozidos"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 19),
            "Lanche da tarde 1",
            "Fruta\nLanche de casa"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 19),
            "Lanche da tarde 2",
            "Lanche de casa"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 20),
            "Lanche da manhã",
            "Pão puro e com creme de ricota\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 20),
            "Almoço",
            "Arroz e feijão\nAipim cozido\nMolho de carne moída\nSaladas de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 20),
            "Lanche da tarde 1",
            "Fruta\nPão de queijo"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 20),
            "Lanche da tarde 2",
            "Cookie de aveia e banana"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 21),
            "Lanche da manhã",
            "Pão puro e com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 21),
            "Almoço",
            "Arroz e feijão\nPurê de batata\nFrango ao molho\nSaladas de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 21),
            "Lanche da tarde 1",
            "Fruta\nCupcake de cenoura"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 21),
            "Lanche da tarde 2",
            "Biscoito de polvilho"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 22),
            "Lanche da manhã",
            "Pão puro e com requeijão\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 22),
            "Almoço",
            "Arroz e lentilha com carne e legumes\nSaladas de beterraba e couve-flor"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 22),
            "Lanche da tarde 1",
            "Fruta\nBolo de maçã"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 22),
            "Lanche da tarde 2",
            "Pão puro e com geleia caseira sem açúcar"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 23),
            "Lanche da manhã",
            "Pão puro e com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 23),
            "Almoço",
            "Carreteiro e feijão\nSalada de tomate e chuchu"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 23),
            "Lanche da tarde 1",
            "Fruta\nBolo de laranja"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 23),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        // =====================================================
        // SEMANA 5 - 26 A 30 DE OUTUBRO
        // =====================================================

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 26),
            "Lanche da manhã",
            "Pão puro e com geleia caseira sem açúcar"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 26),
            "Almoço",
            "Arroz e feijão\nPurê de batata\nFrango ao molho\nSaladas de tomate e alface"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 26),
            "Lanche da tarde 1",
            "Fruta\nLanche de casa"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 26),
            "Lanche da tarde 2",
            "Lanche de casa"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 27),
            "Lanche da manhã",
            "Pão puro e\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 27),
            "Almoço",
            "Arroz e feijão\nPanquecas de carne moída\nSaladas de cenoura e couve-flor"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 27),
            "Lanche da tarde 1",
            "Fruta\nPão puro e com geleia caseira sem açúcar"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 27),
            "Lanche da tarde 2",
            "Cookies de banana com aveia"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 28),
            "Lanche da manhã",
            "Pão puro e com geleia caseira sem açúcar\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 28),
            "Almoço",
            "Arroz e feijão\nPolenta\nCarne bovina ao molho\nSaladas de chuchu e brócolis"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 28),
            "Lanche da tarde 1",
            "Fruta\nCupcake de cenoura"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 28),
            "Lanche da tarde 2",
            "Pão de queijo"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 29),
            "Lanche da manhã",
            "Pão puro e com requeijão\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 29),
            "Almoço",
            "Arroz e lentilha com carne e legumes\nSaladas de beterraba e brócolis"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 29),
            "Lanche da tarde 1",
            "Fruta\nPão de queijo"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 29),
            "Lanche da tarde 2",
            "Pão puro e com geleia caseira sem açúcar"
        );


        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 30),
            "Lanche da manhã",
            "Pão puro e\nFruta"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 30),
            "Almoço",
            "Galinhada e feijão\nSalada de tomate e brócolis"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 30),
            "Lanche da tarde 1",
            "Fruta\nBolo de cacau"
        );

        AdicionarItemDemonstracao(
            cardapio,
            new DateTime(2026, 10, 30),
            "Lanche da tarde 2",
            "Biscoito de polvilho"
        );


        // =====================================================
        // ADICIONAR CARDÁPIO
        // =====================================================

        _cardapios.Add(
            cardapio
        );
    }


    // =========================================================
    // ADICIONAR ITEM DE DEMONSTRAÇÃO
    // =========================================================

    private void AdicionarItemDemonstracao(
        Cardapio cardapio,
        DateTime data,
        string refeicao,
        string preparacoes)
    {
        cardapio.Itens.Add(
            new ItemCardapio
            {
                Id =
                    _proximoItemId++,

                CardapioId =
                    cardapio.Id,

                Data =
                    data,

                Refeicao =
                    refeicao,

                Preparacoes =
                    preparacoes
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<Cardapio> ObterTodos()
    {
        return _cardapios
            .OrderByDescending(c => c.Ano)
            .ThenByDescending(c => c.Mes)
            .ToList();
    }


    public List<Cardapio> ObterPorInstituicao(
        int instituicaoId)
    {
        return _cardapios
            .Where(
                c =>
                    c.InstituicaoId ==
                    instituicaoId
            )
            .OrderByDescending(c => c.Ano)
            .ThenByDescending(c => c.Mes)
            .ToList();
    }


    public Cardapio? ObterPorId(
        int id)
    {
        return _cardapios
            .FirstOrDefault(
                c =>
                    c.Id ==
                    id
            );
    }


    public Cardapio? ObterPorPeriodo(
        int instituicaoId,
        int mes,
        int ano)
    {
        return _cardapios
            .FirstOrDefault(
                c =>
                    c.InstituicaoId ==
                    instituicaoId
                    &&
                    c.Mes ==
                    mes
                    &&
                    c.Ano ==
                    ano
            );
    }


    // =========================================================
    // SALVAR RASCUNHO
    // =========================================================

    public Cardapio SalvarRascunho(
        Cardapio cardapio)
    {
        var existente =
            ObterPorPeriodo(
                cardapio.InstituicaoId,
                cardapio.Mes,
                cardapio.Ano
            );


        if (existente is null)
        {
            cardapio.Id =
                _proximoId++;

            cardapio.Status =
                StatusCardapio.Rascunho;

            cardapio.DataCriacao =
                DateTime.Now;

            PrepararItens(
                cardapio
            );

            _cardapios.Add(
                cardapio
            );

            return cardapio;
        }


        existente.InstituicaoNome =
            cardapio.InstituicaoNome;

        existente.Observacoes =
            cardapio.Observacoes;

        existente.Status =
            StatusCardapio.Rascunho;

        existente.DataAtualizacao =
            DateTime.Now;

        existente.DataFinalizacao =
            null;

        existente.Itens =
            cardapio.Itens;


        PrepararItens(
            existente
        );


        return existente;
    }


    // =========================================================
    // FINALIZAR
    // =========================================================

    public Cardapio Finalizar(
        Cardapio cardapio)
    {
        var salvo =
            SalvarRascunho(
                cardapio
            );


        salvo.Status =
            StatusCardapio.Finalizado;

        salvo.DataAtualizacao =
            DateTime.Now;

        salvo.DataFinalizacao =
            DateTime.Now;


        return salvo;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(
        int id)
    {
        var cardapio =
            ObterPorId(
                id
            );


        if (cardapio is null)
        {
            return false;
        }


        _cardapios.Remove(
            cardapio
        );


        return true;
    }


    // =========================================================
    // PREPARAR ITENS
    // =========================================================

    private void PrepararItens(
        Cardapio cardapio)
    {
        foreach (var item in cardapio.Itens)
        {
            item.CardapioId =
                cardapio.Id;


            if (item.Id == 0)
            {
                item.Id =
                    _proximoItemId++;
            }
        }
    }
}