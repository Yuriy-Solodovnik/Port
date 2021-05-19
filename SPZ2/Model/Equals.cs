using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2
{
    class EqualsPorts : IEqualityComparer<Port>
    {
        public bool Equals(Port p1, Port p2)
        {
            if (p1 == null && p2 == null)
                return true;
            else if (p1 == null || p2 == null)
                return false;
            else if (p1.Docks == p2.Docks&&
                p1.Technique == p2.Technique &&
                p1.Workers == p2.Workers)
                return true;
            else
                return false;
        }
        public int GetHashCode(Port pc)
        {
            int HashCode = pc.Docks^ pc.Technique^pc.Workers;
            return HashCode.GetHashCode();
        }
    }
}
