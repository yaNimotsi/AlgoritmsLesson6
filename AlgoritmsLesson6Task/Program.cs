using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using System;
using System.Collections.Generic;

namespace AlgoritmsLesson6Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
|        Method |     Mean |    Error |   StdDev |
|-------------- |---------:|---------:|---------:|
| TestBfsMethod | 977.7 ns | 18.84 ns | 21.69 ns |
| TestDfsMethod | 372.1 ns |  7.42 ns |  9.38 ns |
             * 
             * */

            BenchmarkRunner.Run<BenchmarkClass>();
        }
    }
    public class BenchmarkClass
    {
        //private List<Node> allNodes;
        private readonly Node startNode;
        private readonly string searchNode = "U";

        public BenchmarkClass()
        {
            Node myNode = new Node()
            {
                Name = "I",
                Edges = new System.Collections.Generic.List<Edge>()
            };

            Node aNode = new Node()
            {
                Name = "A",
                Edges = new System.Collections.Generic.List<Edge>()
            };
            Node fNode = new Node()
            {
                Name = "F",
                Edges = new System.Collections.Generic.List<Edge>()
            };
            Node maNode = new Node()
            {
                Name = "Ma",
                Edges = new System.Collections.Generic.List<Edge>()
            };
            Node mNode = new Node()
            {
                Name = "M",
                Edges = new System.Collections.Generic.List<Edge>()
            };
            Node oNode = new Node()
            {
                Name = "O",
                Edges = new System.Collections.Generic.List<Edge>()
            };
            Node uNode = new Node()
            {
                Name = "U",
                Edges = new System.Collections.Generic.List<Edge>()
            };

            myNode.Edges.Add(new Edge { Node = aNode });
            myNode.Edges.Add(new Edge { Node = fNode });
            myNode.Edges.Add(new Edge { Node = maNode });

            aNode.Edges.Add(new Edge { Node = myNode });
            aNode.Edges.Add(new Edge { Node = maNode });

            fNode.Edges.Add(new Edge { Node = myNode });
            fNode.Edges.Add(new Edge { Node = aNode });

            maNode.Edges.Add(new Edge { Node = mNode });
            maNode.Edges.Add(new Edge { Node = oNode });
            maNode.Edges.Add(new Edge { Node = myNode });

            oNode.Edges.Add(new Edge { Node = mNode });
            oNode.Edges.Add(new Edge { Node = maNode });
            oNode.Edges.Add(new Edge { Node = uNode });

            mNode.Edges.Add(new Edge { Node = maNode });
            mNode.Edges.Add(new Edge { Node = oNode });

            uNode.Edges.Add(new Edge { Node = oNode });

            startNode = myNode;
        }

        public Node BFS(Node startNode, string nameToSearchNaode)
        {
            if (startNode == null) return null;

            Queue<Node> queueSubNode = new Queue<Node>();
            queueSubNode.Enqueue(startNode);

            HashSet<Node> nodesHashSet = new HashSet<Node>();
            nodesHashSet.Add(startNode);

            Node currentNode;

            while (queueSubNode.Count != 0)
            {
                currentNode = queueSubNode.Dequeue();

                if (currentNode.Name == nameToSearchNaode)
                {
                    return currentNode;
                }
                else
                {
                    for (int i = 0; i < currentNode.Edges.Count; i++)
                    {
                        if (!nodesHashSet.Contains(currentNode.Edges[i].Node))
                        {
                            queueSubNode.Enqueue(currentNode.Edges[i].Node);
                            nodesHashSet.Add(currentNode.Edges[i].Node);
                        }
                    }
                }
            }

            return null;
        }

        public Node DFS(Node startNode, string nameToSearchNaode)
        {
            if (startNode == null) return null;

            Stack<Node> stackNodes = new Stack<Node>();
            stackNodes.Push(startNode);

            HashSet<Node> nodesHashSet = new HashSet<Node>();
            nodesHashSet.Add(startNode);

            Node currentNode;

            while (stackNodes.Count != 0)
            {
                currentNode = stackNodes.Pop();

                if (currentNode.Name == nameToSearchNaode)
                {
                    return currentNode;
                }
                else
                {
                    for (int i = 0; i < currentNode.Edges.Count; i++)
                    {
                        if (!nodesHashSet.Contains(currentNode.Edges[i].Node))
                        {
                            stackNodes.Push(currentNode.Edges[i].Node);
                            nodesHashSet.Add(currentNode.Edges[i].Node);
                        }
                    }
                }
            }

            return null;
        }

        [Benchmark]
        public void TestBfsMethod()
        {
            var a = BFS(startNode, searchNode);
            Node returnNode = BFS(startNode, searchNode);
        }

        [Benchmark]
        public void TestDfsMethod()
        {
            var a = DFS(startNode, searchNode);
        }

    }
}


