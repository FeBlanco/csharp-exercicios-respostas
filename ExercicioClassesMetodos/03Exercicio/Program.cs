Console.WriteLine("## 03 - Exercício ##\n");

Carro chevrolet = new("Sedan", "Chevrolete", "Onix", 2016, 110);

Console.WriteLine("Aumentando a Potencia (por valor: + 3CV): ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado: " + chevrolet.Potencia);

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.Write("\nAumentando a Potencia (por referência: +5CV): ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);
Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado: " + ford.Potencia);

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

}