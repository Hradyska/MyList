using System.Collections.Generic;
namespace List
{
    internal class MyList<T>
    {
        private T[] _list;
        private int _length;
        public MyList()
        {
            _list = new T[0];
            _length = 0;
        }

        public MyList(int length)
        {
            _length = length;
            _list = new T[length];
        }

        public MyList<T> Add(T item)
        {
            if (_length == 0)
            {
                _list = new T[1] { item };
                _length = 1;
                return this;
            }

            T[] newList = new T[_length + 1];
            for (int i = 0; i < _length; i++)
            {
                newList[i] = _list[i];
            }

            newList[newList.Length - 1] = item;
            _list = newList;
            _length += 1;
            return this;
        }

        public MyList<T> AddRange(IEnumerable<T> collection)
        {
            int lenth = _length + collection.Count();
            T[] newList = new T[lenth];
            for (int i = 0; i < _length; i++)
            {
                newList[i] = _list[i];
            }

            T[] collList = collection as T[];
            for (int i = _length; i < lenth; i++)
            {
                newList[i] = collList[i - _length];
            }

            _length = lenth;
            _list = newList;
            return this;
        }

        public bool Remove(T item)
        {
            int i = 0;
            while (i < _length)
            {
                if (_list[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }

                i++;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            T[] newList = new T[_length - 1];
            for (int i = 0; i < index; i++)
            {
                newList[i] = _list[i];
            }

            for (int i = index; i < newList.Length; i++)
            {
                newList[i] = _list[i + 1];
            }

            _length -= 1;
            _list = newList;
        }

        public void Sort()
        {
            Array.Sort(_list, 0, _length);
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < _length; i++)
            {
                str += _list[i].ToString() + " ";
            }

            return str;
        }
    }
}
