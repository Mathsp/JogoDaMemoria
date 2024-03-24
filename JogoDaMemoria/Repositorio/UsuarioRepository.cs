using JogoDaMemoria.Data;
using JogoDaMemoria.Interface;
using JogoDaMemoria.Models;
using JogoDaMemoria.Repositorio.Exceptions;
using Newtonsoft.Json;

namespace JogoDaMemoria.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UsuarioRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CadastrarUsuario(CadastroUsuarioM formData)
        {
            return;
        }

        //public bool CadastrarUsuario(string formData)
        //{
        //    try
        //    {
        //        var usuario = new Usuario();
        //         JsonConvert.PopulateObject(formData, usuario);

        //        _dbContext.Usuarios.Add(usuario);
        //        _dbContext.SaveChanges();
        //        return true;
        //    }
        //    catch(Exception )
        //    {
        //        return false;
        //    }


        //}

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
