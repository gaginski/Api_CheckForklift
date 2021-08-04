using CheckForklift.Arguments.Dispositivos;
using CheckForklift.Entities;
using CheckForklift.Enum;
using CheckForklift.Interfaces.Repositories;
using CheckForklift.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System;

namespace CheckForklift.Services
{
    public class ServicesDispositivos : Notifiable, IServicesDispositivos
    {
        private readonly IRepositoryDispositivos _repositoryDispositivos;

        public ServicesDispositivos(IRepositoryDispositivos repositoryDispositivos)
        {
            _repositoryDispositivos = repositoryDispositivos;
        }

        public AdicionarDispositivoResponse AdicionarDispositivo(AdicionarDispositivoRequest request)
        {
            Dispositivos dipAux = new Dispositivos(imei: request.Imei, 
                                                                                   modelo: request.modelo, 
                                                                                   descricao: request.modelo) ;

            dipAux = _repositoryDispositivos.AdicionarDispositivo(dipAux);

            return (AdicionarDispositivoResponse)dipAux;
        }

        public AutenticarDispositivoResponse AutenticaDispositivo(AutenticarDispositivoRequest request)
        {
            var dispositivo = new Dispositivos(imei: request.Imei);

            dispositivo = _repositoryDispositivos.RetornaDispositivoByImei(dispositivo);

           return (AutenticarDispositivoResponse)dispositivo;

        }
    }
}
