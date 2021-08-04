using CheckForklift.Entities.Base;
using CheckForklift.Extension;
using CheckForklift.Resources;
using prmToolkit.NotificationPattern;
using System.ComponentModel.DataAnnotations;
using VgsOrm.DataBase;

namespace CheckForklift.Entities
{
    public class Usuarios : EntityBase
    {
        public Usuarios(string user)
        {
            User = user;

        }

        public Usuarios(string user, string senha)
        {
            User = user;
            Senha = senha;

            Senha = Senha.ConvertToMD5();
        }

        public Usuarios()
        {

        }
        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true, ChavePrimaria = true)]
        public int id { get; set; }


        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBanco = true, UsarParaBuscar = true)]
        public string User { get; set; }

        [OpcoesBase(UsarNoBanco = true)]
        public string Senha { get; set; }
    }
}
