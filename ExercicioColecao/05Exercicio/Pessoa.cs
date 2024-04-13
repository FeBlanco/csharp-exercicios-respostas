using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Exercicio;

internal class Pessoa
{
    //a-) Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir() 
    //para imprimir o nome e a idade;
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public string Exibir()
    {
        return Nome + " - " + Idade;
    }
}
