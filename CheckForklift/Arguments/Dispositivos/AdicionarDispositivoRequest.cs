using CheckForklift.Interfaces;
using System;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AdicionarDispositivoRequest : IRequest
    {
        public string User { get; set; }
        public Int64 Imei { get; set; }
        public string modelo { get; set; }
        public string Descricao { get; set; }
    }
}
