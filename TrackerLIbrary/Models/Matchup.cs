using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// Models a single game in our tournament application.
    /// </summary>
    public class Matchup {

        /// <summary>
        /// List of matchups composed of entries to the tournament.
        /// </summary>
        public List<MatchupEntry> Entries { get; set; } = new List<MatchupEntry>();

        /// <summary>
        /// Team that wins this matchup.
        /// </summary>
        public Team Winner { get; set; }

        /// <summary>
        /// Number of this matchup round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
