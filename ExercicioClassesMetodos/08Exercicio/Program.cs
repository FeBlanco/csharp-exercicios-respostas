Console.WriteLine("## 08 - Exercício ##");

Cliente cliente = new Cliente();
cliente.Nome = "Maria";
cliente.Email = "teste@email.com";
cliente.Idade = 20;

cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email, idade: cliente.Idade);
cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email);

Console.ReadKey();

public struct Cliente
{
    public string? Nome;
    public string? Email;

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                Console.WriteLine("Cliente maior que 18 anos");
                idade = value;
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"\nNome: {nome} \nEmail: {email}  \nIdade: {idade}");
    }
}