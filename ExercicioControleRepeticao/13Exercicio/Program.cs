// Exercício: Calculadora de IMC

// Escreva um programa que calcule o Índice de Massa Corporal (IMC) de uma pessoa com base no peso e na altura fornecidos pelo usuário.
// O IMC é calculado pela fórmula:

// IMC = peso / altura * altura
// O programa deve seguir as seguintes regras:

// Solicite ao usuário o seu peso (em quilogramas) e a sua altura (em metros).

// Calcule o IMC utilizando a fórmula fornecida.

// Utilize a estrutura de repetição if e else para determinar a classificação do IMC de acordo com a tabela a seguir:

// Abaixo de 18.5: Abaixo do Peso
// 18.5 a 24.9: Peso Normal
// 25 a 29.9: Sobrepeso
// 30 a 34.9: Obesidade Grau I
// 35 a 39.9: Obesidade Grau II
// 40 ou mais: Obesidade Grau III
// Exiba o valor do IMC calculado e a classificação correspondente.

// Requisitos:

// 1. Peça ao usuário para inserir o seu peso e a sua altura.
// 2. Calcule o IMC utilizando a fórmula fornecida.
// 3. Utilize a estrutura de repetição if e else para determinar a classificação do IMC.
// Exiba o valor do IMC e a classificação correspondente.
// Lembre-se de testar o seu programa com diferentes valores de peso e altura para garantir que ele esteja funcionando corretamente.

using System.Globalization;

float peso, altura, imc;
Console.Write("Digite seu peso (em kg): ");
peso = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
Console.Write("Digite sua altura (em centímetros): ");
altura = float.Parse(Console.ReadLine()) / 100;  // Convertendo a altura para metros

imc = peso / (altura * altura);
//var resultado = imc;

string classificacao;

if (imc < 18.5)
{
    classificacao = "Abaixo do peso";
}
else if (imc <= 24.9)
{
    classificacao = "Peso Normal";
}
else if (imc <= 29.9)
{
    classificacao = "Sobrepeso";
}
else if (imc <= 34.9)
{
    classificacao = "Obesidade Grau I";
}
else if (imc <= 39.9)
{
    classificacao = "Obesidade Grau II";
}
else
{
    classificacao = "Obesidade Grau III";
}

string imcFormatado = string.Format("{0:0.0}", imc); // Formatando a saída do IMC

Console.WriteLine($"Seu IMC é de: {imcFormatado} ({classificacao})");