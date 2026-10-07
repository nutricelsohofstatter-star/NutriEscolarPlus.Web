namespace NutriEscolarPlus.Web.Models;

public class Pop
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }


    // =========================================================
    // IDENTIFICAÇÃO
    // =========================================================

    public string Codigo { get; set; } = string.Empty;

    public string Titulo { get; set; } = string.Empty;

    public CategoriaPop Categoria { get; set; } =
        CategoriaPop.Outros;

    public string Versao { get; set; } = "1.0";

    public DateTime DataElaboracao { get; set; } =
        DateTime.Today;

    public DateTime? DataUltimaRevisao { get; set; }

    public DateTime? DataProximaRevisao { get; set; }

    public string ElaboradoPor { get; set; } =
        string.Empty;

    public string AprovadoPor { get; set; } =
        string.Empty;

    public StatusPop Situacao { get; set; } =
        StatusPop.Vigente;


    // =========================================================
    // CONTEÚDO DO POP
    // =========================================================

    public string Objetivo { get; set; } =
        string.Empty;

    public string CampoAplicacao { get; set; } =
        string.Empty;

    public string Responsabilidades { get; set; } =
        string.Empty;

    public string Frequencia { get; set; } =
        string.Empty;

    public string Monitoramento { get; set; } =
        string.Empty;

    public string Registros { get; set; } =
        string.Empty;

    public string AcoesCorretivas { get; set; } =
        string.Empty;

    public string Observacoes { get; set; } =
        string.Empty;

    public string Referencias { get; set; } =
        string.Empty;


    // =========================================================
    // MATERIAIS
    // =========================================================

    public List<MaterialPop> Materiais { get; set; } =
        new();


    // =========================================================
    // ETAPAS DO PROCEDIMENTO
    // =========================================================

    public List<EtapaPop> Etapas { get; set; } =
        new();


    // =========================================================
    // ORIGEM
    // =========================================================

    public bool CriadoAPartirDeModelo { get; set; }

    public int? ModeloOrigemId { get; set; }


    // =========================================================
    // CONTROLE
    // =========================================================

    public DateTime DataCadastro { get; set; } =
        DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    // =========================================================
    // CAMPOS CALCULADOS
    // =========================================================

    public int TotalEtapas =>
        Etapas.Count;

    public int TotalMateriais =>
        Materiais.Count;

    public bool PossuiEtapas =>
        Etapas.Count > 0;

    public bool PossuiMateriais =>
        Materiais.Count > 0;

    public bool RevisaoVencida =>
        DataProximaRevisao.HasValue &&
        DataProximaRevisao.Value.Date < DateTime.Today;

    public bool RevisaoProxima
    {
        get
        {
            if (!DataProximaRevisao.HasValue)
                return false;

            var hoje = DateTime.Today;

            var limite =
                hoje.AddDays(30);

            return DataProximaRevisao.Value.Date >= hoje &&
                   DataProximaRevisao.Value.Date <= limite;
        }
    }
}


// =========================================================
// MATERIAL DO POP
// =========================================================

public class MaterialPop
{
    public int Id { get; set; }

    public string Descricao { get; set; } =
        string.Empty;
}


// =========================================================
// ETAPA DO PROCEDIMENTO
// =========================================================

public class EtapaPop
{
    public int Id { get; set; }

    public int Ordem { get; set; }

    public string Descricao { get; set; } =
        string.Empty;
}


// =========================================================
// CATEGORIAS
// =========================================================

public enum CategoriaPop
{
    HigieneManipuladores = 1,

    HigienizacaoAlimentos = 2,

    HigienizacaoAmbiente = 3,

    Agua = 4,

    Residuos = 5,

    Pragas = 6,

    Equipamentos = 7,

    Recebimento = 8,

    Armazenamento = 9,

    PreparoAlimentos = 10,

    ControleTemperatura = 11,

    Distribuicao = 12,

    Amostras = 13,

    ProdutosSaneantes = 14,

    Outros = 15
}


// =========================================================
// SITUAÇÃO
// =========================================================

public enum StatusPop
{
    Rascunho = 1,

    Vigente = 2,

    EmRevisao = 3,

    Inativo = 4
}