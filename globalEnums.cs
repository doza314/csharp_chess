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
        Game,
        Singleplayer,
        Multiplayer, 
        Lan,
        Online,
        Pause,
        End,
        None
}
    
    public enum GameType
    {
        Single,
        Multi
    }