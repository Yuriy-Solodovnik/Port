using System;

namespace SPZ2
{
    static class RandTime
    {
        public static int Hours(this Random obj,Port t)
        {
            return obj.Next(0, 24) * t.Ships;
        }
    }
}
