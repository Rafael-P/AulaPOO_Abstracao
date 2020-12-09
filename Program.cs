using System;
using POO_Abstracao.classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            
            int opcao;
            do
            {
                Console.WriteLine("Seja Bem-Vindo(a) ao nossa sistema!");
                Console.WriteLine("Você pretende usar Boleto ou Cartão");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Boleto");
                Console.WriteLine("[2] - Cartão");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
            
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o codigo de barras do boleto");
                        boleto.codigoDeBarras = Console.ReadLine();
                    break;
                    
                    
                    case 2:

                    break;
                    
                    
                    case 0:

                    break;
                    
                    
                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }

            } while (opcao != 0);



        }//MAIN
    }
}
