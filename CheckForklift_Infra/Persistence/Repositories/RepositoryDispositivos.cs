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
            Dispo.Salvar<Dispositivos>();

            return Dispo;
        }

        public Dispositivos RetornaDispositivoByImei(Dispositivos Dispo)
        {
            var v = Dispo.Busca<Dispositivos>();

            if (v.Count > 0)
                return v[0];

            return null;
        }

        public Dispositivos ObterPorId(Guid id, params Expression<Func<Dispositivos, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
