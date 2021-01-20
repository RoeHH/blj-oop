using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenspeicher
{
    public interface IZahlenspeicher<T> where IComparable<T>, IComparable
    {
        void add(T n);
        bool contains(T n);
        string get(SortOrder sortOrder);
        void clear();
    }
}
