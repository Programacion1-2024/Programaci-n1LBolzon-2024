

using CEntidades.Entidades;

namespace CDatos.Repositories.Contracts
{
    public interface IExampleRepository : IRepository<Example>
    {
        Task<List<Example>> GetAll();

    }
}
