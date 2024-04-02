Console.WriteLine("Exercício - Quociente e resto");

int n1 = 0; //número que será dividido
int n2 = 0; //divisor
int r = 0; //resto da divisão
double q = 0; //Quociente  da divisão

Console.WriteLine("Programa que efetua a divisão de dois números");
Console.Write("Informe o primeiro número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
n2 = Convert.ToInt32(Console.ReadLine());

q = n1 / n2;
r = n2 % n1;

Console.WriteLine("Resposta da divisão");
Console.WriteLine($"{n1} / {n2} = {q}");
Console.WriteLine($"Resto: {r}");
Console.ReadKey();