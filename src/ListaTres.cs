using System;

namespace cs;

public class ListaTres
{
    public static void Call()
    {
        int menu = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            menu = Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;    
                
                default:
                Console.WriteLine("Opção não identificada, tente novamente");
                break;
            }

        } while (menu != 0);

        
    }
}