using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmsLesson6Task;

namespace TestBFSandDFSForGraphs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBFSWithContainsValue()
        {
            //Arrange
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

            var expected = oNode;
            //Act
            var actual = myNode.BFS(myNode, "O");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodBFSWithOUTContainsValue()
        {
            //Arrange
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

            Node expected = null;
            //Act
            var actual = myNode.BFS(myNode, "AWD");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodDFSWithContainsValue()
        {
            //Arrange
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

            var expected = uNode;
            //Act
            var actual = myNode.DFS(myNode, "U");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodDFSWithOUTContainsValue()
        {
            //Arrange
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

            Node expected = null;
            //Act
            var actual = myNode.DFS(myNode, "J");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
