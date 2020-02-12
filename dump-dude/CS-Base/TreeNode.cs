using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class TreeNodeChar
    {
        internal char info;
        internal TreeNodeChar left;
        internal TreeNodeChar right;
        public TreeNodeChar(char ch)
        {
            info = ch;
            left = null;
            right = null;
        }
    }
    class TreeNodeInt
    {
        internal int info;
        internal TreeNodeInt left;
        internal TreeNodeInt right;
        public TreeNodeInt(int i)
        {
            info = i;
            left = null;
            right = null;
        }
    }
}
