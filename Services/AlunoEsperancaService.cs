using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class AlunoEsperancaService
{
    private readonly List<AlunoEsperanca> _alunos = new();

    private int _proximoId = 1;


    public AlunoEsperancaService()
    {
        CriarDadosIniciais();
    }


    // =========================================================
    // LISTAGEM
    // =========================================================

    public List<AlunoEsperanca> ObterTodos(
        int instituicaoId = 2)
    {
        return _alunos
            .Where(a =>
                a.InstituicaoId == instituicaoId)
            .OrderBy(a => a.Nome)
            .ToList();
    }


    public List<AlunoEsperanca> ObterAtivos(
        int instituicaoId = 2)
    {
        return _alunos
            .Where(a =>
                a.InstituicaoId == instituicaoId &&
                a.Ativo)
            .OrderBy(a => a.Nome)
            .ToList();
    }


    public List<AlunoEsperanca> ObterPorGrupo(
        int grupoId)
    {
        return _alunos
            .Where(a =>
                a.GrupoId == grupoId &&
                a.Ativo)
            .OrderBy(a => a.Nome)
            .ToList();
    }


    public AlunoEsperanca? ObterPorId(
        int id)
    {
        return _alunos
            .FirstOrDefault(a =>
                a.Id == id);
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarAtivos(
        int instituicaoId = 2)
    {
        return _alunos.Count(a =>
            a.InstituicaoId == instituicaoId &&
            a.Ativo);
    }


    public int ContarPorGrupo(
        int grupoId)
    {
        return _alunos.Count(a =>
            a.GrupoId == grupoId &&
            a.Ativo);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public AlunoEsperanca Adicionar(
        AlunoEsperanca aluno)
    {
        aluno.Id =
            _proximoId++;

        aluno.DataCadastro =
            DateTime.Now;

        _alunos.Add(aluno);

        return aluno;
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        AlunoEsperanca aluno)
    {
        var existente =
            ObterPorId(aluno.Id);

        if (existente is null)
            return false;

        existente.Nome =
            aluno.Nome;

        existente.DataNascimento =
            aluno.DataNascimento;

        existente.Responsavel =
            aluno.Responsavel;

        existente.Telefone =
            aluno.Telefone;

        existente.RestricaoAlimentar =
            aluno.RestricaoAlimentar;

        existente.GrupoId =
            aluno.GrupoId;

        existente.Ativo =
            aluno.Ativo;

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
        var aluno =
            ObterPorId(id);

        if (aluno is null)
            return false;

        _alunos.Remove(aluno);

        return true;
    }


    // =========================================================
    // DADOS INICIAIS
    // =========================================================

    private void CriarDadosIniciais()
    {
        Adicionar(
            new AlunoEsperanca
            {
                Nome = "Ana Clara",
                DataNascimento =
                    DateTime.Today.AddYears(-10),
                Responsavel = "Maria",
                Telefone = "(51) 99999-1001",
                RestricaoAlimentar =
                    "Sem restrições",
                GrupoId = 1
            });


        Adicionar(
            new AlunoEsperanca
            {
                Nome = "Lucas",
                DataNascimento =
                    DateTime.Today.AddYears(-11),
                Responsavel = "Juliana",
                Telefone = "(51) 99999-1002",
                RestricaoAlimentar =
                    "Intolerância à lactose",
                GrupoId = 1
            });


        Adicionar(
            new AlunoEsperanca
            {
                Nome = "Gabriel",
                DataNascimento =
                    DateTime.Today.AddYears(-9),
                Responsavel = "Carla",
                Telefone = "(51) 99999-1003",
                RestricaoAlimentar =
                    "Sem restrições",
                GrupoId = 2
            });


        Adicionar(
            new AlunoEsperanca
            {
                Nome = "Laura",
                DataNascimento =
                    DateTime.Today.AddYears(-12),
                Responsavel = "Fernanda",
                Telefone = "(51) 99999-1004",
                RestricaoAlimentar =
                    "Alergia à proteína do leite",
                GrupoId = 3
            });


        Adicionar(
            new AlunoEsperanca
            {
                Nome = "Pedro",
                DataNascimento =
                    DateTime.Today.AddYears(-10),
                Responsavel = "Patrícia",
                Telefone = "(51) 99999-1005",
                RestricaoAlimentar =
                    "Sem restrições",
                GrupoId = 4
            });
    }
}