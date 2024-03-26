// Exercício: Classificação de Notas

// Escreva um programa que solicite ao usuário uma nota (em formato numérico) e utilize a estrutura de repetição if e else para determinar a classificação correspondente à nota inserida.
// O programa deve seguir as seguintes regras:

// Nota entre 0 e 49: "Insatisfatório"
// Nota entre 50 e 64: "Satisfatório"
// Nota entre 65 e 84: "Bom"
// Nota entre 85 e 100: "Excelente"
// Requisitos:

// 1. Peça ao usuário para inserir a sua nota.
// 2. Utilize a estrutura de repetição if e else para verificar em qual faixa a nota se encontra.
// 3. Exiba a classificação correspondente com base na faixa de notas.

// Lembre-se de testar o seu programa com diferentes notas para garantir que ele esteja funcionando corretamente.

Console.WriteLine("Imforme uma nota de 0 a 10:");
int nota = Convert.ToInt32(Console.ReadLine());
string message = "";

if (nota >= 0 && nota <= 49)
{
    message = "Insatisfatório";
}
else if (nota >= 50 && nota <= 64)
{
    message = "Satisfatório";
}
else if (nota >= 65 && nota <= 84)
{
    message = "Bom";
}
else if (nota >= 85 && nota <= 100)
{
    message = "Excelente";
}
else if (nota < 0 || nota > 100)
{
    message = "Resposta inválida";
}

Console.WriteLine($"{nota} - {message}");