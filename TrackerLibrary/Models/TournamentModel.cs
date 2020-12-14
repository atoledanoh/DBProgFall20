using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// unique identifier for the tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// name given to this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// amount of money each team needs to pay to participate
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// the set of teams that have been entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// the list of prizes for the places in the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
