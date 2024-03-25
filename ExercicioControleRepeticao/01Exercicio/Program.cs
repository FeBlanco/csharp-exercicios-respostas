Console.WriteLine("## Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior ##\n");

Console.WriteLine("Informe o Primeiro Número: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o Segundo Número: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o Terceiro Número: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nPrimeiro Número: {a}");
Console.WriteLine($"Segundo Número: {b}");
Console.WriteLine($"Terceiro Número: {c}");


if (a > b && a > c)
{
    Console.WriteLine($"\nO primeiro número: {a} é o maior");
}
else if (b > a && b > c)
{
    Console.WriteLine($"\nO segundo número: {b} é o maior");
}
else if (c > a && c > b)
{
    Console.WriteLine($"\nO terceiro número: {c} é o maior");
}
else
{
    Console.WriteLine($"\nContém números iguais");
}


Console.WriteLine("\nFim do processamento...");
Console.ReadLine();
