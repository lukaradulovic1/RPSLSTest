
    public interface IGameMaster
    {
        public MatchResult PlayGame(Player player);
        public Player InstanciateComputerPlayer();
        public List<string> Choices();
        public int GetRandomChoice();

    }
