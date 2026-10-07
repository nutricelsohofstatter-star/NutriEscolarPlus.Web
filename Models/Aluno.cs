namespace NutriEscolarPlus.Web.Models;

public class Aluno
{
    public int Id { get; set; }

    public int InstituicaoId { get; set; }

    public string InstituicaoNome { get; set; } = string.Empty;

    public string Nome { get; set; } = string.Empty;

    public DateTime? DataNascimento { get; set; }

    public string Sexo { get; set; } = string.Empty;

    public string Turma { get; set; } = string.Empty;

    public string Turno { get; set; } = string.Empty;

    public StatusAluno Situacao { get; set; } = StatusAluno.Ativo;

    public bool PossuiRestricaoAlergia { get; set; }

    public string RestricaoAlergia { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public DateTime? DataAtualizacao { get; set; }


    public int? Idade
    {
        get
        {
            if (!DataNascimento.HasValue)
            {
                return null;
            }

            var hoje = DateTime.Today;
            var nascimento = DataNascimento.Value.Date;

            var idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }
    }
}


public enum StatusAluno
{
    Ativo = 1,
    Inativo = 2
}