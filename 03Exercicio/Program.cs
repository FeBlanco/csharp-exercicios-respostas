Console.WriteLine("Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop\n");

int soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}");
    soma += i;
}
Console.WriteLine($"\nA soma dos números naturais é: {soma}");

Console.ReadKey();