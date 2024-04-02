Console.WriteLine("Exercício - Média");

int tl = 0; //quantidade de números informados
double num = 0; //numero informado pelo usuário
double total = 0; //soma dos números informados
double media = 0; //media dos números informados
int i = 0; // contador do for

Console.WriteLine("Programa que calcula a média dos números informados");
Console.Write("Quantos números deseja informar: ");
tl = Convert.ToInt32(Console.ReadLine());

for(i = 1; i <= tl ; i++)
{
    Console.Write("Informe um número: ");
    num =  Convert.ToDouble(Console.ReadLine());
    total += num;
}

media = total / tl;
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Média:  {media}");
Console.ReadKey();