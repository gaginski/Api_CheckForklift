using CheckForklift.Arguments.Usuario;
using CheckForklift.Entities;
using CheckForklift.Extension;
using CheckForklift.Interfaces.Repositories;
using CheckForklift.Interfaces.Services;
using MyReview.DataBase;
using prmToolkit.NotificationPattern;
using System;
using System.Reflection;
using VgsOrm.DataBase;

namespace CheckForklift.Services
{
    public class ServicesUsuarios : Notifiable, IServiceUsuarios
    {
        readonly IRepositoryUsuarios _repositoryUsuario;

        public ServicesUsuarios(IRepositoryUsuarios repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AutenticaUsuarioResponse Autenticar(AutenticaUsuarioRequest request)
        {
            var usuarioAux = new Usuarios(user: request.User, senha: request.Senha);
            Usuarios u = _repositoryUsuario.ReturnUsuarioByUser(usuarioAux);

            if (u != null && usuarioAux.Senha == u.Senha.ConvertToMD5())
                return (AutenticaUsuarioResponse)u;


            return (AutenticaUsuarioResponse)new Usuarios();
        }

    }
}
