using System;
using System.Collections;
using System.Linq;

namespace Challenges
{
    public class NumerosPrimos2
    {
        //Função PrimoInferior($num)
        //Crie uma função que receba como parâmetro um número inteiro e retorne o maior número primo inferior ao
        // número recebido como parâmetro.Se o argumento for negativo, a função deverá retornar o valor zero.

        //Exemplo para teste:

        //Numero 10 = 7
        //Número 30 = 29/

        public void Execute()
        {
            Console.WriteLine("Escolha um numero !");
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            ArrayList numberList = new ArrayList();

            //coloca todos os numeros menores que o selecionado em uma lista descrescente
            for (int i = numeroEscolhido; i >= 3; i--)
            {
                numberList.Add(i);
            }

            var numerosPrimos = listaNumerosPrimos(numberList);

            var maiorNumeroPrimo = maiorNumero(numerosPrimos, numeroEscolhido);

            Console.WriteLine("Maior numero primo: " + maiorNumeroPrimo);
        }

        public int maiorNumero(ArrayList lista, int start)
        {
            int[] listaModificada = lista.OfType<int>().ToArray();
            return listaModificada.Where(x => x < start).Max();
        }

        public ArrayList listaNumerosPrimos(ArrayList numberList)
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
