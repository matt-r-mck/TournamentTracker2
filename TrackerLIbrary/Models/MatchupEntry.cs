using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// This models a single matchup in our tournament.
    /// </summary>
    public class MatchupEntry {

        /// <summary>
        /// Name of team in this matchup.
        /// </summary>
        public Team TeamCompeting { get; set; }

        /// <summary>
        /// Represents team's score in this matchup.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Name of matchup team won last.
        /// </summary>
        public Matchup ParentMatchup { get; set; }
    }
}
