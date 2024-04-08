Console.WriteLine("## 04 - Exercício ##\n");

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");

double novaPotencia = ford.AumentarPotenciaVelocidade(ford.Potencia, out double velocidade);

Console.WriteLine("Nova potência: " + novaPotencia);
Console.WriteLine("Nova velocidade Máxima: " + velocidade);

Console.ReadKey();
public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

}
