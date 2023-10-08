namespace API;

public class BasketballScore
{
    public DateOnly Date { get; set; }

    public int Score1 { get; set; }
    public int Score2 { get; set; }
    public string Team1 { get; set; }

    public string Team2 { get; set; }


    public string? Summary { get; set; }
}
