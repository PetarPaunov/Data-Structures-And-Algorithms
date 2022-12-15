namespace DataStructuresAndAlgorithms.Lists.List
{
    using System.Collections;

    public class MyList<T> : IEnumerable<T>
    {
        private const int InitialArraySize = 2;

        private object[] array;
        private int index;
        private int count;

        public MyList()
        {
            this.array = new object[InitialArraySize];
            this.index = -1;
        }

        public void Add(T item)
        {
            Resize();

            this.index++;
            this.array[this.index] = item;
            this.count++;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                var current = this.array[i];

                if (current == null)
                {
                    return false;
                }

                if (current.Equals(item))
                {
                    Reorder(i);

                    this.count--;
                    return true;
                }
            }

            return false;
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("Message!");
            }

            for (int i = 0; i < this.array.Length; i++)
            {
                if (i == index)
                {
                    Reorder(i);

                    this.count--;
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                var current = this.array[i];

                if (current == null)
                {
                    break;
                }

                if (current.Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            this.array = new object[InitialArraySize];
            this.index = -1;
            this.count = 0;
        }

        public int Count()
            => this.count;

        private void Reorder(int i)
        {
            for (int j = i; j < this.array.Length; j++)
            {
                this.array[j] = this.array[j + 1];
                if (this.array[j + 1] == null)
                {
                    break;
                }
            }
        }

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