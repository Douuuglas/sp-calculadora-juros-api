using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITaxaJurosRepository
    {
        public Task<decimal> BuscarTaxaJuros();
    }
}
