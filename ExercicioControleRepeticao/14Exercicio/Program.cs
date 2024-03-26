// Exercício: Verificação de Número Par ou Ímpar

// Escreva um programa que solicite ao usuário um número inteiro e utilize a estrutura de repetição
// if e else ternário para verificar se o número inserido é par ou ímpar. O programa deve seguir as seguintes regras:

// Se o número for par, exiba a mensagem: "O número é par."
// Caso contrário, exiba a mensagem: "O número é ímpar."
// Requisitos:

// Peça ao usuário para inserir um número inteiro.
// Utilize a estrutura de repetição if e else ternário para verificar se o número é par ou ímpar.
// Exiba a mensagem apropriada com base na verificação realizada.
// Lembre-se de seguir os princípios de formatação e boas práticas de programação.
// Teste o seu programa com diferentes números para garantir que ele esteja funcionando corretamente.


Console.WriteLine("Informe um Número inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());

var resultado = numero % 2 == 1 ? "Número ímpar" : "O número é par";
Console.WriteLine(resultado);