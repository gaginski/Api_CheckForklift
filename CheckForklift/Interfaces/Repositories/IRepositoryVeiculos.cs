using CheckForklift.Entities;
using CheckForklift.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace CheckForklift.Interfaces.Repositories
{
    public interface IRepositoryVeiculos  
    {
        List<Veiculos> RetornarVeiculos(Usuarios user, Dispositivos dispositivo);
    }
}
