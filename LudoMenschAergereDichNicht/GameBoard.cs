namespace LudoMenschAergereDichNicht;
public delegate bool IntModTen(int pos);
public class GameBoard
{
    private List<GameField> _fields;
    
    public static bool IsMultipleOfTen(int pos) => pos % 10 == 0;
    GameBoard()
    {
        
        IntModTen check = IsMultipleOfTen;
        _fields = new List<GameField>();
        for (int i = 0; i<= Utils.FIELD_SIZE; i++)
        {
            _fields.Add(new GameField(i, check(i), PlayerEnum.NoPlayer, false, false));
        }

        int specialIdBase = 100;
        for (int i = 1; i <= Utils.PLAYER_AMOUNT; i++)
        {
            _fields.Add(new GameField(i*specialIdBase+1, false, (PlayerEnum)i, false, true));
        }
        
    }
    

    public override string ToString()
    {
        PlayerEnum[][] boardToString;
        return base.ToString();
    }
}