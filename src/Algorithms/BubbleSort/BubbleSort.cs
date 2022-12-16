namespace DataStructuresAndAlgorithms.Algorithms.BubbleSort
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            for (var pointer = 0; pointer < array.Length; pointer++)
            {
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap via destruction
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);

                        // Normal swap
                        /*
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp
                        */
                    }
                }
            }

            return array;
        }
    }
}