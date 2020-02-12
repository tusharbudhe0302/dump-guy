// Given a directed, acyclic graph of N nodes.  Find all possible paths from node 0 to node N-1, and return them in any order.

// The graph is given as follows:  the nodes are 0, 1, ..., graph.length - 1.  graph[i] is a list of all nodes j for which the edge (i, j) exists.

// Example:
// Input: [[1,2], [3], [3], []] 
// Output: [[0,1,3],[0,2,3]] 
// Explanation: The graph looks like this:
// 0--->1
// |    |
// v    v
// 2--->3
// There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.
// Note:

// The number of nodes in the graph will be in the range [2, 15].
// You can print different paths in any order, but you should keep the order of nodes inside one path.


/* Generated from Java with JSweet 2.2.0-SNAPSHOT - http://www.jsweet.org */
var Graph = (function () {
    function Graph(vertices) {
        if (this.v === undefined)
            this.v = 0;
        if (this.adjList === undefined)
            this.adjList = null;
        this.v = vertices;
        this.initAdjList();
    }
    /*private*/ Graph.prototype.initAdjList = function () {
        this.adjList = (function (s) {
            var a = []; while (s-- > 0)
                a.push(null); return a;
        })(this.v);
        for (var i = 0; i < this.v; i++) {
            {
                this.adjList[i] = ([]);
            }
            ;
        }
    };
    Graph.prototype.addEdge = function (u, v) {
        /* add */ (this.adjList[u].push(v) > 0);
    };
    Graph.prototype.printAllPaths = function (s, d) {
        var isVisited = (function (s) {
            var a = []; while (s-- > 0)
                a.push(false); return a;
        })(this.v);
        var pathList = ([]);
        /* add */ (pathList.push(s) > 0);
        this.printAllPathsUtil(s, d, isVisited, pathList);
    };
    /*private*/ Graph.prototype.printAllPathsUtil = function (u, d, isVisited, localPathList) {
        isVisited[u] = true;
        if ((function (o1, o2) {
            if (o1 && o1.equals) {
                return o1.equals(o2);
            }
            else {
                return o1 === o2;
            }
        })(u, d)) {
            console.info(localPathList);
            isVisited[u] = false;
            return;
        }
        {
            var array10491 = this.adjList[u];
            var _loop_1 = function (index10490) {
                var i = array10491[index10490];
                {
                    if (!isVisited[i]) {
                        /* add */ (localPathList.push(i) > 0);
                        this_1.printAllPathsUtil(i, d, isVisited, localPathList);
                        /* remove */ (function (a) {
                            var index = a.indexOf(i); if (index >= 0) {
                                a.splice(index, 1);
                                return true;
                            }
                            else {
                                return false;
                            }
                        })(localPathList);
                    }
                }
            };
            var this_1 = this;
            for (var index10490 = 0; index10490 < array10491.length; index10490++) {
                _loop_1(index10490);
            }
        }
        isVisited[u] = false;
    };
    Graph.main = function (args) {
        var g = new Graph(4);
        g.addEdge(0, 1);
        g.addEdge(0, 2);
        g.addEdge(0, 3);
        g.addEdge(2, 0);
        g.addEdge(2, 1);
        g.addEdge(1, 3);
        var s = 2;
        var d = 3;
        console.info("Following are all different paths from " + s + " to " + d);
        g.printAllPaths(s, d);
    };
    return Graph;
}());
Graph["__class"] = "Graph";
Graph.main(null);
