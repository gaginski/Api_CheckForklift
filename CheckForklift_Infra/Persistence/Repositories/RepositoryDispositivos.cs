using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CheckForklift_Infra.Persistence.Repositories
{
    public class RepositoryDispositivos : IRepositoryDispositivos
    {
        public Dispositivos AdicionarDispositivo(Dispositivos Dispo)
        {
        
            return Dispo;
        }

        public Dispositivos AutenticaDispositivo(Dispositivos Dispo)
        {
            
            return null;
        }

        public Dispositivos ObterPorId(Guid id, params Expression<Func<Dispositivos, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
