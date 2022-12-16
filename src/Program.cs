using DataStructuresAndAlgorithms.Algorithms.BubbleSort;
using DataStructuresAndAlgorithms.Algorithms.MergeSort;
using DataStructuresAndAlgorithms.Algorithms.SelectionSort;

var array = new int[20];
var random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(20000);
}

Console.WriteLine("Start");
MergeSort.Sort(array);
Console.WriteLine("Finish");

