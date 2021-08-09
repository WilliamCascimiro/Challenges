using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class DistribuicaoAutomatica
    {
        public void Execute()
        {
            double numero;
            int partes;
            int precisao;

            Console.WriteLine("Informe o numero!");
            numero = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Em quantas partes quer dividir ?");
            partes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a precisao ?");
            precisao = Convert.ToInt32(Console.ReadLine());

            var resultados = distribui(numero, partes, precisao);



            Console.WriteLine("resultado: \r");
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }

        }

        public Array distribui(double number, int partes, int precisao)
        {
            var array = new double[partes];
            double result = Math.Round((number / partes), precisao);

            for (var i = 0; i < partes; i++)
            {
                array[i] = result;
            }

            double resto = Math.Round((number - (result*partes)), precisao);
            var qtdDivideResto = resto / 0.01;

            int position = -1;
            for (var i = 0; i < qtdDivideResto; i++)
            {
                if (position < (partes-1))
                    position++;
                else
                    position = 0;

                array[position] = array[position] + 0.01;
            }

            var resultado = array.Select(x => Math.Round(x, precisao)).ToArray();

            return resultado;
        }

    }
}
