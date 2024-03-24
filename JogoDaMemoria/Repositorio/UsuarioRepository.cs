using JogoDaMemoria.Data;
using JogoDaMemoria.Interface;
using JogoDaMemoria.Models;
using JogoDaMemoria.Repositorio.Exceptions;

namespace JogoDaMemoria.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UsuarioRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CadastrarUsuario(string email, string userName, string nome, string senha, DateTime dataNascimento)
        {
            try
            {
                var usuario = new Usuario
                {
                    Email = email,
                    UserName = userName,
                    Nome = nome,
                    Senha = senha,
                    DataDeNascimento = dataNascimento,
                    DataInclusao = DateTime.Now.ToLocalTime(),
                    DataAlteracao = DateTime.Now.ToLocalTime(),
                };

                _dbContext.Usuarios.Add(usuario);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception )
            {
                return false;
            }
           

        }

        public bool ValidaUsuario(string userName, string senha)
        {
            var usuario = _dbContext.Usuarios.FirstOrDefault(u => u.Nome == userName && u.Senha == senha);

            if (usuario != null)
            {
                return true;
            }
            else
            {
                throw new FalhaLogin("Login incorreto");
            }
        }
    }
}
