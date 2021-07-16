using CheckForklift.Arguments.Utilizacao;
using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories.Base;
using System;

namespace CheckForklift.Interfaces.Repositories
{
    public interface IRepositoryUtilizacao
    {
        Utilizacoes SalvarUtilizacao(Utilizacoes utilizacao);
    }
}
