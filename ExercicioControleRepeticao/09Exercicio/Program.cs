Console.WriteLine("Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhados\n");

int numero = 2;
int contador = 1;


if (numero > 0)
{
    while (numero <= 6)

    {
        Console.WriteLine($"\n## Tabuada do {numero} ##\n");
        contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }
        numero++;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!!");
}

Console.WriteLine("\nFim do processameento...");
Console.ReadKey();

Console.ReadKey();