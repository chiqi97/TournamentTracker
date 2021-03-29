using System;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represens one team in the matchup
        /// </summary>
        /// prop      

        public int TeamCompetingId { get; set; }
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score fot his particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that his team came
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        public int ParentMatchupId { get; set; }


    }
}
