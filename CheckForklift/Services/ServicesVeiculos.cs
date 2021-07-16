using CheckForklift.Arguments.Veiculos;
using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories;
using CheckForklift.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace CheckForklift.Services
{
    public class ServicesVeiculos : IServicesVeiculos
    {
        readonly IRepositoryVeiculos _repositoryVeiculos;

        public ServicesVeiculos(IRepositoryVeiculos repositoryVeiculos)
        {
            _repositoryVeiculos = repositoryVeiculos;
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

        public RetornaVeiculosResponse RetornarVeiculos(RetornaVeiculosRequest request)
        {
            Usuarios user = new Usuarios(user: request.User);
            Dispositivos dispositivo = new Dispositivos(imei: request.Imei);

          //  if (user.IsInvalid() || dispositivo.IsInvalid())
            //    return null;

            List<Veiculos> ListReturn = _repositoryVeiculos.RetornarVeiculos(user: user, dispositivo: dispositivo);

            return (RetornaVeiculosResponse)ListReturn;
        }
    }
}
