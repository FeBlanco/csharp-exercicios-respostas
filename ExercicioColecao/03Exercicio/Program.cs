Console.WriteLine("## 03 - Exercício array de inteiros ##\n");

// Solicita ao usuário o tamanho do array
Console.WriteLine("Informe o tamanho do array");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());

// Declara e inicializa o array com o tamanho informado
int[] meuArray = new int[tamanhoArray];

// Preenche o array com valores fornecidos pelo usuário
for (int i = 0; i < tamanhoArray; i++)
{
    Console.Write($"Informe o valor {i + 1}: ");
    meuArray[i] = Convert.ToInt32(Console.ReadLine());
}


string numero;
// Solicita ao usuário o valor a ser buscado no array
Console.WriteLine("\nPor qual valor no array você busca:");
do
{
    numero = Console.ReadLine();

    if (numero != "fim")
    {
        // Converte a entrada do usuário para inteiro
        int valor = Convert.ToInt32(numero);

        // Classifica o array em ordem crescente para usar o BinarySearch
        Array.Sort(meuArray);

        // Verifica se o valor existe no array usando BinarySearch
        if (Array.BinarySearch(meuArray, valor) >= 0)
        {
            Console.WriteLine($"\nO número {numero} Existe no array");
        }
        else
        {
            Console.WriteLine($"\nO número {numero} NÃO Existe no array");
        }
    }
}
while (numero != "fim");

Console.ReadKey();