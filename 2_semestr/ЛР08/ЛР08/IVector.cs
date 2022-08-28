using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР08
{
    public interface IVector
    {
        double this[int id]
        {
            get;
            set;
        }
        int Length
        {
            get;
        }
        double GetNorm();
    }
}
