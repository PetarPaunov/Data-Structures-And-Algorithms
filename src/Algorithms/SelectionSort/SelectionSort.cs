namespace DataStructuresAndAlgorithms.Algorithms.SelectionSort
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var smallestValue = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallestValue])
                    {
                        smallestValue = j;
                    }
                }

                // Swap via destruction
                (array[i], array[smallestValue]) = (array[smallestValue], array[i]);

                // Normal swap
                /*
                var temp = array[i];
                array[i] = array[smallestValue];
                array[smallestValue] = temp;
                 */
            }

            return array;
        }
    }
}