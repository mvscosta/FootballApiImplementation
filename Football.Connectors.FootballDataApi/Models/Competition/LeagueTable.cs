using Football.Core.Interfaces;
using Football.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Football.Connector.FootballDataApi.Models.Competition
{
    public partial class LeagueTable : LeagueTableBase
    {
        public LeagueTable()
        {
            Standing = new List<Standing>();
        }

        [JsonProperty("leagueCaption", NullValueHandling = NullValueHandling.Ignore)]
        public override string LeagueCaption { get; set; }

        [JsonProperty("matchday", NullValueHandling = NullValueHandling.Ignore)]
        public override long? Matchday { get; set; }

        [JsonProperty("standing", NullValueHandling = NullValueHandling.Ignore)]
        public override IEnumerable<IStanding> Standing { get; set; }
    }
}
