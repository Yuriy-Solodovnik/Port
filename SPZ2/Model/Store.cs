using System;
using System.Collections.Generic;

namespace SPZ2
{
    static class Store
    {
        public static List<Port> ports = new List<Port>();
        public static void AddPort(Port port)
        {
            if (port != null)
            {
                ports.Add(port);
            }
            else
                throw new ArgumentException("Пустой класс");
        }
    }
}
