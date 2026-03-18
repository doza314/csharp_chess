namespace Chess_csharp;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    private Game g = new Game();
    
    static void Main()
    {
        Game.Run();
    }
}