using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {

        public ExampleRepository(LibreriaContext context) : base(context)
        {
            
        }

        public async Task<List<Example>> GetAll()
        {
            try
            {
                return await _context.Example.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

      
    }
}
