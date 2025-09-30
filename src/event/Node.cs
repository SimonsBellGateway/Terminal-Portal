
using System.Dynamic;
using System.Globalization;

namespace EventHandle
{
    public class Node
    {
        private int numberOfEdges;
        private Edge[] edges;
        private string text;

        public Node(int newNumberOfEdges, string newText, Edge[] newEdges)
        {
            int i;
            this.numberOfEdges = newNumberOfEdges;
            this.text = newText;
            edges = new Edge[numberOfEdges];
            for (i = 0; i < newEdges.Length; i++)
                this.edges[i] = newEdges[i];
        }

        public void setNumberOfEdges(int newNumberOfEdges)
        {
            this.numberOfEdges = newNumberOfEdges;
        }
        public int getNumberOfEdges()
        {
            return numberOfEdges;
        }

        public void setEdge(int index, Edge newEdge)
        {
            edges[index] = newEdge;
        }
        public Edge GetEdge(int index)
        {
            return edges[index];
        }

        public void setText(string newText)
        {
            this.text = newText;
        }
        public string getText()
        {
            return text;
        }

    }
}