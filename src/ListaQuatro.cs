using System;

namespace cs{

    public class ListaQuatro
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
                    
                    default:
                    Console.WriteLine("Opção não identificada, tente novamente");
                    break;
                }
            } while (menu != 0);
        }
    }
}