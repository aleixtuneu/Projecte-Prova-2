using Prova;
using System;
namespace provaPractica2
{
    public class Program
    {
        const string MsgList = "Llista: ";
const string MsgSearchInput = "Introdueix un valor enter per buscar a la llista: ";
const string MsgError = "Error. Introdueix un valor vàlid.";
const string MsgOk = "El valor introduït està dins la llista.";
const string MsgKo = "El valor introduït no està dins la llista.";

int[] list = { 10, 4, 6, 4, 8, -13, 2, 3 };
int first = list[0];
int last = list[^1];
int search = 0;
int result = 0;

Console.WriteLine(MsgList);
foreach (int num in list)
{
    Console.Write(num + " ");
}
Console.WriteLine();


Console.WriteLine(MsgSearchInput);
while (!int.TryParse(Console.ReadLine(), out search))
{
    Console.WriteLine();
    Console.WriteLine(MsgError);
}
Console.WriteLine();

// Ordenar llista
// FirstSort.Order();

result = SearchClass.BinarySearch(list, list[0], list[^1], search);



if (result == -1)
{
    Console.WriteLine(MsgOk);
}
else
{
    Console.WriteLine(MsgKo);
}


// Ordenar llista
// Console.WriteLine(SecondSort.Order(list, first, last));
    }
}
