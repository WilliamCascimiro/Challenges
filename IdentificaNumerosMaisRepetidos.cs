using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class IdentificaNumerosMaisRepetidos
    {
        //Escreva um programa que preencha um array com 20 números inteiros sorteados entre 1 e 10. Depois informe
        //qual número mais se repetiu e quantas vezes ele se repetiu.
        //Exemplo

        //Array sorteado = [2,5,8,2,8,5,3,9,6,3,4,6,3,1,2,1,2,3,7,1]
        //O número que mais se repete é o 2. 
        //Ele se repete 4 vezes

        public void Execute()
        {
            var randon = new Random();
            int[] randonList = new int[20];

            for (int i = 0; i < 20; i++)
            {
                randonList[i] = randon.Next(1, 10);
            }

            var groupedList = randonList.GroupBy(x => x).Select( x => new { number = x.Key, group = x.Count() });

            var maiorNumero = groupedList.Select(x => x).OrderByDescending(x => x.group).FirstOrDefault();

            Console.WriteLine("O número que mais se repete é o " + maiorNumero.number);
            Console.WriteLine("ele se repete " + maiorNumero.group + " vezes.");


        }
    }
}
