namespace Chess_csharp;
using globalEnums;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using SFML.Graphics;

class menu
{
    private menuType type;
    private Window window;
    private Vector2f dimensions;

    public menu(menuType t, Window w, Vector2f d)
    {  
        type = t;
        window = w;
        dimensions = d;

        if (type == menuType.start)
        {
              
        }
        else if (type == menuType.singleplayer)
        {
            
        }
        else if (type == menuType.multiplayer)
        {
            
        }
        else if (type == menuType.lan)
        {
            
        }
        else if (type == menuType.online)
        {
            
        }
        else if (type == menuType.game)
        {
            
        }
        else if (type == menuType.pause)
        {
            
        }
        else if (type == menuType.end)
        {
            
        }
    }
}