namespace NutriEscolarPlus.Web.Models;

public class AlunoEsperanca
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; } = 2;

    // =========================================================
    // DADOS DO ALUNO
    // =========================================================

    public string Nome { get; set; } = string.Empty;

    public DateTime? DataNascimento { get; set; }

    public int? Idade
    {
        get
        {
            if (!DataNascimento.HasValue)
                return null;

            var hoje = DateTime.Today;
            var nascimento = DataNascimento.Value.Date;

            var idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
                idade--;

            return idade;
        }
    }

    // =========================================================
    // RESPONSÁVEL
    // =========================================================

    public string Responsavel { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;

    // =========================================================
    // INFORMAÇÕES NUTRICIONAIS
    // =========================================================

    public string RestricaoAlimentar { get; set; } = string.Empty;

    // =========================================================
    // GRUPO
    // =========================================================

    public int? GrupoId { get; set; }

    // =========================================================
    // SITUAÇÃO
    // =========================================================

    public bool Ativo { get; set; } = true;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }
}