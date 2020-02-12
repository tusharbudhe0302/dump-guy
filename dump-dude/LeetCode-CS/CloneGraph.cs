using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class CloneGraphNode
    {
        public int label;
        public List<CloneGraphNode> neighbors;

        public CloneGraphNode(int x)
        {
            label = x;
            neighbors = new List<CloneGraphNode>();
        }
    }
    class CloneGraph
    {
        public static CloneGraphNode cloneGraph(CloneGraphNode node)
        {
            if (node == null)
                return null;

            Queue<CloneGraphNode> queue = new Queue<CloneGraphNode>();
            Dictionary<CloneGraphNode, CloneGraphNode> map =
                                   new Dictionary<CloneGraphNode, CloneGraphNode>();

            CloneGraphNode newHead = new CloneGraphNode(node.label);

            queue.Enqueue(node);
            map.Add(node, newHead);

            while (queue.Count > 0)
            {
                CloneGraphNode curr = queue.Dequeue();

                List<CloneGraphNode> currNeighbors = curr.neighbors;

                foreach (CloneGraphNode aNeighbor in currNeighbors)
                {
                    if (!map.ContainsKey(aNeighbor))
                    {
                        CloneGraphNode copy = new CloneGraphNode(aNeighbor.label);

                        map.Add(aNeighbor, copy);

                        map[curr].neighbors.Add(copy);

                        queue.Enqueue(aNeighbor);
                    }
                    else
                    {
                        map[curr].neighbors.Add(map[aNeighbor]);
                    }
                }
            }

            return newHead;
        }
    }
}
