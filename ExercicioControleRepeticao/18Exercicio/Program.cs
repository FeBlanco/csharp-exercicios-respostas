Console.WriteLine("Exercício - Eleitor");
string nome = "";
int idade = 0;

Console.WriteLine("Programa que determina a classe do eleitor");
Console.Write("Informe seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Informe sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine($"{idade} - {nome} você não possui idade para votar");
}
else
{
    if ((idade > 15 && idade < 18) || idade > 65)
    {
        Console.WriteLine($"{idade} - {nome} você é um eleitor facultativo");
    } 
    else
    {
        Console.WriteLine($"{idade} - {nome} seu voto é obrigatório");
    }
}
Console.ReadKey();