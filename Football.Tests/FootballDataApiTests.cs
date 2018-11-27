using Football.Connector.FootballDataApi.Models.Competition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Football.UnitTests
{
    [TestClass]
    public class FootballDataApiTests
    {
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("A")]
        [DataRow("9999999999999999999")]
        public void GetCompetitionLeagueTable_InvalidNumber_NullResult(string number)
        {
            var result = GetLeagueTable(number).Result;

            Assert.AreEqual(result.Standing.Count(), 0);
            Assert.IsNull(result.LeagueCaption);
        }

        [TestMethod]
        [DataRow("444")]
        [DataRow("443")]
        public void GetCompetitionLeagueTable_ExistsCompetition_ListTeams(string number)
        {
            var result = GetLeagueTable(number).Result;

            Assert.IsTrue(result.LeagueCaption.Length > 0);
            Assert.IsTrue(result.Standing.Any());
        }

        private async Task<LeagueTable> GetLeagueTable(string number)
        {
            Football.Connector.FootballDataApi.Resources.Competition competition = new Connector.FootballDataApi.Resources.Competition(number);

            return await competition.GetLeagueTable();

        }

    }
}
