using System;

namespace cs;

public class ListaDois
{

    public static void Call()
    { 
        int menu = 0;

        do{
            Console.WriteLine("1 - Calcular médias e aprovação");
            Console.WriteLine("2 - Insira um número e descubra a que mês ele representa");
            Console.WriteLine("3 - Jogo da forca");
            Console.WriteLine("4 - Tabuada de 0 a 10");
            Console.WriteLine("5 - String onde imprime linha a linha cada letra");
            Console.WriteLine("6 - Soma de números ímpares e múltiplos de 7 entre 1 a 100");
            Console.WriteLine("7 - Receber media de aluno e encerrar quando receber alguma negativa");
            Console.WriteLine("8 - Receber valor e imprimir seu fatorial");
            Console.WriteLine("9 - Cálculo de IMC");

                menu = Int32.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar :)");
                        break;
                    case 1:
                        double media, n1, n2, n3;
                        Console.WriteLine("Digite o valor da nota 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do nota 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do nota 3: ");
                        n3 = double.Parse(Console.ReadLine());
                        break;   
                    case 2:
                        Console.WriteLine("Insira um numero de 1 à 12: ");
                        int numeroMes = Int32.Parse(Console.ReadLine());
                        break; 
                    case 3:
                        break;
                    case 4:
                        tabuada();
                        break;
                    case 5:
                        break;
                    case 6:
                        ParesImparesem7();
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


                public static void calculaMedias(double n1, double n2, double n3){
                double media = (n1+n2+n3)/3;
                if(media>=7)
                    Console.WriteLine("Aprovado");
                if(media<3)
                    Console.WriteLine("Reprovado");
                if(media>=3&&media<7)
                    Console.WriteLine("Prova final");
                Console.WriteLine("O valor do media: " + media);
                Console.WriteLine();
            }

                public static void numeroMes(int numeroMes){
                switch(numeroMes)
                {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Número não tem relação com os meses do ano, tente novamente!");
                    break;    
                }
            }
            
                public static void tabuada(){
                for (int i = 0; i <= 10; i++)
                {
                Console.WriteLine("Tabuada do " + i);
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
                Console.WriteLine();
                }
            }
                public static void ParesImparesem7(){
                    int sum = 0;
                    
                    for (int p = 1; p<500;p++)
                    {
                        if(p%2 == 1 && p%7 == 0){
                            sum += p;
                        }
                    }
                    Console.WriteLine("A soma dos pares e ímpares, múltiplos de 5 entre 1 e 500 é: " +sum);
                }
    
}
