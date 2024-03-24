namespace JogoDaMemoria.Models
{
    public class Usuario : Main
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }

    public class CadastroUsuarioM
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
