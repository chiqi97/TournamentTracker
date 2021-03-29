using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {


        public int Id { get; set; }
        /// <summary>
        /// Represents Team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents team name
        /// </summary>
        public string TeamName { get; set; }
    }
}
