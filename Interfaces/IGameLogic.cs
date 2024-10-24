
    public interface IGameLogic
    {
    public Dictionary<int, List<string>> InstanciateGameOutcomes();
    public MatchResult DetermineWinner(Player player, Player cpuPlayer, Dictionary<int, List<string>> rule);
    public List<string> Choices();
    public int Choice();

    }
