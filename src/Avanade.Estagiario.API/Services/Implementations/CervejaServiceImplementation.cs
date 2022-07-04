
using Avanade.Estagiario.API.Domain;
using Avanade.Estagiario.API.Repositorio;

namespace Avanade.Estagiario.API.Services.Implementations
{
    public class CervejaServiceImplementation : ICervejaService
    {
        private CervejaContext _cervejaContext;
        public CervejaServiceImplementation(CervejaContext cervejaContext)
        {
            _cervejaContext = cervejaContext;
        }

        public Cerveja AtualizarCerveja(Cerveja cerveja)
        {
            var cerv = LerCerveja(cerveja.Id);
            if (cerv != null)
            {
                _cervejaContext.Entry(cerv).CurrentValues.SetValues(cerveja);
                _cervejaContext.SaveChanges();
                return cerveja;
            }
            return new Cerveja() { Nome = "Erro 404" };
        }

        public Cerveja CadastrarCerveja(Cerveja cerveja)
        {
            _cervejaContext.Add(cerveja);
            _cervejaContext.SaveChanges();
            return cerveja;
        }

        public bool ExcluirCerveja(int id)
        {
            var cerv = LerCerveja(id);

            if (cerv != null)
            {
                _cervejaContext.Cervejas.Remove(cerv);
                _cervejaContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Cerveja? LerCerveja(int id)
        {
            return _cervejaContext.Cervejas.FirstOrDefault(c => c.Id.Equals(id));
        }

        public List<Cerveja> ListarCervejas()
        {
            return _cervejaContext.Cervejas.ToList();
        }
    }
}
