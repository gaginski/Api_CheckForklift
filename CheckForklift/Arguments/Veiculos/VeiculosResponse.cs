using CheckForklift.Enum;
using System;

namespace CheckForklift.Arguments.Veiculos
{
    public class VeiculosResponse
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public TStatusVeiculo Status { get; set; }
        public TSituacaoVeiculo Situacao { get; set; }
    }
}
