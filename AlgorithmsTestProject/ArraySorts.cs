namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array)
        {
            int max = array.Length - 1;
            int min = 0;

            array = quicksort(array, min, max);
        }

        private static int[] quicksort(int[] array, int min, int max)
        {
            if (min <= max)
            {
                int pi = partition(array, min, max);

                quicksort(array, min, pi - 1);
                quicksort(array, pi + 1, max);
            }

            return array;
        }

        private static int partition(int[] array, int min, int max)
        {
            int pivot = array[max];
            int i = min - 1;

            for (int j = min; j < max; j++)
            {
                if(array[j] < pivot)
                {
                    i++;
                    int tmp2 = array[i];
                    array[i] = array[j];
                    array[j] = tmp2;
                }
            }
            i++;
            int tmp = array[i];
            array[i] = array[max];
            array[max] = tmp;
            return i;
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            foreach (int i in array)
            {
                int pos = 0;
                while (pos < array.Length)
                {
                    if (pos == 0 || array[pos] >= array[pos- 1])
                    {
                        pos += 1;
                    }
                    else
                    {
                        int tmp = array[pos];
                        array[pos] = array[pos - 1];
                        array[pos - 1] = tmp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            int i, j;

            for(i = 0; i < array.Length - 1; i++)
            {
                int jMin = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[jMin])
                    {
                        jMin = j;
                    }
                }
                if (jMin != i)
                {
                    int tmp = array[i];
                    array[i] = array[jMin];
                    array[jMin] = tmp;
                }
            }
        }
    }
}
