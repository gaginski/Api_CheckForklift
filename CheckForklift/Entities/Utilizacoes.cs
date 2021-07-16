using CheckForklift.Entities.Base;
using CheckForklift.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace CheckForklift.Entities
{
    public class Utilizacoes : EntityBase
    {
        public Utilizacoes(Usuarios usuario, Veiculos veiculo, DateTime inicioUtilizacao, DateTime fimUtilizacao, long locationInic_X, long locationIni_Y, long locationFim_X, long locationFim_Y, Dispositivos dispositivo)
        {
            Dispositivo = dispositivo;
            Usuario = usuario;
            Veiculo = veiculo;
            InicioUtilizacao = inicioUtilizacao;
            FimUtilizacao = fimUtilizacao;
            LocationInic_X = locationInic_X;
            LocationIni_Y = locationIni_Y;
            LocationFim_X = locationFim_X;
            LocationFim_Y = locationFim_Y;
            /*AddNotifications(usuario.Notifications);
            AddNotifications(veiculo.Notifications);
            AddNotifications(dispositivo.Notifications);*/
        }
        [Key]
        public int Id { get;  set; }
        public Dispositivos Dispositivo { get; set; }
        public Usuarios Usuario { get;  set; }
        public Veiculos Veiculo { get;  set; }
        public DateTime InicioUtilizacao { get;  set; }
        public DateTime FimUtilizacao { get;  set; }
        public long LocationInic_X { get;  set; }
        public long LocationIni_Y { get;  set; }
        public long LocationFim_X { get;  set; }
        public long LocationFim_Y { get;  set; }
        public TSituacaoUtilizacao Situacao { get;  set; }
    }
}
