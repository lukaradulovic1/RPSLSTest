public class MatchResult
{
    public int PlayerShape { get; set; }
    public int ComputerShape { get; set; }
    public string Result { get; set; }

    public MatchResult(int playerShape, int computerShape, string result)
    {
        PlayerShape = playerShape;
        ComputerShape = computerShape;
        Result = result;
    }

}