using CheckForklift.Enum;
using CheckForklift.Interfaces.Arguments;
using System;

namespace CheckForklift.Arguments.Dispositivos
{
    public class AutenticarDispositivoResponse : IResponse
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public int status { get; set; }
        public string Msg { get; set; }

        public static explicit operator AutenticarDispositivoResponse(Entities.Dispositivos v)
        {
            AutenticarDispositivoResponse response = new AutenticarDispositivoResponse();

            switch (v?.Situacao)
            {
                case TSituacaoDispositivo.Aceito: response.Msg = "Aceito"; break;
                case TSituacaoDispositivo.AguardandoAceite: response.Msg = "Processando"; break;
                case TSituacaoDispositivo.Cancelado: case TSituacaoDispositivo.Rejeitado: response.Msg = "Não aceito"; break;
                default: response.Msg = "Não cadastrado"; response.Id = 0;  break;
            }
            response.status = v == null ? 404 : (int)v.Situacao;
            if (v == null)
                return response;

            response.Id = v.Id;
            response.Imei = v.Imei;

            return response;
        }
    }
}
