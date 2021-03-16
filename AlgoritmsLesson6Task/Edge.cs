using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsLesson6Task
{
    public class Edge
    {
        int _weight;
        Node _node;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Node Node
        {
            get { return _node; }
            set { _node = value; }
        }
    }
}
