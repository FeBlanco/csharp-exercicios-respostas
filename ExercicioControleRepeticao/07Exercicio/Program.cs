Console.WriteLine(" Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadKey();