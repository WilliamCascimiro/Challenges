using System;

namespace Challenges
{
    public class Start
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Select a option");
            //int option = Convert.ToInt32(Console.ReadLine());

            int option = 8;

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
                case 5:
                    new ArredondarComPrecisao().Execute();
                    break;
                case 6:
                    new ObtenhaPrecisao().Execute();
                    break;
                case 7:
                    new DistribuicaoAutomatica().Execute();
                    break;
                case 8:
                    new BubbleSort().Execute();
                    break;
                case 9:
                    new HeapSort().Execute();
                    break;
                default:
                    Console.WriteLine("Finish");
                    break;
            }

            
        }

    }
}
