namespace Chess_csharp;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Button
{
    private Vector2f _pos; //Button position (located @ top left corner of texture/sprite)
    private Vector2f _dims; //Button dimensions

    private Texture _image; //Regular, unpressed image
    private Texture _pimage; //Pressed image
    private Sprite _sprit; //Regular, unpressed sprite
    private Sprite _psprit; //Pressed sprite

    //All types of possible buttons
    private ButtAct _act;

    private List<ButtAct> _actions = //All possible button functionalities
    [
        ButtAct.Singleplayer,
        ButtAct.Multiplayer,
        ButtAct.wSelect,
        ButtAct.bSelect,
        ButtAct.Online,
        ButtAct.Lan,
        ButtAct.Pause,
        ButtAct.Resume,
        ButtAct.OpponentSelect,
        ButtAct.Exit,
        ButtAct.Toggle,
        ButtAct.ToStart,
        ButtAct.ToGame
    ];

    private List<string> _names = //Names corresponding to action (used for loading texture files)
    [
        "Singleplayer",
        "Multiplayer",
        "wSelect",
        "bSelect",
        "Online",
        "Lan",
        "Pause",
        "Resume",
        "OpponentSelect",
        "Exit",
        "Toggle",
        "ToStart",
        "ToGame"
    ];

    private List<Vector2f> _positions = //FIGURE THESE OUT
    [
        
    ];

private List<Vector2f> _possDims = //Possible button dimensions
    [
        (150, 50),
        (50, 50)
    ];
    
    private string? _text;

    private bool _pressed = false;
    
    public Button(ButtAct action) //String assignment loop
    {
        for (int i = 0; i < _actions.Count; i++)
        {
            if (_actions[i] == action)
            {
                _text = _names[i];
            }
        }
        
        _act = action;
        _image = new Texture("res/" +  _text + ".png");
        _pimage = new Texture("res/" + _text + "_pressed.png");
        _sprit = new Sprite(_image);
        _psprit = new Sprite(_pimage);
        
    }

    public void DrawButton(RenderWindow win)
    {
        win.Draw(_sprit);
    }

    public bool Activated(Vector2f position) //Button clicking functionality 
    {
        if (_pressed && _sprit.GetGlobalBounds().Contains(position)) //Button was pressed and released while mouse was in bounds
        {
            _pressed = false;
            return true;
        }
        else if (_pressed && !_sprit.GetGlobalBounds().Contains(position)) //Pressed, but mouse was out of bounds upon release
        {
            _pressed = false;
            return false;
        }
        else if (!_pressed) //Was never pressed, nothing happens
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    
}