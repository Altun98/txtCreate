using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtCreate
{
    public static class AvtomaticID
    {
        public static int Count = 0;
        public static int get_id()
        {
            return ++Count;
        }
    }
}
