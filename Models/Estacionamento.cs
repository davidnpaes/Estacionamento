using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal valorInicial;
        public decimal valorPorHora;
        private List<string> listaDeVeiculos = new List<string>();

        public void CadastrarVeiculo(string placa)
        {
            placa = placa.ToUpper();
            listaDeVeiculos.Add(placa);
            Console.WriteLine("Veículo Cadastrado!");
        }

        public void RemoverVeiculo(string placa)
        {
            placa = placa.ToUpper();
            listaDeVeiculos.Remove(placa);
            Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
            CalcularPreco(int.Parse(Console.ReadLine()));
        }

        private void CalcularPreco(int horas)
        {
            Console.WriteLine($"Valor a ser pago: R$ {valorPorHora * horas + valorInicial}");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos Estacionados: \n");
            foreach (string veiculo in listaDeVeiculos)
            {
                Console.WriteLine($"- {veiculo}");
            }
        }


    }
}