using System;

namespace projecteProva2
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInput = "Introdueix el valor #{0}: ";
            const string MsgError = "Error. Introdueix un valor vàlid (enter).";
            const string MsgResultA = "Llista de valors ordenada descendentment: ";
            const string MsgSearch = "Introdueix un valor per validar si està a la llista: ";
            const string MsgOk = "El valor es troba dins la llista.";
            const string MsgKo = "El valor no es troba dins la llista.";
            const int Size = 20;

            int[] list = new int[Size];
            int[] sortedList = new int[Size];
            int input = 0;
            int search = 0;

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

            // Demanar valor i buscar
            Console.WriteLine(MsgSearch);
            while (!int.TryParse(Console.ReadLine(), out search))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }

            Console.WriteLine(SearchValue(list, search) ? MsgOk : MsgKo);
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

        public static bool SearchValue(int[] list, int search)
        {
            bool found = false;
            int i = 0;

            while ((i < list.Length) || found)
            {
                if (list[i] == search)
                {
                    found = true;
                }
            }

            return found;
        }
    }
}
