using DataStructuresAndAlgorithms.DataStructures.Stack;

var stack = new MyStack<string>();

stack.Push("Test1");
stack.Push("Test2");
stack.Push("Test3");
stack.Push("Test4");

foreach (var item in stack)
{
    Console.WriteLine(item);   
}