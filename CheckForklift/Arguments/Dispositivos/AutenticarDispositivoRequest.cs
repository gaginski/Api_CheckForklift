using CheckForklift.Interfaces;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AutenticarDispositivoRequest : IRequest
    {
        public long Imei { get; set; }
    }
}
