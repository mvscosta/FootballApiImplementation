namespace Football.Core.Interfaces
{
    public interface IStanding
    {
        long? Position { get; set; }

        string TeamName { get; set; }

        long? Points { get; set; }

        long? Wins { get; set; }

        long? Draws { get; set; }

        long? Losses { get; set; }
    }
}
