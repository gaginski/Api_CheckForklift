using CheckForklift.Api.Controllers.Base;
using CheckForklift.Arguments.Usuario;
using CheckForklift.Interfaces.Services;
using System;
using CheckForklift_Infra.Persistence.Repositories;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CheckForklift.Api.Security;

namespace ChechForklift_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IServiceUsuarios _servicesUsuario;
        public UsuarioController(IServiceUsuarios servicesUsuario)
        {
            _servicesUsuario = servicesUsuario;
        }

        [Route("Autenticar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Autenticar(AutenticaUsuarioRequest request)
        {
            try
            {
                AutenticaUsuarioResponse response = _servicesUsuario.Autenticar(request);

                return await ResponseAsync(response, _servicesUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}