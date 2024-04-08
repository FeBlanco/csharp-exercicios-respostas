using static System.Net.Mime.MediaTypeNames;
Console.WriteLine("## 02 - Exercício ##\n");

Carro carro = new Carro("Sedan", "Toyota");
double velocidade = carro.VelocidadeMaxima(100);
Console.WriteLine(velocidade);


Console.ReadKey();
public class Carro
{
    public string? Modelo;
    public string? Montadora;

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}