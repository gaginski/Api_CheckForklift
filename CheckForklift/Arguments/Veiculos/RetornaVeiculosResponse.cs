using CheckForklift.Interfaces.Arguments;
using System;
using System.Collections.Generic;

namespace CheckForklift.Arguments.Veiculos
{
    public class RetornaVeiculosResponse : IResponse
    {
        public string Msg { get; set; }
        public List<VeiculosResponse> ListaVeiculos { get; set; }

        public static explicit operator RetornaVeiculosResponse(List<Entities.Veiculos> v)
        {
            List<VeiculosResponse> listReturn = new List<VeiculosResponse>();
            RetornaVeiculosResponse _return = new RetornaVeiculosResponse();

            foreach (Entities.Veiculos vl in v)
                listReturn.Add(new VeiculosResponse()
                {
                    Id = vl.Id,
                    Placa = vl.Placa,
                    Marca = vl.Marca,
                    Cor = vl.Cor,
                    AnoFabricacao = vl.AnoFabricacao,
                    Status = vl.Status,
                    Situacao = vl.Situacao
                });

            _return.Msg = Resources.Resource.Operacao_realizada_com_sucesso;

            return _return;
        }
    }
}
