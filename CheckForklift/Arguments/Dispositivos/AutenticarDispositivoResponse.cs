using CheckForklift.Interfaces.Arguments;
using System;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AutenticarDispositivoResponse : IResponse
    {
        public int Id { get; set; }
        public long Imei { get; set; }
        public string Msg { get; set; }

        public static explicit operator AutenticarDispositivoResponse(Entities.Dispositivos v)
        {
            AutenticarDispositivoResponse response = new AutenticarDispositivoResponse();

            response.Msg = v == null ? string.Format(Resources.Resource.X0_Invalido, "Dispositivo") : "Operação realizada!";

            if (v == null)
                return response;

            response.Id = v.Id;
            response.Imei = v.Imei;          

            return response;
        }
    }
}
