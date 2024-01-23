namespace ClassLibrary1
{
    public static class Algorithms
    {
        public static int BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);
                }
            }
            return -1;
        }

        public static void CompleteMergeSort(int[] v, int left, int m, int right)
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            {
                if (v[i] < v[j]) { aux[k] = v[i]; ++i; }
                else { aux[k] = v[j]; ++j; }
                ++k;
            }
            while (i <= m) { aux[k] = v[i]; ++i; ++k; }
            while (j <= right) { aux[k] = v[j]; ++j; ++k; }
            for (k = 0; k < n; ++k) v[left + k] = aux[k];
        }

        public static void MergeSort(int[] v, int left, int right, ref int comparationsmergeSort)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                MergeSort(v, left, m, ref comparationsmergeSort);
                MergeSort(v, m + 1, right, ref comparationsmergeSort);
                CompleteMergeSort(v, left, m, right);
                comparationsmergeSort++;
            }
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Divide(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        public static void QuickSort(int[] arr, int low, int high, ref int comparationsquickSort)
        {
            if (low < high)
            {
                int pi = Divide(arr, low, high);
                QuickSort(arr, low, pi - 1, ref comparationsquickSort);
                QuickSort(arr, pi + 1, high, ref comparationsquickSort);
                comparationsquickSort++;
            }
        }

        public static void BubleSort(int[] arr, ref int comparationsbubleSort)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //bucle intern, cerca entre la resta de posicions quin és el valor més baix
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //si la posició tractada té un valor més alt que el de la cerca, els intercanviem
                    if (arr[i] > arr[j])
                    {
                        //per intercanviar valors cal una variable auxiliar
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                    comparationsbubleSort++;
                }
            }
        }
    }
}
