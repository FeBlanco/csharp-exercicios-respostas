Console.WriteLine("## 10 - Exercício ##\n");

Console.WriteLine($"Valor do campo ValorIpva: {Carro.ObterValorIPVA()}%");
Console.ReadKey();
internal class Carro
{
    public static double ValorIpva;

    static Carro()
    {
        ValorIpva = 4;
    }

    internal static double ObterValorIPVA()
    {
        return ValorIpva;
    }
}