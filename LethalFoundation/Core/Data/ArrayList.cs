using System;
using System.Collections.Generic;
using System.Text;

namespace LethalFoundation
{
    public class ArrayList<T>
    {
        private Func<T[]> Get;
        private Action<T[]> Set;

        public ArrayList(ref T[] array)
        {
            T[] lArray = array;
            Get = () => lArray;
            Set = (T[] newArray) => lArray = newArray;
        }

        public ArrayList(Func<T[]> get, Action<T[]> set)
        {
            Get = get;
            Set = set;
        }

        public void Add(T value)
        {
            Set(new List<T>(Get()) { value }.ToArray());
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerator<T>)Get().GetEnumerator());
        }
    }
}
