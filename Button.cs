namespace Chess_csharp;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Button
{
    private Vector2f Pos;
    private Vector2f Dims;
    private Texture Image;
    private Texture PImage;
    private Sprite Sprit;
    private Sprite PSprit;
    private ButtonAction Act;
    private string Text;
    private bool Pressed;
    
    public Button(ButtonAction action, Vector2f position, Vector2f dimensions, string text) 
    {
        Act = action;
        Pos = position;
        Dims = dimensions;
        Image = new Texture("res/" +  text + ".png");
        PImage = new Texture("res/" + text + "_pressed.png");
        Text = text;
        Sprit = new Sprite(Image);
        PSprit = new Sprite(PImage);
        Sprit.Position = Pos;
    }

    public void DrawButton(RenderWindow win)
    {
        win.Draw(Sprit);
    }

    public bool Activated(Vector2f pos) //Button clicking functionality 
    {
        if (Pressed && Sprit.GetGlobalBounds().Contains(pos)) //Button was pressed and released while mouse was in bounds
        {
            Pressed = false;
            return true;
        }
        else if (Pressed && !Sprit.GetGlobalBounds().Contains(pos)) //Pressed, but mouse was out of bounds upon release
        {
            Pressed = false;
            return false;
        }
        else if (!Pressed) //Was never pressed, nothing happens
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    
}