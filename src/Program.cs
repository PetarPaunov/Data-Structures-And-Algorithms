using DataStructuresAndAlgorithms.Lists.LinkedList;

var linkedList = new MyLinkedList<int>();

linkedList.InsertLast(1);
linkedList.InsertLast(2);
linkedList.InsertLast(3);
linkedList.InsertLast(4);
linkedList.InsertLast(5);

var index = linkedList.IndexOf(3);

linkedList.InsertAt(index, 123);


// linkedList.DeleteFirst();
//linkedList.DeleteLast();
//linkedList.DeleteLast();


foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

Console.WriteLine(linkedList.IndexOf(123));
