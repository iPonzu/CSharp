using System;

namespace cs 
{
    public class App
    {
    public static void Main(string[] args)
        {
            Console.WriteLine("Listagem de exercícios em C#");
            Console.WriteLine("S - Sair do programa");
            Console.WriteLine("1 - Calcule a Média");
            Console.WriteLine("2 - Calcule o volume");
            Console.WriteLine("3 - Calcule o volume");
            Console.WriteLine("4 - Avalie se um valor é maior que o dobro de outro");
            Console.WriteLine("5 - Cálculo de Bhaskara");
            Console.WriteLine("6 - Calculo da velocidade média de uma viagem, por km e tempo");
            Console.WriteLine("7 - Cálculo do percentual de imposto pago");
            Console.WriteLine("8 - Teste se um número é ímpar ou par");
            Console.WriteLine("9 - Comparando dois strings");
            Console.WriteLine("10 - Variável com ponto em string e conversão para inteiro");
            Console.WriteLine("11 - Recebendo o salário e mostrando o valor de imposto de renda");
            
            int menu = 0;
            do{
              menu = Int32.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar :)");
                        break;
                    case 1:
                        int numeroUm = 9;
                        int numeroDois = 7;
                        int numeroTres = 8;

                        Console.WriteLine($"A média é {(numeroUm + numeroDois + numeroTres)/ 3}");
                        break;   
                    case 2:
                    calcularArea();
                        break; 
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;            
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;            
                    
                    
                    default:
                    Console.WriteLine("Opção não encontrada, tente novamente");
                    break;
                }   
            } while (menu != 0);


        }

        private static void calcularArea()
        {
            int ladoUm = 10;
            int ladoDois = 5;

            Console.WriteLine($"A área calculada é {ladoUm * ladoDois}");
        }
    }
}