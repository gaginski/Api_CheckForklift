using CheckForklift.Arguments.Utilizacao;
using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using CheckForklift.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace CheckForklift.Services
{
    public class ServicesUtilizacoes : IServicesUtilizacoes
    {
        readonly IRepositoryUtilizacao _repositoryUtilizacao;

        public ServicesUtilizacoes(IRepositoryUtilizacao repositoryUtilizacao)
        {
            _repositoryUtilizacao = repositoryUtilizacao;
        }

        public IReadOnlyCollection<Notification> Notifications => throw new System.NotImplementedException();

        public void AddNotification(string property, string message)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotification(Notification notification)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(params Notifiable[] objects)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void ClearNotifications()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool IsInvalid()
        {
            throw new System.NotImplementedException();
        }

        public bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public SalvarUtilizacaoResponse SalvarUtilizacao(SalvarUtilizacaoRequest request)
        {

            Utilizacoes utiAux = new Utilizacoes(dispositivo:  new Dispositivos(request.Imei), 
                                                                             usuario: new Usuarios(request.User), 
                                                                             veiculo: new Veiculos(request.IdVeiculo), 
                                                                             inicioUtilizacao: request.InicioUtilizacao, 
                                                                             fimUtilizacao: request.FimUtilizacao, 
                                                                             locationFim_X: request.LocationFim_X, 
                                                                             locationInic_X: request.LocationInic_X, 
                                                                             locationFim_Y: request.LocationFim_Y, 
                                                                             locationIni_Y: request.LocationIni_Y);

           // if (utiAux.IsInvalid())
               // return null;

            utiAux = _repositoryUtilizacao.SalvarUtilizacao(utiAux);

            return (SalvarUtilizacaoResponse)utiAux;

        }
    }
}
