using Football.Connector.FootballDataApi.Models.Competition;
using System.Threading.Tasks;

namespace Football.Connector.FootballDataApi.Resources
{
    public class Competition
    {
        public string CompetitionId { get; set; }

        public Competition(string competitionId)
        {
            CompetitionId = competitionId;
        }

        public async Task<CompetitionInfo> GetCompetitionInfo()
        {
            return await FootballDataApi.Get<CompetitionInfo>(CompetitionId);
        }

        public async Task<LeagueTable> GetLeagueTable()
        {
            return await FootballDataApi.Get<LeagueTable>($"{CompetitionId}/leagueTable");
        }
    }
}
