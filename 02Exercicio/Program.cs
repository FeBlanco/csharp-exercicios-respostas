
Console.WriteLine("Cálculo da equação do segundo grau (ax^2 + bx + c):\n");

Console.Write("Informe o valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de c: ");
int c = Convert.ToInt32(Console.ReadLine());

// Calculando o discriminante
int discriminante = b * b - 4 * a * c;

if (discriminante > 0)
{
    // Duas raízes reais
    double raiz1 = (-b + Math.Sqrt(discriminante)) / (2.0 * a);
    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2.0 * a);

    Console.WriteLine($"As raízes são reais e diferentes: {raiz1} e {raiz2}");
}
else if (discriminante == 0)
{
    // Uma raiz real (raiz dupla)
    double raiz = -b / (2.0 * a);
    Console.WriteLine($"A raiz é real e dupla: {raiz}");
}
else
{
    // Raízes imaginárias
    Console.WriteLine("As raízes são imaginárias; sem solução para os números reais.");
}

Console.ReadLine();

