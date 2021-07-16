using CheckForklift.Entities;
using CheckForklift.Interfaces.Arguments;
using CheckForklift.Resources;
using System;

namespace CheckForklift.Arguments.Usuario
{
    public class AutenticaUsuarioResponse : IResponse 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Usuario{ get; set; }
        public string Msg { get; set; }

        public static explicit operator AutenticaUsuarioResponse(Usuarios v)
        {
            AutenticaUsuarioResponse response = new AutenticaUsuarioResponse();

            
            if (v.User == null)
            {
                response.Msg = string.Format(Resource.X0_Invalido, "Usuario");
                return response;
            }

            response.Msg  = Resource.Operacao_realizada_com_sucesso;

            response.Nome = v.Nome;
            response.Usuario = v.User;
            
            return response;
        }
    }
}
