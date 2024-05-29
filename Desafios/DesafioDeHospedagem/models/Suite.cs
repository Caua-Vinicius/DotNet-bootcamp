using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeHospedagem.models
{
    public class Suite
    {
        public string TipoSuite {set; get;}
        public int Capacidade {set; get;}
        public decimal ValorDiaria { get; set; }

        public Suite(string tipo, int capacidade, decimal valor){
            TipoSuite = tipo;
            Capacidade = capacidade;
            ValorDiaria = valor;
        }
    }
}