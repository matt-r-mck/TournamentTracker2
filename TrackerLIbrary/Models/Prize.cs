using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// Models a prize for a place number in our tournament.
    /// </summary>
    public class Prize {

        /// <summary>
        /// Number of place for prize to be assigned.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Numbert name of place.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize ammount to be distributed for this place.
        /// </summary>
        public decimal PrizeAmmount { get; set; }

        /// <summary>
        /// This prize's percentage of the entire pot.
        /// </summary>
        public int PrizePercentage { get; set; }
    }
}
