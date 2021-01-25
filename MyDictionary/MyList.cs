using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T,V> 
    {
        T[] _key;
        V[] _value;
        T[] _tempKey;
        V[] _tempValue;
        public MyList()
        {
            _key = new T[0];
            _value = new V[0];
        }
        public void Add(T item,V value)
        {
            _tempKey = _key;
            _key = new T[_key.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = item;
        }
        public int Count
        {
            get { return _key.Length; }
        }

        public int Lenght
        {
            get { return _key.Length; }
        }

    }
}
