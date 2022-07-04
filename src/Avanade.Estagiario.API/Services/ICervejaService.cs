using Avanade.Estagiario.API.Domain;

namespace Avanade.Estagiario.API.Services
{
    public interface ICervejaService
    {
        Cerveja CadastrarCerveja(Cerveja cerveja);
        Cerveja? LerCerveja(int id);
        List<Cerveja> ListarCervejas();
        Cerveja AtualizarCerveja(Cerveja cerveja);
        bool ExcluirCerveja(int id);
    }
}
