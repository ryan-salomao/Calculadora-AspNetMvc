namespace CalculadoraAspNetMvc.Models;

public class UserModel
{    
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public UserModel(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        Senha = senha;
    }
}