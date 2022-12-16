using DataStructuresAndAlgorithms.Algorithms.BubbleSort;

var array = new int[] {8, 4, 2, 5, 1, 3, 6, 7, 8, 4, 2, 5, 1, 3, 6, 7 };

array = BubbleSort.Sort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}