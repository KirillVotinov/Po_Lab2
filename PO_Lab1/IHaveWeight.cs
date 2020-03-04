using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab1
{
    abstract class IHaveWeight
    {
        protected int Weight;
        public abstract void ChangeWeigh(int newWeight);
    }
}
