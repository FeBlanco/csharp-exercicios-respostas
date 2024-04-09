using _00ExercicioCompleto;
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }
    public int Potencia;
    public int Cor;

    public static double ValorIpva;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
        Cor = cor;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int cor = 1, int ano = 2000)
    {
        Console.WriteLine($"\nO carro de modelo: {modelo} - montadora: {montadora} - marca: {marca} \n" +
            $"potencia: {potencia} - ano: {ano} - cor: {(Cores)cor}");
    }

    public static double ObterValorIPVA()
    {
        return ValorIpva += 4;
    }
}