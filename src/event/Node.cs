
using System.Globalization;

namespace EventHandle
{
    public class Node
    {
        private int numberOfEdges = 101;
        private Edge[] edges;

        public Node(Edge[] newEdges)
        {
            int i;
            edges = new Edge[numberOfEdges];
            for (i = 0; i < newEdges.Length; i++)
                this.edges[i] = newEdges[i];
        }
        public string getLink(int index)
        {
            return edges[index].getLink();
        }
        public void setLink(int index, string newLink)
        {
            edges[index].setLink(newLink);
        }
        public string getText(int index)
        {
            return edges[index].getText();
        }
        public void setText(int index, string newText)
        {
            edges[index].setText(newText);
        }
        public string getCommand(int index)
        {
            return edges[index].getCommand();
        }
        public void setCommand(int index, string newCommand)
        {
            edges[index].setCommand(newCommand);
        }
        public void setEdge(int index, Edge newEdge)
        {
            edges[index] = newEdge;
        }
    }
}