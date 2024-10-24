
public class GameMaster : IGameMaster
{
    private readonly IGameLogic _gameLogic;
    public GameMaster(IGameLogic gameLogic)
    {
        this._gameLogic = gameLogic;
    }
    public MatchResult PlayGame(Player player)
    {
        Player cpuPlayer = InstanciateComputerPlayer();

        Dictionary<int, List<string>> gameOutcomes = _gameLogic.InstanciateGameOutcomes();

        return _gameLogic.DetermineWinner(player, cpuPlayer, gameOutcomes);
    }
    public Player InstanciateComputerPlayer()
    {
        var random = new Random();
        Player cpuPlayer = new Player();
        cpuPlayer.Shape = (Shape)Enum.ToObject(typeof(Shape), random.Next(0, 5));
        return cpuPlayer;
    }
    public List<string> Choices()
    {
        return _gameLogic.Choices();
    }
    public int GetRandomChoice()
    {
        return _gameLogic.Choice();

    }


}
