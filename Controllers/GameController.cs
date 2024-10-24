using Microsoft.AspNetCore.Mvc;
using System.Numerics;


[Route("api/game")]
[ApiController]
public class GameController : Controller
{
    private readonly IGameMaster _gameMaster;
    private readonly Player _player;

    public GameController(IGameMaster gameMaster, Player player)
    {
        this._gameMaster = gameMaster;
        this._player = player;
    }

    [HttpGet("Index")]
    public ActionResult Index()
    {
        return View();
    }

    [HttpGet("Choice")]
    public IActionResult Choice()
    {
        return Ok(_gameMaster.GetRandomChoice());
    }

    [HttpGet("Choices")]
    public IActionResult Choices()
    {
        return Ok(_gameMaster.Choices());
    }


    [HttpPost("Play")]
    public IActionResult Play([FromBody] PlayerChoiceModel choice)
    {
        if (Enum.TryParse<Shape>(choice.PlayerChoice, true, out var parsedShape))
        {
            _player.Shape = parsedShape;
            MatchResult result = _gameMaster.PlayGame(_player);

            return Ok(result); 
        }
        else
        {
            return BadRequest("Invalid shape provided.");
        }
    }
}

public class PlayerChoiceModel
{
    public string? PlayerChoice { get; set;}
}