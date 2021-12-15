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
            //Declaração de array e lista
            List<int> list = new List<int> { 3, 5, 9, 8, 7, 4 };
            int[] vetor = { 7, 5, 6, 7, 8, 9, 10, 2 };

            //Funções para ordenar, vetor foi criada e da lista é do próprio C#
            OrdenacaoPorSelecao(vetor);
            list.Sort();

            //Laços para percorrer toda a lista
            Console.WriteLine("Ordeção de lista do C#: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nOrdenação Por Seleção em um Array: ");
            foreach (int item in vetor)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nPressione qualquer tecla para finalizar!");
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
