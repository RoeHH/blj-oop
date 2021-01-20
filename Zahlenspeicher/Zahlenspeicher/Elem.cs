using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenspeicher
{
    class Elem<T> where T: IComparable<T>, IComparable
    {
        public Elem<T> Next { get; set; }
        public Elem<T> Previous { get; set; }
        public T Value { get; set; }
    }
}
