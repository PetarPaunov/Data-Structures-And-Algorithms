namespace DataStructuresAndAlgorithms.Algorithms.MergeSort
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            var arrayLength = array.Length;

            if (arrayLength < 2)
            {
                return;
            }

            var midIndex = arrayLength / 2;

            var leftHalf = new int[midIndex];
            var rightHalf = new int[arrayLength - midIndex];

            for (int i = 0; i < midIndex; i++)
            {
                leftHalf[i] = array[i];
            }

            for (int i = midIndex; i < arrayLength; i++)
            {
                rightHalf[i - midIndex] = array[i];
            }

            Sort(leftHalf);
            Sort(rightHalf);

            Merge(array, leftHalf, rightHalf);
        }

        private static void Merge(int[] inputArray, int[] leftHalf, int[] rightHalf)
        {
            int leftSize = leftHalf.Length;
            int rightSize = rightHalf.Length;

            // "i" is iterator for the left half
            int i = 0;

            // "j" is iteration for the right half
            int j = 0;

            // "k" is iteration for the merged array
            int k = 0;

            while (i < leftSize && j < rightSize)
            {
                if (leftHalf[i] <= rightHalf[j])
                {
                    inputArray[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    inputArray[k] = rightHalf[j];
                    j++;
                }

                k++;
            }

            while (i < leftSize)
            {
                inputArray[k] = leftHalf[i];

                i++;
                k++; 
            }

            while (j < rightSize)
            {
                inputArray[k] = rightHalf[j];

                j++;
                k++;
            }
        }
    }
}