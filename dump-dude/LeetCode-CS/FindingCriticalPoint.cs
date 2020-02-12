using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{

    class FindingCriticalPoint
    {
        public class Graph
        {
            public HashSet<int>[] connections;
            int v;
            public Graph(int v)
            {
                this.v = v;
                connections = new HashSet<int>[v];
                for (int i = 0; i < v; i++)
                {
                    connections[i] = new HashSet<int>();
                }
            }
            public void addConnection(int u, int v)
            {
                connections[u].Add(v);
                connections[v].Add(u);
            }
            public void removeConnection(int u, int v)
            {
                connections[u].Remove(v);
                connections[v].Remove(u);
            }
        }
        private FindingCriticalPoint findingCriticalPoint;
        private List<List<int>> connections;

        public void init()
        {
            findingCriticalPoint = new FindingCriticalPoint();
            connections = createDummyData();
        }
        public List<List<int>> createDummyData()
        {
            List<List<int>> connections = new List<List<int>>();
            List<int> con1 = new List<int>();
            con1.Add(0);
            con1.Add(1);
            connections.Add(con1);

            List<int> con2 = new List<int>();
            con2.Add(1);
            con2.Add(2);
            connections.Add(con2);

            List<int> con3 = new List<int>();
            con3.Add(2);
            con3.Add(0);
            connections.Add(con3);

            List<int> con4 = new List<int>();
            con4.Add(1);
            con4.Add(3);
            connections.Add(con4);
            return connections;

        }
        public List<List<int>> criticalConnections(int n, List<List<int>> connections)
        {
            List<List<int>> result = new List<List<int>>();
            Graph graph = new Graph(n);
            foreach (List<int> connection in connections)
            {
                graph.addConnection(connection[0], connection[1]);
            }
            Console.WriteLine(graph.connections);
            foreach (List<int> connection in connections)
            {
                graph.removeConnection(connection[0], connection[1]);
                int numberOfConnectedComponents = getConnectedComponents(graph, n);
                Console.WriteLine("Number of components: " + numberOfConnectedComponents);
                if (numberOfConnectedComponents > 1)
                    result.Add(connection);
                graph.addConnection(connection[0], connection[1]);
            }
            return result;

        }
        private int getConnectedComponents(Graph graph, int n)
        {
            int numComponents = 0;
            bool[] visited = new bool[n];
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    queue.Enqueue(i);
                    numComponents++;
                }
                while (queue.Count > 0)
                {
                    int node = queue.Peek();
                    if (!visited[node])
                    {
                        HashSet<int> sets = graph.connections[node];
                        var it = sets.GetEnumerator();
                        while (it.MoveNext())
                        {
                            //int data = it.MoveNext();
                            //if (!visited[data])
                            //    queue.add(data);
                        }
                    }
                    visited[node] = true;
                }
            }
            return numComponents;
        }
    }
}
