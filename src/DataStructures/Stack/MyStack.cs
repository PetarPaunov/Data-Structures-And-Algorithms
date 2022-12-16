namespace DataStructuresAndAlgorithms.DataStructures.Stack
{
    using System.Collections;

    public class MyStack<T> : IEnumerable<T>
    {
        private const int InitialArraySize = 2;

        private T top;
        private int count;
        private int index;
        private object[] array;

        public MyStack()
        {
            this.array = new object[InitialArraySize];
            this.index = -1;
        }

        public void Push(T data)
        {
            this.Resize();

            this.index++;
            this.array[this.index] = data;
            this.count++;

            this.top = data;
        }

        public T Pop()
        {
            if (this.array[0] == null)
            {
                return default(T);
            }

            var itemToReturn = this.array[this.index];

            this.top = (T)this.array[this.index - 1];
            this.array[this.index] = null;

            this.index--;
            return (T)itemToReturn;
        }

        public T Peek()
            => this.top;

        public int Count() 
            => this.count;

        private void Resize()
        {
            if (!ShouldResize()) return;

            var newArraySize = this.array.Length * 2;
            var tempArray = new object[newArraySize];

            for (var i = 0; i < this.array.Length; i++)
            {
                tempArray[i] = this.array[i];
            }

            this.array = tempArray;
        }

        private bool ShouldResize()
            => this.count + 1 == this.array.Length - 1;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.array)
            {
                if (item == null)
                {
                    break;
                }

                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}