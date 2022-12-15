namespace DataStructuresAndAlgorithms.Lists.LinkedList
{
    using System.Collections;

    public class MyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> lastItem;
        private int count;
        private int index;

        public void InsertFirst(T data)
        {
            var newNode = new Node<T>
            {
                Data = data,
                Next = this.head,
                Index = this.index
            };

            this.lastItem ??= newNode;

            this.head.Previous = newNode;

            this.head = newNode;

            this.index++;
            this.count++;
        }

        public void InsertLast(T data)
        {
            var newNode = new Node<T>
            {
                Data = data,
                Index = this.index
            };

            this.head ??= newNode;

            if (this.lastItem == null)
            {
                this.lastItem = newNode;
            }
            else
            {
                this.lastItem.Next = newNode;

                newNode.Previous = this.lastItem;

                this.lastItem = newNode;
            }

            this.index++;
            this.count++;
        }

        public void InsertAt(int index, T data)
        {
            var current = this.head;

            while (current != null)
            {
                if (current.Index == index)
                {
                    current.Data = data;

                    break;
                }
                current = current.Next;
            }

            this.index--;
            this.count--;
        }

        public void DeleteAt(int index)
        {
            var current = this.head;

            while (current != null)
            {
                if (current.Index == index)
                {
                    var currentNext = current.Next;
                    var currentPrevious = current.Previous;

                    currentNext.Previous = currentPrevious;
                    currentPrevious.Next = currentNext;

                    AdjustIndices(currentNext);

                    break;
                }
                current = current.Next;
            }

            this.index--;
            this.count--;
        }

        public void DeleteLast()
        {
            var newLast = this.lastItem.Previous;
            newLast.Next = null;

            this.lastItem = newLast;

            this.index--;
            this.count--;
        }

        public Node<T> DeleteFirst()
        {
            var deletedItem = this.head;
            this.head = this.head.Next;

            if (this.lastItem == this.head)
            {
                this.lastItem = null;
            }

            this.index--;
            this.count--;

            return deletedItem;
        }

        public int IndexOf(T data)
        {
            var current = this.head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current.Index;
                }
                current = current.Next;
            }

            return -1;
        }

        public int Count()
            => this.count;

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void AdjustIndices(Node<T> currentNext)
        {
            while (currentNext != null)
            {
                currentNext.Index--;

                currentNext = currentNext.Next;
            }
        }
    }
}