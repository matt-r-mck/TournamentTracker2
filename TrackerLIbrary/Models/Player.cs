using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLIbrary.Models {

    /// <summary>
    /// Models one player on a team.
    /// </summary>
    public class Player {

        /// <summary>
        /// Player's Name and contact information.
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }
    }
}
