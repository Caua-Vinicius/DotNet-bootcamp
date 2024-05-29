using System.Text;
using DesafioDeHospedagem.models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede", sobrenome: "1"); 
Pessoa p2 = new Pessoa(nome: "Hospede", sobrenome: "2"); 

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suite
Suite suite =  new Suite(tipo:"Premium", capacidade: 3, valor: 30);

Reserva reserva = new Reserva();