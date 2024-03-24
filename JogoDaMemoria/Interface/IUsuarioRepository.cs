using JogoDaMemoria.Models;

namespace JogoDaMemoria.Interface
{
    public interface IUsuarioRepository
    {
        void CadastrarUsuario(CadastroUsuarioM formData);

        //bool CadastrarUsuario(string formData);
        bool ValidaUsuario(string userName, string senha);
    }
}
