// Exercício Verificação de Maior Idade

// Escreva um programa que solicite ao usuário sua idade e utilize a estrutura de repetição
// if e else ternário para verificar se ele é maior de idade ou não. O programa deve seguir as seguintes regras:

// Se a idade for maior ou igual a 18, exiba a mensagem: "Você é maior de idade."
// Caso contrário, exiba a mensagem: "Você é menor de idade."
// Requisitos:

// Peça ao usuário para inserir sua idade.
// Utilize a estrutura de repetição if e else ternário para verificar se a idade é maior ou igual a 18.
// Exiba a mensagem apropriada com base na verificação realizada.
// Lembre-se de seguir os princípios de formatação e boas práticas de programação. Teste o seu programa para garantir que ele esteja funcionando corretamente.

Console.WriteLine("Informe sua idade: ");
var idade = Convert.ToInt32(Console.ReadLine());

var voce = idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";
Console.WriteLine(voce);
