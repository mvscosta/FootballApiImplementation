using Football.Connector.FootballDataApi.Models.Competition;
using Football.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Football.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Número da Competição é obrigatório")]
        public string CompetitionNumber { get; set; }

        [BindProperty]
        public LeagueTable LeagueTable { get; private set; }

        public async Task<IActionResult> OnGetAsync(string competitionNumber)
        {
            LeagueTable = await SearchLeagueTable(competitionNumber);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            LeagueTable = await SearchLeagueTable(CompetitionNumber);

            return Page();
        }


        private async Task<LeagueTable> SearchLeagueTable(string competitionNumber)
        {
            if (!string.IsNullOrEmpty(competitionNumber))
            {
                var footballDataApi = new Connector.FootballDataApi.Resources.Competition(competitionNumber);

                return await footballDataApi.GetLeagueTable();
            }

            return null;
        }
    }
}
