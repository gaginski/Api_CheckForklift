using CheckForklift.Enum;
using System;
using prmToolkit.NotificationPattern;
using CheckForklift.Resources;
using System.ComponentModel.DataAnnotations;
using CheckForklift.Entities.Base;

namespace CheckForklift.Entities
{
    public class Veiculos : EntityBase
    {
        public Veiculos(int id)
        {
            Id = id;

          /*  new AddNotifications<Veiculos>(this)
            .IfEqualsZero(x => x.Id, string.Format(Resource.X0_Invalido, "Id"));*/
        }
        [Key]
        public int Id { get; private set; }
        public string Placa { get; private set; }
        public string Marca { get; private set; }
        public string Cor { get; private set; }
        public DateTime AnoFabricacao { get; private set; }
        public DateTime DataAquisicao { get; private set; }
        public TStatusVeiculo Status { get; private set; }
        public TSituacaoVeiculo Situacao { get; private set; }
    }
}
