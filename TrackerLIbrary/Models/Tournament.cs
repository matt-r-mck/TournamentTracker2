using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// Models entire tournament. 
    /// Contains matchups, prizes, and teams.
    /// </summary>
    public class Tournament {

        /// <summary>
        /// Name of this tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Fee paid by entered teams.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of teams entered in the tournament.
        /// </summary>
        public List<Team> EnteredTeams { get; set; } = new List<Team>();

        /// <summary>
        /// List of prizes to be distributed from total prize pot.
        /// </summary>
        public List<Prize> Prizes { get; set; } = new List<Prize>();

        /// <summary>
        /// List of each matchup ion each round of tournament.
        /// </summary>
        public List<List<Matchup>> Rounds { get; set; } = new List<List<Matchup>>();
    }
}
