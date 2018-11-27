using Newtonsoft.Json;

namespace Football.Connector.FootballDataApi.Models.Competition
{
    public partial class TeamData
    {
        public long? Goals { get; set; }

        public long? GoalsAgainst { get; set; }

        public long? Wins { get; set; }

        public long? Draws { get; set; }

        public long? Losses { get; set; }
    }
}
