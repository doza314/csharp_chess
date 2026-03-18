using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace Chess_csharp;

class Game
{
    private List<PieceType> Pieces;
    private VideoMode VidMode = new VideoMode((960, 540));
    private RenderWindow window;
    private Menu startMenu = 
    public Game()
    {
        window = new RenderWindow(VidMode, "Chess");
        
    }
    public void Run()
    {
        
    }

}