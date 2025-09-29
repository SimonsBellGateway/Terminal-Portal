using EventHandle;
Edge[] edges = new Edge[4];
Edge edge = new Edge("Say Hello", "I am a stranger", "none");
Edge edge1 = new Edge("Say Hello", "I am a stranger and you too!", "none");
Edge edge2 = new Edge("Say Hello", "I am a stranger", "none");
Edge edge3 = new Edge("Say Hello", "I am a stranger", "your mom");
edges[0] = edge;
edges[1] = edge1;
edges[2] = edge2;
edges[3] = edge3;
Node node = new Node(edges);

Console.WriteLine(node.getLink(0));
Console.WriteLine(node.getText(1));
Console.WriteLine(node.getCommand(3));


/*string input = "";
 do
 {
    Console.WriteLine("Enter a text.");
    Console.Write("> ");
    input = Console.ReadLine();
    Console.WriteLine("You entered: " + "'" + input + "' !");
} while (input != "q");
 */