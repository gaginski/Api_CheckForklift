using CheckForklift.Api.Controllers.Base;
using CheckForklift.Arguments.Usuario;
using CheckForklift.Interfaces.Services;
using System;
using CheckForklift_Infra.Persistence.Repositories;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CheckForklift.Api.Security;
using CheckForklift.Arguments.Dispositivos;

namespace ChechForklift_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/dispositivos")]
    public class DispositivosController : ControllerBase
    {
        private readonly IServicesDispositivos _servicesDispositivos;
        public DispositivosController(IServicesDispositivos servicesUsuario)
        {
            _servicesDispositivos = servicesUsuario;
        }

        [Route("Autenticar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Autenticar(AutenticarDispositivoRequest request)
        {
            try
            {
                AutenticarDispositivoResponse response = _servicesDispositivos.AutenticaDispositivo(request);

                return await ResponseAsync(response, _servicesDispositivos);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Cadatrar(AdicionarDispositivoRequest request)
        {
            try
            {
                AdicionarDispositivoResponse response = _servicesDispositivos.AdicionarDispositivo(request);

                return await ResponseAsync(response, _servicesDispositivos);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

    }
}