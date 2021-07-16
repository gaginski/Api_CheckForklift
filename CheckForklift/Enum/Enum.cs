namespace CheckForklift.Enum
{
    public enum TStatusVeiculo 
    {
        Ativo, 
        Inativo,
        Excluido
    }

    public enum TSituacaoVeiculo
    {
        Uso,
        Manutencao,
        Disponivel,
        Reservado
    }
    public enum TSituacaoUtilizacao
    {
        Aberta,
        Fechada,
    }

    public enum TSituacaoDispositivo
    {
        AguardandoAceite,
        Aceito,
        Rejeitado,
        Cancelado
    }
}
