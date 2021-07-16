using CheckForklift.Interfaces;
using prmToolkit.NotificationPattern;

namespace CheckForklift.Arguments.Usuario
{
    public class AutenticaUsuarioRequest : Notifiable, IRequest
    {
        public string User { get; set; }
        public string Senha { get; set; }
    }
}
