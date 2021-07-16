using CheckForklift.Arguments.Dispositivos;
using CheckForklift.Interfaces.Services.Base;

namespace CheckForklift.Interfaces.Services
{
    public interface IServicesDispositivos : IServiceBase
    {
        AdicionarDispositivoResponse AdicionarDispositivo(AdicionarDispositivoRequest request);

        AutenticarDispositivoResponse AutenticaDispositivo(AutenticarDispositivoRequest request);
    }
}
