using CheckForklift.Arguments.Veiculos;
using CheckForklift.Interfaces.Services.Base;

namespace CheckForklift.Interfaces.Services
{
    public interface IServicesVeiculos : IServiceBase
    {
        RetornaVeiculosResponse RetornarVeiculos(RetornaVeiculosRequest request);
    }
}
