using System;
using System.Diagnostics;

namespace Challenges
{
    public class BubbleSort
    {
        public void Execute()
        {
            var sw = new Stopwatch();

            int[] randonList = new int[5000];
            var randon = new Random();

            for (int i = 0; i < randonList.Length; i++)
            {
                randonList[i] = randon.Next(1, 100);
            }

            //sw.Start();
            //Array.Sort(randonList);
            //sw.Stop();
            //Console.WriteLine("Tempo gasto : " + sw.ElapsedMilliseconds.ToString() + " milisegundos");

            //sw.Restart();

            //sw.Start();
            //Ordenar(randonList);
            //sw.Stop();
            //Console.WriteLine("Tempo gasto : " + sw.ElapsedMilliseconds.ToString() + " milisegundos");

            sw.Start();
            bubbleSort(randonList);
            sw.Stop();
            Console.WriteLine("Tempo gasto : " + sw.ElapsedMilliseconds.ToString() + " milisegundos");





        }

        public void Ordenar(int[] randonList)
        {
            for (int i = 0; i < randonList.Length; i++)
            {
                if (i >= randonList.Length - 1)
                {
                    if (VerificaOrdenacao(randonList))
                    {
                        //Console.WriteLine("Lista ordenada");
                        //foreach (int number in randonList)
                        //{
                        //    Console.WriteLine(number);
                        //}
                        break;
                    }
                    else
                    {
                        i = -1;
                        continue;
                    }
                }

                int numeroCorrente = randonList[i];
                int proximoNumero = randonList[i + 1];

                if (numeroCorrente > proximoNumero)
                {
                    randonList[i] = proximoNumero;
                    randonList[i + 1] = numeroCorrente;
                }
            }
        }

        public bool VerificaOrdenacao(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length-1)
                    return true;

                if (array[i] > array[i+1])
                    return false;
            }
            return true;
        }

        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }



    }
}
