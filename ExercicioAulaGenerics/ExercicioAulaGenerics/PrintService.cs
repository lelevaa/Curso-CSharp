using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ExercicioAulaGenerics
{       
    //generics, parametrizada por tipo
    class PrintService<T>
    {
        //private int[] _values = new int[10];

        //não tem typesafety, não da erro de compilação, permite +2 em string => dá erro na hora de rodar
        //private object[] _values = new object[10];

        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;

        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

    }

}
