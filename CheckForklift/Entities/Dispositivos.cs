using CheckForklift.Entities.Base;
using CheckForklift.Enum;
using CheckForklift.Resources;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VgsOrm.DataBase;

namespace CheckForklift.Entities
{
    public class Dispositivos : EntityBase
    {
        public Dispositivos( string imei, string modelo, string descricao) 
        {
            validaNewDispositivo( imei, modelo);

            Imei = imei;
            Modelo = modelo;
            Descricao = descricao;

        }

        private bool validaNewDispositivo(string imei, string modelo)
        {
            List<String> msgException = new List<string>();

            if(string.IsNullOrWhiteSpace(imei) || imei.Length != 15)
                msgException.Add("Imei inválido");

            if (string.IsNullOrWhiteSpace(modelo))
                msgException.Add("Modelo inválido");

            if(msgException.Count > 0)
                throw new Exception(string.Format(Resources.Resource.SolicitacaoIncorreta, string.Join(", ", msgException.ToArray())));

            return true;
        }

        private bool validaDispositivoExistente(string imei)
        {
            List<String> msgException = new List<string>();

           
            if (string.IsNullOrWhiteSpace(imei) || imei.Length != 15)
                msgException.Add("Imei inválido");

            if (msgException.Count > 0)
                throw new Exception(string.Format(Resources.Resource.SolicitacaoIncorreta, string.Join(", ", msgException.ToArray())));

            return true;
        }
        public Dispositivos(string imei)
        {
            Imei = imei;

        }

        public Dispositivos()
        {
            Id = 0;
            Usuario_id = 0;
            Imei = null;
            Modelo = null;
            Descricao = null;
            DataCadastro = DateTime.Now;
            DataAceite = DateTime.Now;
            UsuarioAceite_id = 0;
            DataUltimaSincronizacao = DateTime.MinValue;
            Situacao = 0;
        }

        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true, ChavePrimaria =true, AutoIncremento =true)]
        public int Id { get; private set; }

        public int Usuario_id { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public string Imei { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public string Modelo { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public string Descricao { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public DateTime DataCadastro { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public DateTime DataAceite { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public int UsuarioAceite_id { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public DateTime DataUltimaSincronizacao { get; private set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public TSituacaoDispositivo Situacao { get; private set; }
    }
}
