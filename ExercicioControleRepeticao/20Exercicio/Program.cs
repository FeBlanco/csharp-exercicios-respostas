Console.WriteLine("Exercício - Número primo");

int num = 0;
int count = 0;
int i = 0;
int exit = 1;

while (exit != 0)
{
    Console.WriteLine("Número Primo");
    Console.Write("Informe um número: ");
    num = Convert.ToInt32(Console.ReadLine());

    count = 0;
    i = 1;
    while (i <= num)
    {
        if(num % i == 0)
        {
            count++;
        }
        i++;
    }
    if (count == 2)
    {
        Console.WriteLine("O valor informado é um número primo");
    }
    else
    {
        Console.WriteLine("O valor informado não é um número primo");
    }
    Console.ReadLine();
    Console.WriteLine("Digite 0 para sair");
    exit = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}
Console.ReadKey();