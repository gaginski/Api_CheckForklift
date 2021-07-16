using CheckForklift.Entities;
using CheckForklift.Interfaces.Arguments;
using CheckForklift.Resources;
using System;

namespace CheckForklift.Arguments.Utilizacao
{
    public class SalvarUtilizacaoResponse : IResponse
    {
        public int IdUtilizacao { get; set; }
        public string Msg { get; set; }

        public static explicit operator SalvarUtilizacaoResponse(Utilizacoes v)
        {
            SalvarUtilizacaoResponse response = new SalvarUtilizacaoResponse();

            response.Msg = v == null ? string.Format(Resource.X0_Invalido, "Utilizacao") : Resource.Operacao_realizada_com_sucesso;

            if (v == null)
                return response;

            response.IdUtilizacao = v.Id;

            return response;
        }
    }
}
