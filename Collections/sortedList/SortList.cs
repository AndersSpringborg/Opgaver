using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    class SortedList<T> : ICollection<T> where T: IComparable 
    {
        private List<T> _liste;
        List<T> Liste
        {
            get => _liste;
        }

        public int Count => ((ICollection<T>)_liste).Count;

        public bool IsReadOnly => ((ICollection<T>)_liste).IsReadOnly;

        // Const4ructor.
        public SortedList(List<T> liste)
        {
            _liste = liste;
        }

        // Add & Remove.
        public void Add(T input)
        {
            _liste.Add(input);
            _liste = _liste.OrderBy(p => p).ToList();
        }
        
        public bool Remove(T value)
        {
            if(_liste.Contains(value))
            {
                _liste = _liste.Where(p => !p.Equals(value)).ToList();
            }
            return _liste.Contains(value);   
        }

        // IColletion methods
        public void Clear()
        {
            _liste.Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)_liste).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)_liste).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)_liste).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)_liste).GetEnumerator();
        }
        
        // Enumerator methods
        public void Forward()
        {

        }
    }
}
