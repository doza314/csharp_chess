namespace Chess_csharp;

    public enum Colors
    {
        White,
        Black 
    }
    
    public enum PieceType
    {
        WPawn,
        WKnight, 
        WBishop,
        WRook,
        WQueen,
        WKing,
        BPawn,
        BKnight, 
        BBishop, 
        BRook, 
        BQueen, 
        BKing,
        None
    }
    
    public enum MenuType
    {
        Start, 
        Singleplayer,
        Multiplayer, 
        Lan,
        Online,
        Pause,
        End,
        None
    }

    public enum ButtAct //My awesome abbreviation for "Button Action"
    {
        ToStart,
        ToGame, 
        Multiplayer,
        Lan,
        Online,
        Singleplayer,
        bSelect,
        wSelect,
        Pause,
        Resume, 
        OpponentSelect,
        Exit,
        Toggle
    }

    public enum GameType
    {
        Single,
        Multi
    }