using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IExampleLogic
    {
        Task<List<Example>> GetAll();
    }
}
