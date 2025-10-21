
namespace EventHandle
{
    public class Event
    {
        private Node[] nodes;

        public Event(Node[] newNodes)
        {
            int i;
            this.nodes = new Node[newNodes.Length];
            for (i = 0; i < newNodes.Length; i++)
                this.nodes[i] = newNodes[i];
        }
        public Node getNode(int index)
        {
            return nodes[index];
        }
        public Node GetNode(string nodeName)
        {
            int i = 0;
            while ((i < nodes.Length) && (getNode(i).GetName() != nodeName))
                i++;
            return getNode(i);
        }
        public void setNode(int index, Node newNode)
        {
            nodes[index] = newNode;
        }
        public void AddNode(Node newNode)
        {
            Array.Resize(ref nodes, nodes.Length + 1);
            setNode(nodes.Length, newNode);
        }
    }
}