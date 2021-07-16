using CheckForklift.Entities.Base;
using CheckForklift.Enum;
using CheckForklift.Resources;
using prmToolkit.NotificationPattern;
using System;
using System.ComponentModel.DataAnnotations;
using VgsOrm.DataBase;

namespace CheckForklift.Entities
{
    public class Dispositivos : EntityBase
    {
        public Dispositivos(Usuarios usuario, Int64 imei, string modelo, string descricao) 
        {
            Usuario = usuario;
            Imei = imei;
            Modelo = modelo;
            Descricao = descricao;

            /*new AddNotifications(this)
                .IfNullOrInvalidLength(x => x.Imei.ToString(), 13, 13, string.Format(Resource.X0_Invalido, "Imei"))
                .IfNullOrInvalidLength(x => x.Descricao, 5, 100, string.Format(Resource.X0_Invalido, "Descricao"))
                .IfNullOrEmpty(x => x.Modelo, string.Format(Resource.X0_Invalido, "Modelo"))
                .IfNullOrEmpty(x => x.Usuario.User, string.Format(Resource.X0_Invalido, "User"));*/
        }
        public Dispositivos(long imei)
        {
            Imei = imei;
            /*
            new AddNotifications<Dispositivos>(this)
            .IfNullOrInvalidLength(x => x.Imei.ToString(), 13, 13, string.Format(Resource.X0_Invalido, "Imei"));*/
        }
        [OpcoesBase()]
        public int Id { get; private set; }
        public Usuarios Usuario { get; private set; }
        public Int64 Imei { get; private set; }
        public string Modelo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAceite { get; private set; }
        public Usuarios UsuarioAceite { get; private set; }
        public DateTime DataUltimaSincronizacao { get; private set; }
        public TSituacaoDispositivo Situacao { get; private set; }
    }
}
