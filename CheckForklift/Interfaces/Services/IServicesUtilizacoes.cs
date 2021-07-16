using CheckForklift.Arguments.Utilizacao;
using CheckForklift.Interfaces.Services.Base;

namespace CheckForklift.Interfaces.Services
{
    public interface IServicesUtilizacoes : IServiceBase
    {
        SalvarUtilizacaoResponse SalvarUtilizacao(SalvarUtilizacaoRequest request);
    }
}
