using CheckForklift.Interfaces;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AutenticarDispositivoRequest : IRequest
    {
        public string Imei { get; set; }
    }
}
