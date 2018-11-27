using Football.Core.Interfaces;
using Football.Core.Models;
using Newtonsoft.Json;

namespace Football.Connector.FootballDataApi.Models.Competition
{
    public partial class Standing : StandingBase
    {
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Position { get; set; }

        [JsonProperty("teamName", NullValueHandling = NullValueHandling.Ignore)]
        public override string TeamName { get; set; }

        [JsonProperty("crestURI")]
        public string CrestUri { get; set; }

        [JsonProperty("playedGames", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedGames { get; set; }

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Points { get; set; }

        [JsonProperty("goals", NullValueHandling = NullValueHandling.Ignore)]
        public long? Goals { get; set; }

        [JsonProperty("goalsAgainst", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoalsAgainst { get; set; }

        [JsonProperty("goalDifference", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoalDifference { get; set; }

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Wins { get; set; }

        [JsonProperty("draws", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Draws { get; set; }

        [JsonProperty("losses", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Losses { get; set; }

        [JsonProperty("home", NullValueHandling = NullValueHandling.Ignore)]
        public TeamData Home { get; set; }

        [JsonProperty("away", NullValueHandling = NullValueHandling.Ignore)]
        public TeamData Away { get; set; }
    }
}
