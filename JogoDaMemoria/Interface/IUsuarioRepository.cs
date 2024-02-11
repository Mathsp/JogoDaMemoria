namespace JogoDaMemoria.Interface
{
    public interface IUsuarioRepository
    {
        bool CadastrarUsuario(string email, string userName, string nome, string senha, DateTime dataNascimento);
    }
}
