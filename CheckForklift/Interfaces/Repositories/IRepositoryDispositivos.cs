using CheckForklift.Arguments.Dispositivos;
using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories.Base;
using System;

namespace CheckForklift.Interfaces.Repositories
{
    public interface IRepositoryDispositivos
    {
        Dispositivos AdicionarDispositivo(Dispositivos Dispo);

        Dispositivos RetornaDispositivoByImei(Dispositivos Dispo);
    }
}
