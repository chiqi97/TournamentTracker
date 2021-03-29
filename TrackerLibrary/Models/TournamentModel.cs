using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {

        public event EventHandler<DateTime> OnTournamentComplete;
        /// <summary>
        /// unique identifier for tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents name of tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents EntryFee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents list entered teams
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents list of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents list of list matchupmodel
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
