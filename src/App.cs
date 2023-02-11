using System;
using cs;

namespace App;

    class App
    {
     static void Main (string[] args)
        {
            int menu = 0;
            do
            {
                Console.WriteLine("1 - Lista 1");
                Console.WriteLine("2 - Lista 2");
                Console.WriteLine("3 - Lista 3");
                Console.WriteLine("4 - Lista 4");
                Console.WriteLine("5 - Lista 5");
                Console.WriteLine("6 - Lista 6");

            menu = Int32.Parse(Console.ReadLine());
                switch(menu)
                {
                case 1:
                    ListaUm.Call();
                    break;
                case 2:
                    ListaDois.Call();
                    break;
                case 3:
                    ListaTres.Call();
                    break;
                case 4:
                    ListaQuatro.Call();
                    break;
                case 5: 
                    ListaCinco.Call();
                    break;
                case 6:
                    ListaSeis.Call();
                    break;
                                    
                }
            } while (menu != 0);
        }
    }
    