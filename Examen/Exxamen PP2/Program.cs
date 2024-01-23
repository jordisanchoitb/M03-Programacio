using System;
using ClassLibrary1;

namespace Program
{
    class Program
    {
        static void Main()
        {
            const string MsgSearchInput = "Introdueix el valor que vols buscar: ";
            const string MsgOrdenateArrayAsc = "Array ordenat ascendentment: ";
            const string MsgInput20numbers = "Introdueix 20 números enters: ";
            const string MsgOrdanateArrayAscQuickSort = "Array ordenat ascendentment amb QuickSort,\n a fet {0} compracions: ";
            const string MsgOrdanateArrayAscMergeSort = "Array ordenat ascendentment amb MergeSort,\n a fet {0} compracions: ";
            const string MsgOrdanateArrayAscBubleSort = "Array ordenat ascendentment amb BubleSort,\n a fet {0} compracions: ";
            int searchinputuser, compationsQuicksort = 0, comparationsMergesort = 0, comparationsBubleSort = 0;
            int[] searcharray = { 10, 4, 6, 4, 8, -13, 2, 3 };

            // Ordenem l'array ja que si volem utilitzar el BinarySearch ha d'estar ordenat
            Algorithms.QuickSort(searcharray, 0, searcharray.Length - 1, ref compationsQuicksort);
            Console.Clear();

            Console.Write(MsgSearchInput);
            searchinputuser = Convert.ToInt32(Console.ReadLine());

            int result = Algorithms.BinarySearch(searcharray, 0, searcharray.Length - 1, searchinputuser);

            if (result == -1)
            {
                Console.WriteLine("El valor no s'ha trobat");
            }
            else
            {
                Console.WriteLine("El valor s'ha trobat a la posició {0}", result);
            }

            Console.WriteLine(MsgOrdenateArrayAsc);
            for (int i = 0; i < searcharray.Length; i++)
            {
                Console.Write(searcharray[i] + " ");
            }
            Console.WriteLine();

            int[] arrayinputsdesordenate = new int[20];
            Console.WriteLine(MsgInput20numbers);
            for (int i = 0; i < arrayinputsdesordenate.Length; i++)
            {
                arrayinputsdesordenate[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arrayordenatemergeSort = arrayinputsdesordenate;
            int[] arrayordenatequickSort = arrayinputsdesordenate;
            int[] arrayordenatebubleSort = arrayinputsdesordenate;

            Console.WriteLine();
            // Ordenem l'array amb el Algoritme MergeSort
            Algorithms.MergeSort(arrayordenatemergeSort, 0, arrayordenatemergeSort.Length - 1, ref comparationsMergesort);
            Console.WriteLine(MsgOrdanateArrayAscMergeSort, comparationsMergesort);
            // Mostrem l'array ordenat
            for (int i = 0; i < arrayordenatemergeSort.Length; i++)
            {
                Console.Write(arrayordenatemergeSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Ordenem l'array amb el Algoritme QuickSort
            compationsQuicksort = 0;
            Algorithms.QuickSort(arrayordenatequickSort, 0, arrayordenatequickSort.Length - 1, ref compationsQuicksort);
            Console.WriteLine(MsgOrdanateArrayAscQuickSort, compationsQuicksort);
            // Mostrem l'array ordenat
            for (int i = 0; i < arrayordenatequickSort.Length; i++)
            {
                Console.Write(arrayordenatequickSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Ordenem l'array amb el Algoritme BubleSort
            Algorithms.BubleSort(arrayordenatebubleSort,ref comparationsBubleSort);
            Console.WriteLine(MsgOrdanateArrayAscBubleSort, comparationsBubleSort);
            // Mostrem l'array ordenat
            for (int i = 0; i < arrayordenatebubleSort.Length; i++)
            {
                Console.Write(arrayordenatebubleSort[i] + " ");
            }




        }
    }
}
