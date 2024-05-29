using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeHospedagem.models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes){
             // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count<=Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public void ObterQuantidadeHospedes(){
            Console.WriteLine($"Quantidade de Hospedes{Hospedes.Count}");
        }

        public void CalcularValorDiaria(){
            if (DiasReservados>=10)
            {
                Console.WriteLine($"Valor da diaria{DiasReservados * Suite.ValorDiaria * (9/10)}");
            }else{
                Console.WriteLine($"Valor da diaria{DiasReservados * Suite.ValorDiaria}");
            }


        }
    }
}