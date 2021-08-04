using CheckForklift.Interfaces.Arguments;
using CheckForklift.Resources;
using System;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AdicionarDispositivoResponse : IResponse
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public string Msg { get; set; }

        public static explicit operator AdicionarDispositivoResponse(Entities.Dispositivos v)
        {
            AdicionarDispositivoResponse aux = new AdicionarDispositivoResponse();

            aux.Msg = v == null ? string.Format(Resource.X0_Invalido, "Dispositivo") : Resource.Operacao_realizada_com_sucesso;

            if (v == null)
                return aux;

            aux.Id = v.Id;
            aux.Imei = v.Imei;

            return aux;
        }
    }
}
