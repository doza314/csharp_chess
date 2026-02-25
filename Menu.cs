namespace Chess_csharp;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

class Menu
{                                                   
    private MenuType Type;
    private Window Window;
    private Vector2f Dimensions;

    public Menu(MenuType t, Window w, Vector2f d)
    {  
        Type = t;
        Window = w;
        Dimensions = d;

        if (Type == MenuType.Start)
        {
              
        }
        else if (Type == MenuType.Singleplayer)
        {
            
        }
        else if (Type == MenuType.Multiplayer)
        {
            
        }
        else if (Type == MenuType.Lan)
        {
            
        }
        else if (Type == MenuType.Online)
        {
            
        }
        else if (Type == MenuType.Game)
        {
            
        }
        else if (Type == MenuType.Pause)
        {
            
        }
        else if (Type == MenuType.End)
        {
            
        }
    }
}