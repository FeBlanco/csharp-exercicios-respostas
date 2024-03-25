Console.WriteLine("Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta de uma pergunta.\n O usuário pode optar por continuar respondendo a pergunta ou parar de responder.\nNão utilize a instrução break.");

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\nQual a instrução para sair de um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");

    Console.Write("\nQual a opção correta? (Tecle x para sair): ");
    string resposta = Console.ReadLine();

    Console.WriteLine(resposta.ToUpper());

    if (resposta.Equals("c", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("\nResposta correta! Você acertou.");
    }
    else if (resposta == "x" || resposta == "X")
    {
        Console.WriteLine("Saindo do programa.");
        continuar = false;
    }
    else
    {
        Console.WriteLine("\nResposta incorreta. Tente novamente.");
    }
}
Console.ReadKey();
