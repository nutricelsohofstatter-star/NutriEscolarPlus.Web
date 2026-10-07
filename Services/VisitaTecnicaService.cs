using NutriEscolarPlus.Web.Models;

namespace NutriEscolarPlus.Web.Services;

public class VisitaTecnicaService
{
    private readonly List<VisitaTecnica> _visitas = new();

    private int _proximoId = 1;

    private int _proximoPendenciaId = 1;


    // =========================================================
    // CONSTRUTOR - DADOS DE DEMONSTRAÇÃO
    // =========================================================

    public VisitaTecnicaService()
    {
        CarregarDadosDemonstracao();
    }


    // =========================================================
    // DADOS DE DEMONSTRAÇÃO
    // =========================================================

    private void CarregarDadosDemonstracao()
    {
        if (_visitas.Any())
        {
            return;
        }


        // =====================================================
        // VISITA 1 - REALIZADA
        // =====================================================

        Adicionar(
            new VisitaTecnica
            {
                InstituicaoId = 1,

                DataVisita =
                    new DateTime(2026, 9, 14),

                ResponsavelTecnico =
                    "Celso Felipe Roos Hofstatter",

                Tipo =
                    TipoVisitaTecnica.Rotina,

                Objetivo =
                    "Acompanhar as condições higiênico-sanitárias da área de alimentação e verificar os procedimentos adotados pela equipe.",

                Acompanhantes =
                    "Direção da escola e equipe responsável pela alimentação",

                AtividadesRealizadas =
                    "Inspeção da cozinha, despensa, equipamentos e área de armazenamento. Conferência das condições dos alimentos, organização dos produtos, higiene dos ambientes e rotinas de manipulação.",

                Observacoes =
                    "A unidade apresentou boas condições gerais de organização e higiene. Foi identificada necessidade de reforçar a identificação de alguns produtos armazenados após abertura.",

                Orientacoes =
                    "Manter todos os produtos fracionados ou abertos devidamente identificados com nome do produto, data de abertura e prazo de utilização.",

                HouveVerificacaoBoasPraticas =
                    true,

                AgendarProximaVisita =
                    true,

                DataProximaVisita =
                    new DateTime(2026, 10, 19),

                ObservacaoProximaVisita =
                    "Reavaliar a identificação dos produtos e acompanhar a rotina de armazenamento.",

                Situacao =
                    StatusVisitaTecnica.Realizada,

                Pendencias =
                    new List<PendenciaVisitaTecnica>
                    {
                        new PendenciaVisitaTecnica
                        {
                            Descricao =
                                "Alguns produtos abertos estavam sem identificação completa.",

                            AcaoCorretiva =
                                "Padronizar etiquetas contendo produto, data de abertura e prazo de utilização.",

                            Responsavel =
                                "Equipe da cozinha",

                            Prazo =
                                new DateTime(2026, 9, 21),

                            Situacao =
                                StatusPendenciaVisitaTecnica.Concluida
                        }
                    }
            }
        );


        // =====================================================
        // VISITA 2 - REALIZADA
        // =====================================================

        Adicionar(
            new VisitaTecnica
            {
                InstituicaoId = 1,

                DataVisita =
                    new DateTime(2026, 10, 5),

                ResponsavelTecnico =
                    "Celso Felipe Roos Hofstatter",

                Tipo =
                    TipoVisitaTecnica.Acompanhamento,

                Objetivo =
                    "Acompanhar a execução do cardápio, verificar o armazenamento dos alimentos e revisar os cuidados relacionados às dietas especiais.",

                Acompanhantes =
                    "Responsável pela cozinha e coordenação da instituição",

                AtividadesRealizadas =
                    "Conferência do cardápio do dia, avaliação do armazenamento seco e refrigerado, verificação das identificações dos alimentos e revisão das dietas especiais cadastradas.",

                Observacoes =
                    "As orientações da visita anterior foram atendidas. Os produtos abertos estavam devidamente identificados. Foi observado que a identificação das dietas especiais pode ser reforçada no momento da distribuição.",

                Orientacoes =
                    "Manter as preparações destinadas aos alunos com restrições alimentares identificadas e separadas até o momento da entrega.",

                HouveVerificacaoBoasPraticas =
                    true,

                AgendarProximaVisita =
                    true,

                DataProximaVisita =
                    new DateTime(2026, 10, 19),

                ObservacaoProximaVisita =
                    "Acompanhar o fluxo de preparo e distribuição das dietas especiais e revisar registros de controle.",

                Situacao =
                    StatusVisitaTecnica.Realizada,

                Pendencias =
                    new List<PendenciaVisitaTecnica>
                    {
                        new PendenciaVisitaTecnica
                        {
                            Descricao =
                                "Reforçar a identificação visual das preparações destinadas aos alunos com dietas especiais.",

                            AcaoCorretiva =
                                "Implantar identificação específica nas preparações e orientar toda a equipe responsável pela distribuição.",

                            Responsavel =
                                "Responsável pela cozinha",

                            Prazo =
                                new DateTime(2026, 10, 16),

                            Situacao =
                                StatusPendenciaVisitaTecnica.Pendente
                        }
                    }
            }
        );


        // =====================================================
        // VISITA 3 - AGENDADA
        // =====================================================

        Adicionar(
            new VisitaTecnica
            {
                InstituicaoId = 1,

                DataVisita =
                    new DateTime(2026, 10, 19),

                ResponsavelTecnico =
                    "Celso Felipe Roos Hofstatter",

                Tipo =
                    TipoVisitaTecnica.Retorno,

                Objetivo =
                    "Realizar retorno técnico para acompanhamento das orientações e pendências registradas nas visitas anteriores.",

                Acompanhantes =
                    "Coordenação e equipe responsável pela alimentação",

                AtividadesRealizadas =
                    string.Empty,

                Observacoes =
                    "Visita programada para acompanhamento das adequações.",

                Orientacoes =
                    string.Empty,

                HouveVerificacaoBoasPraticas =
                    false,

                AgendarProximaVisita =
                    false,

                DataProximaVisita =
                    null,

                ObservacaoProximaVisita =
                    string.Empty,

                Situacao =
                    StatusVisitaTecnica.Agendada,

                Pendencias =
                    new List<PendenciaVisitaTecnica>()
            }
        );
    }


    // =========================================================
    // CONSULTAS
    // =========================================================

    public List<VisitaTecnica> ObterTodos()
    {
        return _visitas
            .OrderByDescending(x => x.DataVisita)
            .ToList();
    }


    public List<VisitaTecnica> ObterPorInstituicao(
        int instituicaoId)
    {
        return _visitas
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .OrderByDescending(x =>
                x.DataVisita)
            .ToList();
    }


    public VisitaTecnica? ObterPorId(int id)
    {
        return _visitas
            .FirstOrDefault(x =>
                x.Id == id);
    }


    // =========================================================
    // ADICIONAR
    // =========================================================

    public void Adicionar(
        VisitaTecnica visita)
    {
        visita.Id =
            _proximoId++;

        visita.DataCadastro =
            DateTime.Now;

        visita.DataAtualizacao =
            null;

        visita.ResponsavelTecnico =
            visita.ResponsavelTecnico.Trim();

        visita.Objetivo =
            visita.Objetivo.Trim();

        visita.Acompanhantes =
            visita.Acompanhantes.Trim();

        visita.AtividadesRealizadas =
            visita.AtividadesRealizadas.Trim();

        visita.Observacoes =
            visita.Observacoes.Trim();

        visita.Orientacoes =
            visita.Orientacoes.Trim();

        visita.ObservacaoProximaVisita =
            visita.ObservacaoProximaVisita.Trim();

        PrepararPendencias(visita);

        _visitas.Add(visita);
    }


    // =========================================================
    // ATUALIZAR
    // =========================================================

    public bool Atualizar(
        VisitaTecnica visitaAtualizada)
    {
        var visitaExistente =
            _visitas.FirstOrDefault(x =>
                x.Id == visitaAtualizada.Id);

        if (visitaExistente is null)
        {
            return false;
        }


        visitaExistente.InstituicaoId =
            visitaAtualizada.InstituicaoId;

        visitaExistente.DataVisita =
            visitaAtualizada.DataVisita;

        visitaExistente.ResponsavelTecnico =
            visitaAtualizada.ResponsavelTecnico.Trim();

        visitaExistente.Tipo =
            visitaAtualizada.Tipo;

        visitaExistente.Objetivo =
            visitaAtualizada.Objetivo.Trim();

        visitaExistente.Acompanhantes =
            visitaAtualizada.Acompanhantes.Trim();

        visitaExistente.AtividadesRealizadas =
            visitaAtualizada.AtividadesRealizadas.Trim();

        visitaExistente.Observacoes =
            visitaAtualizada.Observacoes.Trim();

        visitaExistente.Orientacoes =
            visitaAtualizada.Orientacoes.Trim();

        visitaExistente.HouveVerificacaoBoasPraticas =
            visitaAtualizada.HouveVerificacaoBoasPraticas;

        visitaExistente.VerificacaoBoasPraticasId =
            visitaAtualizada.VerificacaoBoasPraticasId;

        visitaExistente.Pendencias =
            visitaAtualizada.Pendencias;

        visitaExistente.AgendarProximaVisita =
            visitaAtualizada.AgendarProximaVisita;

        visitaExistente.DataProximaVisita =
            visitaAtualizada.DataProximaVisita;

        visitaExistente.ObservacaoProximaVisita =
            visitaAtualizada.ObservacaoProximaVisita.Trim();

        visitaExistente.Situacao =
            visitaAtualizada.Situacao;

        visitaExistente.DataAtualizacao =
            DateTime.Now;


        PrepararPendencias(
            visitaExistente);


        return true;
    }


    // =========================================================
    // EXCLUIR
    // =========================================================

    public bool Excluir(int id)
    {
        var visita =
            _visitas.FirstOrDefault(x =>
                x.Id == id);

        if (visita is null)
        {
            return false;
        }


        _visitas.Remove(visita);

        return true;
    }


    // =========================================================
    // CONTADORES
    // =========================================================

    public int ContarPorInstituicao(
        int instituicaoId)
    {
        return _visitas.Count(x =>
            x.InstituicaoId == instituicaoId);
    }


    public int ContarRealizadas(
        int instituicaoId)
    {
        return _visitas.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusVisitaTecnica.Realizada);
    }


    public int ContarAgendadas(
        int instituicaoId)
    {
        return _visitas.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusVisitaTecnica.Agendada);
    }


    public int ContarCanceladas(
        int instituicaoId)
    {
        return _visitas.Count(x =>
            x.InstituicaoId == instituicaoId &&
            x.Situacao ==
                StatusVisitaTecnica.Cancelada);
    }


    public int ContarPendenciasAbertas(
        int instituicaoId)
    {
        return _visitas
            .Where(x =>
                x.InstituicaoId == instituicaoId)
            .SelectMany(x =>
                x.Pendencias)
            .Count(x =>
                x.Situacao ==
                    StatusPendenciaVisitaTecnica.Pendente);
    }


    // =========================================================
    // PRÓXIMA VISITA
    // =========================================================

    public VisitaTecnica? ObterProximaVisita(
        int instituicaoId)
    {
        var hoje =
            DateTime.Today;

        return _visitas
            .Where(x =>
                x.InstituicaoId == instituicaoId &&
                x.Situacao ==
                    StatusVisitaTecnica.Agendada &&
                x.DataVisita.Date >= hoje)
            .OrderBy(x =>
                x.DataVisita)
            .FirstOrDefault();
    }


    // =========================================================
    // PENDÊNCIAS
    // =========================================================

    private void PrepararPendencias(
        VisitaTecnica visita)
    {
        foreach (var pendencia in visita.Pendencias)
        {
            if (pendencia.Id == 0)
            {
                pendencia.Id =
                    _proximoPendenciaId++;
            }

            pendencia.Descricao =
                pendencia.Descricao.Trim();

            pendencia.AcaoCorretiva =
                pendencia.AcaoCorretiva.Trim();

            pendencia.Responsavel =
                pendencia.Responsavel.Trim();
        }
    }
}