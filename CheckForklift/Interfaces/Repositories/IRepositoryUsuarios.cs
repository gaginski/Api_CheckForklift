using CheckForklift.Arguments.Usuario;
using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories.Base;
using MyReview.DataBase;
using System;

namespace CheckForklift.Interfaces.Repositories
{
    public interface IRepositoryUsuarios 
    {
        Usuarios ReturnUsuarioByUser(Usuarios usuario);
    }
}
