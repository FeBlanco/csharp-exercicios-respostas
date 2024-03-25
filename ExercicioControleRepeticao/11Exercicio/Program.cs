Console.WriteLine("Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros.\n");

Console.WriteLine("Informe o primeiro número:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o operando (+, -, /, *):");
var operador = Console.ReadLine();

Console.WriteLine("Informe o segundo número:");
int y = Convert.ToInt32(Console.ReadLine());

if (operador == "+")
{
    Console.WriteLine($"A soma de {x} + {y} = {x + y}");
}
else if (operador == "-")
{
    Console.WriteLine($"A subtração de {x} - {y} = {x - y}");
}
else if (operador == "*")
{
    Console.WriteLine($"A multiplicação de {x} * {y} = {x * y}");
}
else if (operador == "/")
{
    if (x != 0 && y != 0)
    {
        Console.WriteLine($"A divisão de {x} / {y} = {(float)x / y}");
    }
    else
    {
        Console.WriteLine("Não existe divisão por zero !!!");
    }
}
else
{
    Console.WriteLine("Operador ou Número inválido");
}

Console.ReadKey();