using System;

namespace Calculadora
{ 
      internal class Program
      {
        static void Main(string[] Args)
        {
            int Numero1, Numero2, operacao = 1;

            Console.WriteLine("CalculaThor\n" +
                "Ligar - 1\n " +
                "Desligar - 9");
            Console.WriteLine("Digite sua opção: ");
            int Ligar = int.Parse(Console.ReadLine());
            if (Ligar == 1)
            {

                do
                {
                    
                    Console.WriteLine("Olá! Seja Bem Vindo ao CalculaThor! \n" +
                    " 1 - Adição\n" +
                    " 2 - Subtração\n" +
                    " 3 - Multiplicação\n" +
                    " 4 - Divisão \n" +
                    " 9 - Desligar o Calculathor");

                    int menu = int.Parse(Console.ReadLine());   

                    switch (menu)
                    {

                        case 1:
                            Console.WriteLine("Digite a Primeira Parcela: ");
                            Numero1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a Segunda Parcela: ");
                            Numero2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("O Resultado da Adição é: " + Soma(Numero1, Numero2));
                            break;
                        
                        
                        case 2:
                            Console.WriteLine("Digite o Minuendo: ");
                            Numero1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o Subbtraendo: ");
                            Numero2 = int.Parse(Console.ReadLine());
                             
                            Console.WriteLine("O Resultado da Subtração é: " + Subtração(Numero1, Numero2));
                            break;


                        case 3:

                            Console.WriteLine("Digite o Primeiro Fator: ");
                            Numero1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o Segundo Fator: ");
                            Numero2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("O Resultado da Multiplicação é: " + Multiplicação(Numero1, Numero2));
                            break;

                         case 4:
                            Console.WriteLine("Digite o Dividendo: ");
                            Numero1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o Divisor: ");
                            Numero2 = int.Parse(Console.ReadLine());

                            try
                            {
                                
                                int resultD = Divisao(Numero1, Numero2);
                                Console.WriteLine($"O valor da Divisão é:  {resultD}" );

                            }
                            catch (Exception e) 
                            {

                                Console.WriteLine($"ERRO: {e}");

                            }

                            break;

                            default:
                            Console.WriteLine("Opção inválida.");
                            break;


                        case 9:
                            Console.WriteLine("Calculathor Desligada!");
                            return;
                    }
                    Console.WriteLine("Deseja fazer uma nova operação?\n" +
                     "Sim - 1\n " +
                     "Desligar - 9");
                    Console.WriteLine("Digite sua opção: ");
                   operacao = int.Parse(Console.ReadLine());


                }while (operacao != 9);
                Console.WriteLine("Calculathor Desligada!");
            }
            else
            {
                Console.WriteLine("Calculathor Desligada!");
            }

            static int Soma (int Numero1, int Numero2)
            {

                return Numero1 + Numero2;

            }

            static int Subtração (int Numero1, int Numero2)
            {

                return Numero1 - Numero2;

            }

            static int Multiplicação (int Numero1, int Numero2)
            {

                return Numero1 * Numero2;

            }

            static int Divisao(int Numero1, int Numero2)
            {

                if (DiferenteDeZero(Numero1)) throw new Exception("O Divisor Não pode ser 0");

                return Numero1 / Numero2;

                bool DiferenteDeZero (int Numero1)
                {

                    if (Numero1 == 0) return true;
                    return false;

                }
            }
        }
      }
}

