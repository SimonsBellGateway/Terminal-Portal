
namespace EventHandle
{
    public class Event
    {
        private int numberOfNodes = 101;
        private Node[] nodes;

        public Event(Node[] newNodes)
        {
            int i;
            this.nodes = new Node[numberOfNodes];
            for (i = 0; i < newNodes.Length; i++)
                this.nodes[i] = newNodes[i];
        }
        public void setNode(int index, Node newNode)
        {
            nodes[index] = newNode;
        }
    }
}