using Football.Core.Models;
using System.Collections.Generic;

namespace Football.Core.Interfaces
{
    public interface ILeagueTable
    {
        string LeagueCaption { get; set; }

        IEnumerable<IStanding> Standing { get; set; }
    }
}
