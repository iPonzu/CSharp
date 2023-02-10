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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

       
            menu = Int32.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar :)");
                        break;
                    case 1:
                        calculaMedias(10, 9, 7);
                        Console.WriteLine("Insira suas notas: ");
                        double notas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("" + notas);
                        break;   
                    case 2:
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


                public static void calculaMedias(double n1, double n2, double n3){
                double notas = (n1 + n2 + n3) /3;

                if (notas >= 7)
                {
                    Console.WriteLine("\n Você foi aprovado!");
                }else if(notas <= 7)
                {
                    Console.WriteLine("\n Você foi reprovado :/");
                }

            }

}