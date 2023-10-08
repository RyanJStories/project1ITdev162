using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BasketBallController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Won", "Loss"
    };
    private static readonly string[] TeamNames = new[]
    {
        "Carolina Creepers", "St.Louis Silverfish", "Denver Dolphins", "Milwaukee Miners", "Dallas Diamonds", "Golden State Gold Nuggets", "Baltimore Bats", "LA Enchantments"
    };

    private readonly ILogger<BasketBallController> _logger;

    public WeatherForecastController(ILogger<BasketBallController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBasketBallScore")]
    public IEnumerable<BasketBallScore> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new BasketBallScore
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Score1 = random.Next(70, 131),
            Score2=random.Next(70, 131),
            Team1=TeamNames[random.Next(8)],
            Team2 =TeamNames[random.Next(8)],
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
