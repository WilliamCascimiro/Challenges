using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class ObtenhaPrecisao
    {
        //No arquivo `src / 2-get-precision / get-precision.ts`, você precisa implementar uma função que retorna a quantidade de pontos de precisão decimais para um determinado número.

        //`12,25` tem 2 pontos de precisão decimal. `12.2` tem 1 ponto de precisão decimal. `12,250000` tem 2 pontos de precisão decimal (porque é igual a` 12,25`).


        public void Execute()
        {
            string number;

            Console.WriteLine("Informe o numero!");
            number = Console.ReadLine();

            string result = verify(number);  

            

            Console.WriteLine("Resultado" + result);
        }

        public string verify(string number)
        {

            var result = number
                            .Replace(',', '.')
                            .Split('.')
                            .Last()
                            .TrimEnd('0')
                            .Count()
                            .ToString();
            return result;
        }

    }
}
