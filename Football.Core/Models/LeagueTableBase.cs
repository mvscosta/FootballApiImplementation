using Football.Core.Interfaces;
using System.Collections.Generic;

namespace Football.Core.Models
{
    public class LeagueTableBase : ILeagueTable
    {
        public LeagueTableBase()
        {
            Standing = new List<StandingBase>();
        }

        public virtual string LeagueCaption { get; set; }

        public virtual long? Matchday { get; set; }

        public virtual IEnumerable<IStanding> Standing { get; set; }
    }
}
