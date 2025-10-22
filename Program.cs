using System.Net.Http.Headers;
using EventHandle;
using ConsoleInterface;
using System.Collections;
string newText;
//  My first Event
//  Main stage
Edge yes = new Edge("happy_ending", "yes", "none");
Edge no = new Edge("game_over", "no", "none");
Edge[] edge_main = new Edge[2];
edge_main[0] = yes;
edge_main[1] = no;
newText = "You are playing this awesome game, then, the door of your room opens behind you, it's your mother!//ln<<Did you make your homework?>> asks your mother.";
Node main = new Node(edge_main.Length, newText, edge_main, "main");

//  First ending stage
Edge[] happy_ending_edges = new Edge[0];
newText = "Your mom looks at you with some suprise.//ln<<Okay>> says your mom living your room and not closing your door.//lnYour breath starts to normalize, it's over.//ln//lnHappy ending//ln//lnFor now.";
Node happy_ending = new Node(happy_ending_edges.Length, newText, happy_ending_edges, "happy_ending");

// Second ending stage
Edge[] game_over_edges = new Edge[0];
newText = "After you answer your mom, you rialize that you made a mistake.//lnYour mother has hers flip-flop on her hand. You know it's your end.//lnThen you feel the flip-flop on your face.//ln//lnGAME OVER!";
Node game_over = new Node(game_over_edges.Length, newText, game_over_edges, "game_over");
Node[] first_event_nodes = new Node[3];
first_event_nodes[0] = main;
first_event_nodes[1] = happy_ending;
first_event_nodes[2] = game_over;
Event first_event = new Event(first_event_nodes);

//  Now how to play de event?
Console.WriteLine();
EventConsoleRender render = new EventConsoleRender(50);

string input = " ";
string currentNode = "main";
do
{
    render.RenderNode(first_event.GetNode(currentNode));
    Console.Write(">");
    input = Console.ReadLine();
    first_event.GetCurrentNode(input, ref currentNode);

} while (input != "q");
