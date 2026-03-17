namespace Chess_csharp;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

class Menu
{                                                   
    private MenuType Type;
    private Vector2f Dims;
    private List<Button> Butts;
    
    
    public Menu(MenuType t, Vector2f d)
    {  
        Type = t;
        Dims = d;

        if (Type == MenuType.Start) //figure out how to add new button objects to this
        {
           // Butts.Add(new Button()); Singleplayer
           // Butts.Add(new Button()); Multiplayer
        }
        else if (Type == MenuType.Singleplayer)
        {
            //Black
            //White
        }
        else if (Type == MenuType.Multiplayer)
        {
            //LAN
            //Online
        }
        else if (Type == MenuType.Lan)
        {
            //Figure out how to list available opponents
        }
        else if (Type == MenuType.Online)
        {
            //Too drunk to think about this right now (3/16/2026 8:07pm)
        }
        else if (Type == MenuType.Pause)
        {
            //Resume
            //Main Menu
        }
        else if (Type == MenuType.End)
        {
            //Main Menu
            //Exit
        }
    }
}