using System;
using POO_Abstracao.classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            Credito credito = new Credito();
            Debito debito = new Debito();
            
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
                    //Boleto
                        Console.WriteLine($"{boleto.Desconto(12)}");
                        Console.WriteLine("Digite o codigo de barras do boleto");
                        boleto.CodigoDeBarras = Console.ReadLine();
                        Console.WriteLine("Digite o valor do boleto");
                        boleto.Valor = float.Parse(Console.ReadLine());
                        Console.Clear();
                        boleto.Registrar();
                    break;//Case 1
                    
                    case 2:
                    //Cartão
                    int escolha;
                        do
                        {
                            Console.WriteLine("Opção cartão selecionada");
                            Console.WriteLine("Credito ou Debito");
                            Console.WriteLine("[1] - Debito");
                            Console.WriteLine("[2] - Credito");
                            Console.WriteLine("[0] - Voltar");
                            escolha = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (escolha)
                            {
                                case 1:
                                //Debito
                                    Console.WriteLine("Digite o titular do seu cartão");
                                    debito.Titular = Console.ReadLine();
                                    Console.WriteLine("Digite a bandeira do seu cartão");
                                    debito.Bandeira = Console.ReadLine();
                                    Console.WriteLine("Digite o cvv do seu cartão");
                                    debito.Cvv = Console.ReadLine();
                                    Console.WriteLine("Digite o número do seu cartão");
                                    debito.Numero = Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine($"O saldo de seu cartão é de: {debito.Saldo}");
                                    Console.WriteLine($"{debito.Desconto(6)}");
                                    Console.WriteLine("Digite o valor da compra");
                                    debito.Valor = float.Parse(Console.ReadLine());
                                    debito.Registrar();
                                break;

                                case 2:
                                //Credito
                                    Console.WriteLine("Digite o titular do seu cartão");
                                    debito.Titular = Console.ReadLine();
                                    Console.WriteLine("Digite a bandeira do seu cartão");
                                    debito.Bandeira = Console.ReadLine();
                                    Console.WriteLine("Digite o cvv do seu cartão");
                                    debito.Cvv = Console.ReadLine();
                                    Console.WriteLine("Digite o número do seu cartão");
                                    debito.Numero = Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine($"O limite do seu cartão é de: {credito.Limite}");
                                    Console.WriteLine("Digite o valor da compra:");
                                    credito.Valor = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Em quantas vezes você deseja pagar");
                                    credito.parcelas = int.Parse(Console.ReadLine());
                                    credito.Pagar(credito.Valor);
                                break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                break;
                            }
                        } while (escolha != 0); //Escolha debito ou credito
                    break;//Case 2
                    

                    case 0:
                    //Sair
                        Console.WriteLine("Obrigado por utilizar nossos sistemas");
                    break;
                    
                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }

            } while (opcao != 0);



        }//MAIN
    }
}
