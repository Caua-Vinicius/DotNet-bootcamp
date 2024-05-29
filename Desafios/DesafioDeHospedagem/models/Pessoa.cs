using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeHospedagem.models
{
    public class Pessoa
    {
        private string Nome {set; get;}
        private string Sobrenome {set; get;}
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}