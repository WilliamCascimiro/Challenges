using System;

namespace Challenges
{
    public class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    new IdentifyCentury().Execute();
                    break;
                case 2:
                    new NumerosPrimos().Execute();
                    break;
                case 3:
                    new NumerosPrimos2().Execute();
                    break;
                case 4:
                    new IdentificaNumerosMaisRepetidos().Execute();
                    break;
                default:
                    Console.WriteLine("Finish");
                    break;
            }

            
        }

    }
}
