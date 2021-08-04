using CheckForklift.Arguments.Usuario;
using CheckForklift.Interfaces.Services;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using System;
using System.Security.Claims;
using prmToolkit.NotificationPattern;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Unity;
using CheckForklift.Entities;

namespace CheckForklift.Api.Security
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        private readonly UnityContainer _container;

        public AuthorizationProvider(UnityContainer container)
        {
            _container = container;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                IServiceUsuarios serviceUsuario = _container.Resolve<IServiceUsuarios>();
                IServicesDispositivos servicesDispositivo = _container.Resolve<IServicesDispositivos>();


                AutenticaUsuarioRequest request = new AutenticaUsuarioRequest();
                request.User = context.UserName;
                request.Senha = context.Password;

                AutenticaUsuarioResponse response = serviceUsuario.Autenticar(request);

                serviceUsuario.ClearNotifications();

                if (response == null)
                {
                    context.SetError("invalid_grant", "Usuário não encontrado!");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                identity.AddClaim(new Claim("Usuarios", JsonConvert.SerializeObject(response)));

                var principal = new GenericPrincipal(identity, new string[] { });

                Thread.CurrentPrincipal = principal;

                context.Validated(identity);
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", ex.Message);
                return;
            }
        }
    }
}