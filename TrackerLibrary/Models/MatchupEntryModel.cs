using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one team in the matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
