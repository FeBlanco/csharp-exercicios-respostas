using static System.Net.Mime.MediaTypeNames;
Console.WriteLine("## 01 - Exercício ##\n");

Carro carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
carro1.Acelerar(carro1.Marca);

Carro carro2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
carro2.Acelerar(carro2.Marca);

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

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
}
