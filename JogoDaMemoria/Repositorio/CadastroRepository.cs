using JogoDaMemoria.Data;
using JogoDaMemoria.Interface;
using JogoDaMemoria.Models;

namespace JogoDaMemoria.Repositorio
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CadastroRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
    }
}
