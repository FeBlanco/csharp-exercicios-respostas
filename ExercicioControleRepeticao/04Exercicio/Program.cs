Console.WriteLine(" Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado\n");

while (true)
{
    int resultado, numero;
    Console.WriteLine("Informe o número inteiro: \t");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        for (int i = 1; i <= 10; i++)
        {
            resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
    else
    {
        Console.WriteLine("\nNúmero inválido");
    }

    Console.Write("\nDeseja calcular a tabela para outro número? (S para Sim, qualquer outra tecla para sair): ");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() != "S")
    {
        Console.WriteLine("Saindo do programa.");
        break;
    }
}
Console.ReadKey();
