using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class DietaEspecialService
{
    private readonly List<DietaEspecial> _dietas =
        new();

    private int _proximoId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public DietaEspecialService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_dietas.Any())
        {
            return;
        }


        // =====================================================
        // BERNARDO OLIVEIRA
        // INTOLERÂNCIA À LACTOSE
        // =====================================================

        Adicionar(
            new DietaEspecial
            {
                InstituicaoId = 1,

                AlunoId = 2,

                AlunoNome =
                    "Bernardo Oliveira",

                Turma =
                    "Pré I",

                Tipo =
                    TipoDietaEspecial.IntoleranciaAlimentar,

                DiagnosticoNecessidade =
                    "Intolerância à lactose",

                AlimentosRestritos =
                    "Leite comum e preparações com quantidade significativa de lactose.",

                SubstituicoesOrientacoes =
                    "Utilizar leite e derivados sem lactose quando necessário. Conferir rótulos dos produtos utilizados nas preparações.",

                Observacoes =
                    "Orientar a equipe da cozinha para identificar corretamente as preparações destinadas ao aluno e evitar trocas no momento da distribuição.",

                Situacao =
                    StatusDietaEspecial.Ativa,

                DataInicio =
                    new DateTime(2026, 9, 10)
            }
        );


        // =====================================================
        // DAVI RODRIGUES
        // APLV
        // =====================================================

        Adicionar(
            new DietaEspecial
            {
                InstituicaoId = 1,

                AlunoId = 4,

                AlunoNome =
                    "Davi Rodrigues",

                Turma =
                    "Maternal III",

                Tipo =
                    TipoDietaEspecial.AlergiaAlimentar,

                DiagnosticoNecessidade =
                    "Alergia à proteína do leite de vaca (APLV)",

                AlimentosRestritos =
                    "Leite de vaca, queijos, iogurtes, manteiga, creme de leite e preparações que contenham proteínas do leite.",

                SubstituicoesOrientacoes =
                    "Utilizar substituições adequadas sem proteína do leite. Realizar leitura cuidadosa dos rótulos e manter utensílios e preparações protegidos de contato cruzado.",

                Observacoes =
                    "Necessário cuidado rigoroso durante armazenamento, preparo e distribuição das refeições. A equipe responsável pela alimentação deve estar informada sobre a restrição.",

                Situacao =
                    StatusDietaEspecial.Ativa,

                DataInicio =
                    new DateTime(2026, 8, 20)
            }
        );


        // =====================================================
        // GABRIEL ALMEIDA
        // ALERGIA A OVO
        // =====================================================

        Adicionar(
            new DietaEspecial
            {
                InstituicaoId = 1,

                AlunoId = 6,

                AlunoNome =
                    "Gabriel Almeida",

                Turma =
                    "Pré II",

                Tipo =
                    TipoDietaEspecial.AlergiaAlimentar,

                DiagnosticoNecessidade =
                    "Alergia alimentar a ovo",

                AlimentosRestritos =
                    "Ovo e preparações que contenham ovo ou derivados em sua composição.",

                SubstituicoesOrientacoes =
                    "Substituir preparações contendo ovo por alternativas seguras. Conferir ingredientes de bolos, massas, biscoitos e demais produtos industrializados.",

                Observacoes =
                    "Manter identificação da dieta especial e atenção ao risco de contato cruzado durante o preparo e a distribuição dos alimentos.",

                Situacao =
                    StatusDietaEspecial.Ativa,

                DataInicio =
                    new DateTime(2026, 9, 2)
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<DietaEspecial> ObterTodos()
    {
        return _dietas
            .OrderByDescending(d => d.DataCadastro)
            .ToList();
    }


    public List<DietaEspecial> ObterPorInstituicao(
        int instituicaoId)
    {
        return _dietas
            .Where(d =>
                d.InstituicaoId == instituicaoId)
            .OrderBy(d =>
                d.AlunoNome)
            .ToList();
    }


    public DietaEspecial? ObterPorId(
        int id)
    {
        return _dietas
            .FirstOrDefault(d =>
                d.Id == id);
    }


    public List<DietaEspecial> ObterPorAluno(
        int alunoId)
    {
        return _dietas
            .Where(d =>
                d.AlunoId == alunoId)
            .OrderByDescending(d =>
                d.DataInicio)
            .ToList();
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        DietaEspecial dieta)
    {
        dieta.Id =
            _proximoId++;

        dieta.DataCadastro =
            DateTime.Now;

        dieta.AlunoNome =
            dieta.AlunoNome.Trim();

        dieta.Turma =
            dieta.Turma.Trim();

        dieta.DiagnosticoNecessidade =
            dieta.DiagnosticoNecessidade.Trim();

        dieta.AlimentosRestritos =
            dieta.AlimentosRestritos.Trim();

        dieta.SubstituicoesOrientacoes =
            dieta.SubstituicoesOrientacoes.Trim();

        dieta.Observacoes =
            dieta.Observacoes.Trim();

        _dietas.Add(dieta);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        DietaEspecial dieta)
    {
        var existente =
            _dietas.FirstOrDefault(d =>
                d.Id == dieta.Id);

        if (existente is null)
        {
            return false;
        }


        existente.InstituicaoId =
            dieta.InstituicaoId;

        existente.AlunoId =
            dieta.AlunoId;

        existente.AlunoNome =
            dieta.AlunoNome.Trim();

        existente.Turma =
            dieta.Turma.Trim();

        existente.Tipo =
            dieta.Tipo;

        existente.DiagnosticoNecessidade =
            dieta.DiagnosticoNecessidade.Trim();

        existente.AlimentosRestritos =
            dieta.AlimentosRestritos.Trim();

        existente.SubstituicoesOrientacoes =
            dieta.SubstituicoesOrientacoes.Trim();

        existente.Observacoes =
            dieta.Observacoes.Trim();

        existente.Situacao =
            dieta.Situacao;

        existente.DataInicio =
            dieta.DataInicio;

        existente.DataFim =
            dieta.DataFim;

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
        var dieta =
            _dietas.FirstOrDefault(d =>
                d.Id == id);

        if (dieta is null)
        {
            return false;
        }


        _dietas.Remove(dieta);

        return true;
    }


    // =========================================================
    // INDICADORES
    // =========================================================

    public int ContarAtivas(
        int instituicaoId)
    {
        return _dietas.Count(d =>
            d.InstituicaoId == instituicaoId &&
            d.Situacao == StatusDietaEspecial.Ativa);
    }


    public int ContarAlergias(
        int instituicaoId)
    {
        return _dietas.Count(d =>
            d.InstituicaoId == instituicaoId &&
            d.Situacao == StatusDietaEspecial.Ativa &&
            d.Tipo == TipoDietaEspecial.AlergiaAlimentar);
    }


    public int ContarIntolerancias(
        int instituicaoId)
    {
        return _dietas.Count(d =>
            d.InstituicaoId == instituicaoId &&
            d.Situacao == StatusDietaEspecial.Ativa &&
            d.Tipo == TipoDietaEspecial.IntoleranciaAlimentar);
    }


    public int ContarOutrasNecessidades(
        int instituicaoId)
    {
        return _dietas.Count(d =>
            d.InstituicaoId == instituicaoId &&
            d.Situacao == StatusDietaEspecial.Ativa &&
            d.Tipo != TipoDietaEspecial.AlergiaAlimentar &&
            d.Tipo != TipoDietaEspecial.IntoleranciaAlimentar);
    }
}