using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CheckForklift_Infra.Persistence.Repositories
{
    public class RepositoryVeiculos : IRepositoryVeiculos
    {
     

        public Veiculos ObterPorId(Guid id, params Expression<Func<Veiculos, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public List<Veiculos> RetornarVeiculos(Usuarios user, Dispositivos dispositivo)
        {

            return null;
        }
    }
}
