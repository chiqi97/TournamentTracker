using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// unique identifier of the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents list of matchupentrymodel
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents Teammodel 
        /// </summary>
        /// 
        
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The ID from the database that will be used to identify winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents the round of the match
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting!=null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return output;
            }
        }

    }
}
