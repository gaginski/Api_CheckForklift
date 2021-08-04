using CheckForklift.Interfaces;

namespace CheckForklift.Arguments.Veiculos
{
    public class RetornaVeiculosRequest : IRequest
    {
        public string Imei { get; set; }
        public string User { get; set; }
    }
}
