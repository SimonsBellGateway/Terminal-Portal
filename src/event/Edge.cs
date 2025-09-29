
namespace EventHandle
{
    public class Edge
    {
        private string link;
        private string text;
        private string command;
        public Edge(string newlink, string newtext, string newcommand)
        {
            this.link = newlink;
            this.text = newtext;
            this.command = newcommand;
        } 
        public string getLink()
        {
            return link;
        }
        public void setLink(string newLink)
        {
            link = newLink;
        }
        public string getText()
        {
            return text;
        }
        public void setText(string newText)
        {
            link = newText;
        }
        public string getCommand()
        {
            return command;
        }
        public void  setCommand(string newCommand)
        {
            link = newCommand;
        }
    }
}