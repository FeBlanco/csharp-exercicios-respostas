Console.WriteLine("## 07 - Exercício ##\n");

Carro carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
carro1.Acelerar(carro1.Marca, Convert.ToInt32(carro1.Ano));

Console.ReadKey();
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

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }
    public void Acelerar(string marca, int ano)
    {
        Console.WriteLine($"Acelerando o meu {marca} do ano {ano}");
    }

}