﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public void GetAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Ad Soyad: " + keys[i] +" " + values[i]);
            }
        }



    }
}
