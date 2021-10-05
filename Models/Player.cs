using System;
namespace Code1st.Models
{
    public class Player
    {
        public int PlayerId { get; set; } // EF will recognize this as Key, with either "PlayerId, or id"

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        // We don't say FK cuz we should only think in code.
        public string TeamName { get; set; }
        public Team Team { get; set; } // This obj provides the navigation back to the key. 


        public Player()
        {
        }
    }
}
