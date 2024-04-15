Console.WriteLine("## 08 - Exercício ##\n");

Aluno alunos = new Aluno();

// Atribuindo nomes usando o indexador
alunos[0] = "João";
alunos[1] = "Maria";
alunos[2] = "Pedro";

// Obtendo os valores atribuídos usando o indexador
Console.WriteLine(alunos[0]); // Saída: João
Console.WriteLine(alunos[1]); // Saída: Maria
Console.WriteLine(alunos[2]); // Saída: Pedro

Console.ReadKey();

public class Aluno
{
    private string[] nomes = new string[10]; // Array para armazenar os nomes dos alunos

    // Indexador para acessar os nomes dos alunos
    public string this[int index]
    {
        get
        {
            // Verifica se o índice está dentro dos limites do array
            if (index >= 0 && index < 10)
            {
                return nomes[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fora do intervalo permitido.");
            }
        }
        set
        {
            // Verifica se o índice está dentro dos limites do array
            if (index >= 0 && index < 10)
            {
                nomes[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fora do intervalo permitido.");
            }
        }
    }
}