using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР05
{
    class VectorCompare : IComparer<object>
    {
        public int Compare(object o1, object o2)
        {
            IVector v1 = (IVector)o1;
            IVector v2 = (IVector)o2;
            if (v1.GetNorm() > v2.GetNorm())
                return 1;
            if (v1.GetNorm() < v2.GetNorm())
                return -1;
            else
                return 0;
        }
    }
}
