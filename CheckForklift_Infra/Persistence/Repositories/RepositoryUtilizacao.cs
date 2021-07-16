using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using System;
using System.Linq.Expressions;

namespace CheckForklift_Infra.Persistence.Repositories
{
    public class RepositoryUtilizacao : IRepositoryUtilizacao
    {
        public Utilizacoes ObterPorId(Guid id, params Expression<Func<Utilizacoes, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Utilizacoes SalvarUtilizacao(Utilizacoes utilizacao)
        {
    
            return utilizacao;
        }
    }
}
