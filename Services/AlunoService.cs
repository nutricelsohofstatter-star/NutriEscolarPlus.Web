using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AlunoService
{
    private readonly List<Aluno> _alunos = new();

    private int _proximoId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public AlunoService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_alunos.Any())
        {
            return;
        }


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Alice Martins",
            DataNascimento = new DateTime(2021, 3, 18),
            Sexo = "Feminino",
            Turma = "Maternal II",
            Turno = "Manhã",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = false
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Bernardo Oliveira",
            DataNascimento = new DateTime(2020, 8, 7),
            Sexo = "Masculino",
            Turma = "Pré I",
            Turno = "Tarde",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = true,
            RestricaoAlergia = "Intolerância à lactose"
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Clara Ferreira",
            DataNascimento = new DateTime(2019, 11, 22),
            Sexo = "Feminino",
            Turma = "Pré II",
            Turno = "Manhã",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = false
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Davi Rodrigues",
            DataNascimento = new DateTime(2021, 6, 10),
            Sexo = "Masculino",
            Turma = "Maternal III",
            Turno = "Tarde",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = true,
            RestricaoAlergia = "Alergia à proteína do leite de vaca (APLV)"
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Elisa Costa",
            DataNascimento = new DateTime(2020, 2, 14),
            Sexo = "Feminino",
            Turma = "Pré I",
            Turno = "Manhã",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = false
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Gabriel Almeida",
            DataNascimento = new DateTime(2019, 9, 3),
            Sexo = "Masculino",
            Turma = "Pré II",
            Turno = "Tarde",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = true,
            RestricaoAlergia = "Alergia a ovo"
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Helena Souza",
            DataNascimento = new DateTime(2021, 1, 26),
            Sexo = "Feminino",
            Turma = "Maternal II",
            Turno = "Manhã",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = false
        });


        Adicionar(new Aluno
        {
            InstituicaoId = 1,
            InstituicaoNome = "Escola Girassol",
            Nome = "Miguel Santos",
            DataNascimento = new DateTime(2021, 10, 5),
            Sexo = "Masculino",
            Turma = "Maternal III",
            Turno = "Tarde",
            Situacao = StatusAluno.Ativo,
            PossuiRestricaoAlergia = false
        });
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<Aluno> ObterTodos()
    {
        return _alunos
            .OrderBy(a => a.Nome)
            .ToList();
    }


    public List<Aluno> ObterPorInstituicao(int instituicaoId)
    {
        return _alunos
            .Where(a => a.InstituicaoId == instituicaoId)
            .OrderBy(a => a.Nome)
            .ToList();
    }


    public Aluno? ObterPorId(int id)
    {
        return _alunos
            .FirstOrDefault(a => a.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public Aluno Adicionar(Aluno aluno)
    {
        aluno.Id = _proximoId++;

        aluno.DataCadastro = DateTime.Now;

        aluno.Nome = aluno.Nome.Trim();

        aluno.Turma = aluno.Turma.Trim();

        aluno.Turno = aluno.Turno.Trim();

        aluno.Sexo = aluno.Sexo.Trim();

        aluno.InstituicaoNome =
            aluno.InstituicaoNome.Trim();

        if (!aluno.PossuiRestricaoAlergia)
        {
            aluno.RestricaoAlergia = string.Empty;
        }
        else
        {
            aluno.RestricaoAlergia =
                aluno.RestricaoAlergia.Trim();
        }

        _alunos.Add(aluno);

        return aluno;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public Aluno? Atualizar(Aluno aluno)
    {
        var existente = ObterPorId(aluno.Id);

        if (existente is null)
        {
            return null;
        }

        existente.InstituicaoId =
            aluno.InstituicaoId;

        existente.InstituicaoNome =
            aluno.InstituicaoNome.Trim();

        existente.Nome =
            aluno.Nome.Trim();

        existente.DataNascimento =
            aluno.DataNascimento;

        existente.Sexo =
            aluno.Sexo.Trim();

        existente.Turma =
            aluno.Turma.Trim();

        existente.Turno =
            aluno.Turno.Trim();

        existente.Situacao =
            aluno.Situacao;

        existente.PossuiRestricaoAlergia =
            aluno.PossuiRestricaoAlergia;

        existente.RestricaoAlergia =
            aluno.PossuiRestricaoAlergia
                ? aluno.RestricaoAlergia.Trim()
                : string.Empty;

        existente.DataAtualizacao =
            DateTime.Now;

        return existente;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(int id)
    {
        var aluno = ObterPorId(id);

        if (aluno is null)
        {
            return false;
        }

        _alunos.Remove(aluno);

        return true;
    }


    // =========================================================
    // INDICADORES
    // =========================================================

    public int ContarPorInstituicao(int instituicaoId)
    {
        return _alunos.Count(a =>
            a.InstituicaoId == instituicaoId &&
            a.Situacao == StatusAluno.Ativo);
    }


    public int ContarComRestricaoAlergia(int instituicaoId)
    {
        return _alunos.Count(a =>
            a.InstituicaoId == instituicaoId &&
            a.Situacao == StatusAluno.Ativo &&
            a.PossuiRestricaoAlergia);
    }


    // =========================================================
    // TURMAS
    // =========================================================

    public List<string> ObterTurmas(int instituicaoId)
    {
        return _alunos
            .Where(a =>
                a.InstituicaoId == instituicaoId &&
                !string.IsNullOrWhiteSpace(a.Turma))
            .Select(a => a.Turma)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(t => t)
            .ToList();
    }
}