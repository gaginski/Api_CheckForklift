using CheckForklift.Arguments.Usuario;
using CheckForklift.Interfaces.Services.Base;
using prmToolkit.NotificationPattern;

namespace CheckForklift.Interfaces.Services
{
    public interface IServiceUsuarios : IServiceBase
    {
        AutenticaUsuarioResponse Autenticar(AutenticaUsuarioRequest request);
    }
}
