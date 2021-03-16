using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsLesson6Task
{
    public class Node
    {
        string _name;
        List<Edge> _edges;
                
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Edge> Edges
        {
            get { return _edges; }
            set { _edges = value; }
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
                    Console.WriteLine($"{currentNode.Name} = {nameToSearchNaode};   ");
                    return currentNode;
                }
                else
                {
                    Console.Write($"{currentNode.Name} != {nameToSearchNaode};   ");
                    
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
                    Console.WriteLine($"{currentNode.Name} = {nameToSearchNaode};   ");
                    return currentNode;
                }
                else
                {
                    Console.Write($"{currentNode.Name} != {nameToSearchNaode};   ");
                    
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
    }
}
