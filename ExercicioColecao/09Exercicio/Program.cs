Console.WriteLine("09 - Exercícico - Sistema Simples de Cadastro de Livro ");

var livros = new List<string>();

while (true)
{
    Console.WriteLine("\nMENU PRINCIPAL");
    Console.WriteLine("1 - Cadastrar livro:");
    Console.WriteLine("2 - Listar livros:");
    Console.WriteLine("3 - Remover livro:");
    Console.WriteLine("0 - Sair\n");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do livro que deseja cadastrar:");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("Livro Cadastrado com sucesso.");
            break;

        case "2":
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }

            break;

        case "3":
            Console.WriteLine("Digite o nome do Livro que deseja remover:");

            var livroRemover = Console.ReadLine();

            var sucesso = livros.Remove(livroRemover);

            if (sucesso)
            {
                Console.WriteLine("Livro removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }

            break;

        case "0":
            Console.WriteLine("Encerrando a aplicação...");

            return;
    }
}
