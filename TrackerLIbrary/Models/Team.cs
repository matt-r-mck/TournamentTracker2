using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// Models one team in our tournament.
    /// </summary>
    public class Team {

        /// <summary>
        /// List of players 
        /// </summary>
        public List <Player> TeamMembers { get; set; } = new List <Player>();
        public string TeamName { get; set; }

    }
}
