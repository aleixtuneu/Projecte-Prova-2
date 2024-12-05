using Prova;
using System;
namespace provaPractica2
{
    public class Program
    {
        public static void Main()
        {
            Exercici5();
        }

        public static void Exercici5()
        {
            const string MsgInput = "Introdueix el valor #{0}: ";
            const string MsgError = "Error. Introdueix un valor vàlid (enter).";
            const string MsgResultA = "Llista de valors ordenada descendentment: ";
            const string MsgSearch = "Introdueix un valor per validar si està a la llista: ";
            const string MsgOk = "El valor es troba dins la llista.";
            const string MsgKo = "El valor no es troba dins la llista.";
            const int Size = 5;

            int[] list = new int[Size];
            int[] sortedList = new int[Size];
            int input = 0;

            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(MsgInput, i + 1);
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgError);
                }
                list[i] = input;
            }
            Console.WriteLine();

            // Ordenar llista
            BubbleSort(list);

            Console.WriteLine(MsgResultA);
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();



        }

        public static void BubbleSort(int[] list)
        {
            int aux = 0;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
        }
    }
}