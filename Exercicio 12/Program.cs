using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 7, 5, 6, 7, 8, 9, 10, 2 };
            OrdenacaoPorSelecao(vetor);

            Console.WriteLine("Ordenação Por Seleção: ");
            foreach (int item in vetor)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }

        static int[] OrdenacaoPorSelecao(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }
    }
}
