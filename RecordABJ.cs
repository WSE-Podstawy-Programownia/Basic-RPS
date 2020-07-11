
public class RecordABJ : IRecord
{
    int playerOneBet;
    int playerTwoBet;
    int maxValue;
    string result;
    public RecordABJ(int playerOneBet, int playerTwoBet, int maxValue, string result)
    {
        this.playerOneBet = playerOneBet;
        this.playerTwoBet = playerTwoBet;
        this.maxValue = maxValue;
        this.result = result;
    }

    override public string ToString()
    {
        return string.Format($"{playerOneBet,3} vs {playerTwoBet, -3} out of {maxValue, 3} : {result}");
    }

}
