Console.WriteLine("Exercício - Área de um triângulo");

double a = 0; //área
double b = 0; //base
double h = 0; //altura
string entrada = "";

Console.WriteLine("Área de um triângulo");
Console.Write("Informe a base do triângulo: ");
entrada = Console.ReadLine();
b = Convert.ToDouble(entrada);

Console.Write("Informe a altura do triângulo: ");
entrada = Console.ReadLine();
h = Convert.ToDouble(entrada);

a = (b * h) / 2;

Console.WriteLine("Área de um triangulo");
Console.WriteLine($"Base: {b}\nAltura: {h}\nÁrea: {a}");
Console.ReadKey();