using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08_Estacionamento
{
    internal class Program
    {
        static List<string> Carros2 = new List<string>();
        static string placa;
        static int vaga, posicao1 = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("---------- Bem vindo ao SISTEMA DE ESTACIONAMENTO ----------");
            Console.WriteLine("Opções:\n1- Estacionar\n2- Retirar veículo\n3- Listar veículos");
            Console.WriteLine($"O que deseja fazer?");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.Write("Insira a placa do veículo que deseja estacionar: ");
                placa = Console.ReadLine();

                if (placa.Length != 6)
                {

                    Console.WriteLine("Placa inválida.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }
                Console.ReadKey();
            }


        }
    }
}