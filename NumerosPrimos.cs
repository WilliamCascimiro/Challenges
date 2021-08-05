using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class NumerosPrimos
    {
        //Função PrimoInferior (2)($num)
        //Crie uma função em que o usuário pode informar uma lista de numeross inteiros e retorne o maior número primo.
        //Se o argumento for negativo, a função deverá retornar o valor zero.

        //Exemplo para teste:

        //Numeros [10, 7, 6, 8] = 7
        //Numeros [30, 7, 13, 8] = 29

        public void Execute()
        {
            Console.WriteLine("Quantos numeros quer adcionar a lista ?");
            int qtdNumeros = Convert.ToInt32(Console.ReadLine());
            var numberList = new int[qtdNumeros];


            for (int i= 0; i<qtdNumeros; i++)
            {
                Console.WriteLine("informe o numero para a lista!");
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("NUmeros selecionado");
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            Array.Sort(numberList);
            Array.Reverse(numberList);

            Console.WriteLine("Numeros ordenados");
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            var numerosPrimos = listaNumerosPrimos(numberList);
            var maior = maiorNumero(numberList, 10); 



            Console.WriteLine("Numeros primos");
            foreach (var number in numerosPrimos)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Maior numero primo abaixo de 10");
            Console.WriteLine(maior);

            //do
            //{
            //    i++;

            //} while (!Int32.TryParse(year, out integer));

            //int century = (Convert.ToInt32(year) / 100);
            //double increment = (Convert.ToDouble(year) % 100.0);

            //if (increment > 0)
            //    century++;

            //Console.WriteLine("Century" + century);
        }

        public int maiorNumero(int[] lista, int start)
        {
            return lista.Where(x => x < start).Max();
        }

        public ArrayList listaNumerosPrimos(int[] numberList)
        {
            var numerosPrimos = new ArrayList();

            foreach (int number in numberList)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0 && i != number)
                    {
                        break;
                    }
                    if (number % i == 0 && i == number)
                    {
                        numerosPrimos.Add(number);
                        break;
                    }

                }
            }

            return numerosPrimos;
        }


    }
}
