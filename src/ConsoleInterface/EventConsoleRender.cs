
using EventHandle;

namespace ConsoleInterface
{
    public class EventConsoleRender
    {
        private int widthLimit;

        public EventConsoleRender(int newWidthLimit)
        {
            this.widthLimit = newWidthLimit;
        }
        //  Needs to be repaired
        public void textOrganizer(string text, ref string[] currentText)
        {
            int i, j, k;
            string c2, tempString;
            char c1 = '/';
            tempString = "";
            c2 = "//ln";
            k = 0;

            for (i = 0; i < text.Length; i++)
            {
                Array.Resize(ref currentText, k + 1);
                j = 0;
                while ((i < text.Length) && (j <= widthLimit))
                {
                    tempString = "";
                    if (!text[i].Equals(c1))
                    {
                        currentText[k] = currentText[k] + text[i];
                        j++;
                        i++;
                    }
                    else
                    {
                        //  For some reason the "" are needed here in order to work \_(*-*)_/
                        tempString = text.Substring(i, 4);
                        if (tempString.Equals(c2))
                        {
                            j = widthLimit + 1;
                            i += 4;

                        }
                        else
                        {
                            currentText[k] = currentText[k] + text[i];
                            j++;
                            i++;
                        }
                    }
                }
                k++;
                i--;
            }
        }
        public void RenderNodeText(Node node)
        {
            int i;
            string text = node.getText();
            string[] lines = new string[0];

            textOrganizer(text, ref lines);

            for (i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        //  Renders the text of the edges of a node
        public void RenderEdgesText(Node node)
        {
            int numberOfEdges, i, currentEdge;
            numberOfEdges = node.getNumberOfEdges();

            for (i = 0; i < numberOfEdges; i++)
            {
                currentEdge = i + 1;
                Console.WriteLine("[" + currentEdge + "]. " + node.GetEdge(i).getText());
            }
        }

        //  Renders the entire node
        public void RenderNode(Node node)
        {
            Console.WriteLine("--------------------------------------------------");
            RenderNodeText(node);
            Console.WriteLine("--------------------------------------------------");
            RenderEdgesText(node);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
    }
}