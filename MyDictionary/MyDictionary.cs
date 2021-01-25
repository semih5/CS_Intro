using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>

    {
        T[] valueArray;

        T[] tempValueArray;

        public MyDictionary()
        {
            valueArray = new T[0];
        }

        public void Add(T value)
        {
            tempValueArray = valueArray;

            valueArray = new T[valueArray.Length + 1];

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }

            valueArray[valueArray.Length - 1] = value;
        }

        public T[] Items1
        {
            get { return valueArray; }
        }
    }
}
