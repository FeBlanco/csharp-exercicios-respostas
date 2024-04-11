Console.WriteLine("02 - Exercício - Jogo da adivinhação");

//array de dicas
string[] perguntas =
{
    "O que tem capa  mas não voa",
    "Sem sair do seu cantinho, é capaz de viajar ao redor do mundo.",
    "É alta quando jovem e baixinha quando fica velha. Além disso, é rápida quando é magra e lenta quando é gorda"
};

//array de respostas
string[] respostas = 
{
    "Livro", 
    "Selo",
    "Vela",
};

string jogar = "s"; //controla a repetição do programa
string resposta = ""; //armazena a leitura da resposta do usuário
int index = 0;

while (jogar == "s")
{
    //escolher a pergunta
    Random rand = new Random();
    index = rand.Next(0, respostas.Length); //dentro da faixa de valores do array 0..tamanho -1
    //Ler a resposta do usuário
    Console.WriteLine("Pergunta: {0}", perguntas[index] );
    Console.Write("Resposta: ");
    resposta = Console.ReadLine();
    if(resposta != respostas[index])
    {
        Console.WriteLine("Que pena!!! Você errou!!!");
    }
    else
    {
        Console.WriteLine("Parabens!!! Você acertou.");
    }
    Console.WriteLine("Deseja jogar novamente s/n: ");
    jogar = Console.ReadLine();
}