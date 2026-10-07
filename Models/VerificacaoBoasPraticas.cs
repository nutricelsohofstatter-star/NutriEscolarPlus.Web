namespace NutriEscolarPlus.Web.Models;

public class VerificacaoBoasPraticas
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public DateTime DataVerificacao { get; set; } = DateTime.Today;

    public string Responsavel { get; set; } = string.Empty;

    public string ObservacoesGerais { get; set; } = string.Empty;

    public StatusVerificacaoBoasPraticas Situacao { get; set; }
        = StatusVerificacaoBoasPraticas.Concluida;

    public List<ItemVerificacaoBoasPraticas> Itens { get; set; } = new();

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    public int TotalItens =>
        Itens.Count;


    public int TotalConformes =>
        Itens.Count(x =>
            x.Resultado == ResultadoItemBoasPraticas.Conforme);


    public int TotalNaoConformes =>
        Itens.Count(x =>
            x.Resultado == ResultadoItemBoasPraticas.NaoConforme);


    public int TotalNaoSeAplica =>
        Itens.Count(x =>
            x.Resultado == ResultadoItemBoasPraticas.NaoSeAplica);


    public int TotalPendentes =>
        Itens.Count(x =>
            x.Resultado == ResultadoItemBoasPraticas.Pendente);


    public decimal PercentualConformidade
    {
        get
        {
            var avaliados = Itens.Count(x =>
                x.Resultado == ResultadoItemBoasPraticas.Conforme ||
                x.Resultado == ResultadoItemBoasPraticas.NaoConforme);

            if (avaliados == 0)
                return 0;

            return Math.Round(
                (decimal)TotalConformes / avaliados * 100,
                1);
        }
    }
}


public class ItemVerificacaoBoasPraticas
{
    public int Id { get; set; }

    public CategoriaBoasPraticas Categoria { get; set; }

    public string Descricao { get; set; } = string.Empty;

    public ResultadoItemBoasPraticas Resultado { get; set; }
        = ResultadoItemBoasPraticas.Pendente;

    public string Observacao { get; set; } = string.Empty;

    public string AcaoCorretiva { get; set; } = string.Empty;

    public string ResponsavelCorrecao { get; set; } = string.Empty;

    public DateTime? PrazoCorrecao { get; set; }
}


public enum CategoriaBoasPraticas
{
    HigieneManipuladores = 1,
    Recebimento = 2,
    Armazenamento = 3,
    PreparoAlimentos = 4,
    EquipamentosUtensilios = 5,
    LimpezaHigienizacao = 6,
    ControlePragas = 7,
    Agua = 8,
    Residuos = 9
}


public enum ResultadoItemBoasPraticas
{
    Pendente = 0,
    Conforme = 1,
    NaoConforme = 2,
    NaoSeAplica = 3
}


public enum StatusVerificacaoBoasPraticas
{
    EmAndamento = 1,
    Concluida = 2
}