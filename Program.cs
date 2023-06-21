using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08_Estacionamento
{
    internal class Program
    {
        static List<string> vagas = new List<string> { "______", "______", "______", "______", "______" };

        static string placa;
        static int vaga;
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Bem vindo ao SISTEMA DE ESTACIONAMENTO ----------");
            Console.WriteLine("Opções:\n1- Estacionar\n2- Retirar veículo\n3- Listar veículos");
            Console.WriteLine($"O que deseja fazer?");
            string escolha = Console.ReadLine();
            int i = 0;

            if (escolha == "1")
            {
                for (i = 0; i < vagas.Count; i++)
                {
                    if (vagas[i] == "______")
                    {
                        Console.Write("Insira a placa de seu veículo: ");
                        string nova_placa = Console.ReadLine();
                        int contaPlaca = nova_placa.Count();

                        if (contaPlaca == 6)
                        {

                            vagas[i] = nova_placa.ToUpper();
                            Console.WriteLine($"O veículo de placa {vagas[i]} foi adicionado a vaga de {i}.");
                            i++;
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                            return;

                        }
                        Console.WriteLine("Placa inválida.");
                        Console.ReadKey();
                        Console.Clear();
                        Main(null);
                        return;

                    }
                }

                Console.WriteLine("O estacionamento tá lotado :/");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;

            }

            if (escolha == "2")
            {
                Console.Write("Insira a placa de seu veículo: ");
                string remover_veiculo = Console.ReadLine();


                for (i = 0; i < vagas.Count; i++)
                {
                    if (vagas[i] == remover_veiculo.ToUpper())
                    {

                        Console.WriteLine("Veículo removido.");
                        vagas[i] = "______";
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        return;

                    }

                }

                Console.WriteLine("Carro não localiazdo.");

            }

            if (escolha == "3")
            {


                Console.WriteLine($"[{vagas[0]}] [{vagas[1]}] [{vagas[2]}] [{vagas[3]}] [{vagas[4]}]");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;
            }

            else
            {
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }
        }
    }
}
