using System;
using System.Collections.Generic;

namespace Zahlenspeicher
{
    class Zahlenspeicher<T> : IZahlenspeicher<T> where T : IComparable, IComparable<T>
    {
        private Elem<T> _firstElem;

        public void add(T n)
        {
            Elem<T> newElem = new Elem<T>();
            newElem.Value = n;

            if (_firstElem == null){
                // No Elements have been inserted up to this point
                _firstElem = newElem;
            } 
            else
            {
                if (n.CompareTo(_firstElem.Value) < 0)
                {
                    newElem.Next = _firstElem;
                    _firstElem.Previous = newElem;

                    _firstElem = newElem;
                }
                else
                {
                    Elem<T> currentElem = _firstElem;
                    while (currentElem.Next != null) {
                        Elem<T> nextElem = currentElem.Next;
                        if(n.CompareTo(nextElem.Value) < 0){
                            currentElem.Next = newElem;
                            nextElem.Previous = newElem;

                            newElem.Previous = currentElem;
                            newElem.Next = nextElem;
                            break;
                        }
                        currentElem = nextElem;
                    }
                    currentElem.Next = newElem;
                    newElem.Previous = currentElem;
                }
            }

        }

        public void clear()
        {
            _firstElem = null;
        }

        public bool contains(T n)
        {
            if(_firstElem == null)
                return false;

            Elem<T> currentElem = _firstElem;

            while (currentElem.Value.CompareTo(n) != 0)
            {
                if(currentElem.Next == null)
                    return false;

                currentElem = currentElem.Next;
            }
            return true;
        }

        public string get(SortOrder sortOrder)
        {
            if(_firstElem == null)
                return "Keine Elemente in der Liste";
            
            if (sortOrder == SortOrder.ASCENDING) {
                string temp = "";
                Elem<T> currentElem = _firstElem;
                while(currentElem.Next != null)
                {
                    temp += $"{currentElem.Value}, ";
                    currentElem = currentElem.Next;
                }
                temp += currentElem.Value.ToString();
                return temp;
            }
            else 
            {
                Elem<T> currentElem = _firstElem;
                while (currentElem.Next != null)
                {
                    currentElem = currentElem.Next;
                }
                string returnString = "";
                while (currentElem.Previous != null)
                {
                    returnString += $"{currentElem.Value}, ";
                    currentElem = currentElem.Previous;
                }
                returnString += $"{currentElem.Value}";
                return returnString;
            }
        }
    }
}
