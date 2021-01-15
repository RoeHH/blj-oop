using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instanzenzähler
{
    class c
    {
        public static int AmountInstances { get; private set; }

        private c()
        {
            AmountInstances++;
        }

        public static c getInstance()
        {
            if (c.AmountInstances >= 10)
                return null;
                c cClass = new c();
                return cClass;
        }
        public static void resetAmountInstances()
        {
            c.AmountInstances = 0;
        }


    }
}
