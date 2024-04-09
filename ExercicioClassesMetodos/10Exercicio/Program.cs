using _00ExercicioCompleto;
Console.WriteLine("## 00 - Exercício ##");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("\nSelecione a Cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
//Console.Write("Informando o parâmetro opcional Ano");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano, cor: chevrolet.Cor);
chevrolet.Acelerar(chevrolet.Marca);
//Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" +
//                  $" {chevrolet.Ano} {chevrolet.Potencia} CV");

Console.WriteLine($"\nAumentando a Potencia do {chevrolet.Marca} (por valor: +3CV): ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.Write($"-> {novaPotenciaChevrolet}");
Console.WriteLine($"\nO valor do campo Potencia não foi alterado: {chevrolet.Potencia}");

//Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");
double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine($"Nova potência: {novaPotencia}");
Console.WriteLine($"Nova velocidade Máxima: {velocidade}");


Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120, cor);
//Console.WriteLine("Sem informar o parâmetro opcional Ano");
ford.ExibirInfo(modelo: ford.Modelo, montadora: ford.Montadora, marca: ford.Marca, ford.Potencia);
ford.Acelerar(ford.Marca);

//Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" +
//                  $" {ford.Ano} {ford.Potencia} CV");

Console.Write($"\nAumentando a Potencia do {ford.Marca} (por referência: +5CV): ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);
Console.Write($"-> {novaPotenciaFord}");
Console.WriteLine($"\nO valor do campo Potencia foi alterado: {ford.Potencia}");

Carro ford2 = new("SUV", "Ford");
double novaVelocidade = ford2.VelocidadeMaxima(100);
Console.WriteLine($"\nA velocidade do {ford2.Modelo} é {novaVelocidade} km\n");

Console.WriteLine($"Valor do Ipva: {Carro.ObterValorIPVA()}%\n");

Console.ReadKey();