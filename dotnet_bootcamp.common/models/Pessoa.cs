using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_bootcamp.common.models
{
    public class Pessoa
    {
        public string Nome { get; set;}
        public int Idade {get; set;}

        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }
        
        public void Apresentar(){
            System.Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
