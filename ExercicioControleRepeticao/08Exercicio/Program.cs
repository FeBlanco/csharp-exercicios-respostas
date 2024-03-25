Console.WriteLine("Escreva um programa para calcular o fatorial de um número inteiro.");

double i, numero, fatorial;
Console.WriteLine("Informe um número:\t");
numero = Convert.ToInt32(Console.ReadLine());

fatorial = numero;

for (i = numero - 1; i >= 1; i--)
{
    if (i > 1)
    {
        Console.Write($"{fatorial}*{i}");
    }
    fatorial *= i;

    Console.Write(" ");
}

Console.WriteLine($"\nFatorial de {numero} é representado por: {numero}! = {fatorial}");
Console.ReadKey();
