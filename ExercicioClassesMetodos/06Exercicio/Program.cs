Console.WriteLine("## 06 - Exercício ##\n");

Console.WriteLine($"Valor do campo ValorIpva: {Carro.ObterValorIPVA()}%");
Console.ReadKey();
public class Carro
{
    public static double ValorIpva;

    public static double ObterValorIPVA()
    {
        return ValorIpva += 4;
    }
}