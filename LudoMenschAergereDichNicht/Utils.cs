namespace LudoMenschAergereDichNicht;

public static class Utils
{
    public const int FIELD_SIZE = 40;
    public const int PLAYER_AMOUNT = 4;
    public const int PLAYER_LIFE_AMOUNT = 4;

    public const int CONSOLE_SIZE = 11;
    public static readonly int[,] FieldBlueprint =
    {
        // Jede Zeile = eine Zeile auf dem Spielfeld (11 Spalten)
        // -1 = leer, Zahlen = Feld-IDs
        { -1, -1, -1, -1,  8,      9,    10, -1, -1, -1, -1 },
        { -1, -1, -1, -1,  7,     201,   11, -1, -1, -1, -1 },
        { -1, -1, -1, -1,  6,     202,   12, -1, -1, -1, -1 },
        { -1, -1, -1, -1,  5,     203,   13, -1, -1, -1, -1 },
        {  0,  1,  2,  3,  4,     204,   14, 15, 16, 17, 18 },
        { 39, 101, 102, 103, 104, -1,    304, 303, 302, 301, 19 }, // 
        { 38, 37, 36, 35, 34,     404,   24, 23, 22, 21, 20 },
        { -1, -1, -1, -1, 33,     403,   25, -1, -1, -1, -1 },
        { -1, -1, -1, -1, 32,     402,   26, -1, -1, -1, -1 },
        { -1, -1, -1, -1, 31,     401,   27, -1, -1, -1, -1 },
        { -1, -1, -1, -1, 30,      29,   28, -1, -1, -1, -1 }
    };


}