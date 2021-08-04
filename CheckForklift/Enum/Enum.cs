namespace CheckForklift.Enum
{
    public enum TStatusVeiculo 
    {
        Ativo, 
        Inativo,
        Excluido
    }

    public enum TStatusToken
    {
        Ativo,
        Inativo,
        Vencido
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
