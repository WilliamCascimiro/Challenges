using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    //No arquivo `src / 1-round-with-precision / round-with-precision.ts`, você precisa implementar a função que arredonda o número fornecido usando os pontos de precisão decimais fornecidos.

    //O arredondamento de `33,33333` com 2 casas decimais resultaria em` 33,33` e o arredondamento com 0 casas decimais resultaria em `33`.

    public class ArredondarComPrecisao
    {
        public void Execute()
        {
            double number;
            int precision;

            Console.WriteLine("Informe o numero!");
            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a precisao!");
            precision = Convert.ToInt32(Console.ReadLine());

            double result = roundNumber(number, precision);            

            Console.WriteLine("Resultado" + result);
        }

        public double roundNumber(double number, int precision)
        {
            return Math.Round(number, precision);
        }

    }
}
