using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class NodeLink
    {
        public NodeLink link;
        public object data;
        public NodeLink(object i)
        {
            data = i;
            link = null;
        }
    }
    class DoubleNodeLink
    {
        public DoubleNodeLink prev;
        public DoubleNodeLink next;
        public object data;
        public DoubleNodeLink(object i)
        {
            data = i;
            prev = null;
            next = null;
        }
    }
}
