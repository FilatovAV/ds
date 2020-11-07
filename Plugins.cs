using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl
{
    /// <summary> Статическая обертка для более удобной работы с библиотекой. </summary>
    public static class Plugins
    {
        public static Factory Factory { get; }

        static Plugins()
        {
            Factory = new Factory();
        }
    }
}
