﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the teams involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// id from the database used to identify the winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// the winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// which round this match is part of
        /// </summary>
        public int MatchupRound { get; set; }
        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName} ";
                        }
                    }
                    else
                    {
                        output = "Matchup not determined yet";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
