using Newtonsoft.Json;
using System;

namespace Football.Connector.FootballDataApi.Models.Competition
{
    public partial class CompetitionInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("league")]
        public string League { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("currentMatchday")]
        public long CurrentMatchday { get; set; }

        [JsonProperty("numberOfMatchdays")]
        public long NumberOfMatchdays { get; set; }

        [JsonProperty("numberOfTeams")]
        public long NumberOfTeams { get; set; }

        [JsonProperty("numberOfGames")]
        public long NumberOfGames { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }
}

