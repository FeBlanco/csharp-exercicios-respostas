Console.WriteLine("## 05 - Exercício ##\n");

Carro ford1 = new();
Console.WriteLine("Sem informar o parâmetro opcional Ano");
ford1.ExibirInfo(modelo: "SUV", marca: "Ford", montadora: "EcoSport", potencia: 120);

Console.WriteLine("\nInformando o parâmetro opcional Ano");
ford1.ExibirInfo(modelo: "SUV", marca: "Ford", montadora: "EcoSport", potencia: 120, ano: 2023);

Console.ReadKey();
public class Carro
{

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0)
    {
        Console.WriteLine($"\nO carro de modelo: {modelo} - montadora: {montadora} - marca: {marca} \n" +
            $"potencia: {potencia} - ano: {ano}");
    }

}