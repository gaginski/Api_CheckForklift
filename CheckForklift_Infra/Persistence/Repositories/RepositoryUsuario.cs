using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using MyReview.DataBase;

namespace CheckForklift_Infra.Persistence.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuarios
    {
        public Usuarios ReturnUsuarioByUser(Usuarios usuario)
        {

           Usuarios usuarioBusca = new Usuarios(usuario.User);
           var v = usuarioBusca.Busca<Usuarios>();

            if (v.Count > 0)
                return v[0];

            return null;
        }
    }
}
