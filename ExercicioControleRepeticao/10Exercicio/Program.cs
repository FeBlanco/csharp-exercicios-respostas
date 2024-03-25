Console.WriteLine(" Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um aluno. \nCom base na tabela a seguir imprima no console qual o resultado da avaliação do aluno");
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nInforme a nota do aluno(a) de 1 a 10 - (Tecle x para sair)");
    int nota = Convert.ToInt32(Console.ReadLine());


    if (nota >= 0 && nota <= 10)
    {
        switch (nota)
        {
            case 10:
                Console.WriteLine($"Avaliação: {nota} A+");
                break;
            case 9:
                Console.WriteLine($"Avaliação: {nota} A");
                break;
            case 8:
            case 7:
                Console.WriteLine($"Avaliação: {nota} B");
                break;
            case 6:
                Console.WriteLine($"Avaliação: {nota} C");
                break;
            case 5:
                Console.WriteLine($"Avaliação: {nota} D");
                break;
            case 4:
            case 3:
                Console.WriteLine($"Avaliação: {nota} E");
                break;
            default:
                Console.WriteLine($"Avaliação: {nota} F");
                break;
        }
    }
    else if (nota.ToString() == "x" || nota.ToString() == "X")
    {
        Console.WriteLine("Saindo do programa.");
        continuar = false;
    }
    else
    {
        Console.WriteLine("\nNota inválida. Informe uma nota de 0 a 10.");
    }

}

Console.ReadKey();
