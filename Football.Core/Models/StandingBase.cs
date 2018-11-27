using Football.Core.Interfaces;

namespace Football.Core.Models
{
    public class StandingBase : IStanding
    {
        public virtual long? Position { get; set; }

        public virtual string TeamName { get; set; }

        public virtual long? Points { get; set; }

        public virtual long? Wins { get; set; }

        public virtual long? Draws { get; set; }

        public virtual long? Losses { get; set; }
    }
}
