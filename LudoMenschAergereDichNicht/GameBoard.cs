using System.Text;

namespace LudoMenschAergereDichNicht;
public delegate bool IntModTen(int pos);
public class GameBoard
{
    private List<GameField> _fields;
    
    public static bool IsMultipleOfTen(int pos) => pos % 10 == 0;
    public GameBoard()
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
            for (int j = 1; j <= Utils.PLAYER_LIFE_AMOUNT; j++)
            {
                _fields.Add(new GameField(i * specialIdBase + j, false, (PlayerEnum)i, false, true));

            }
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < Utils.CONSOLE_SIZE; i++)
        {
            for (int j = 0; j < Utils.CONSOLE_SIZE; j++)
            {
                var field = _fields.Find(f => f.index == Utils.FieldBlueprint[i, j]);
                if (field is not null)
                {
                    if (field.isGoal)
                    {
                        sb.Append(" _ ");
                    }
                    else
                    {
                        sb.Append(field.isOccupied ? " X " : " 0 ");
                    }
                }
                else
                { 
                    sb.Append("   ");
                }
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}