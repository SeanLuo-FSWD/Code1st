using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Code1st.Models
{
    public class Team
    {
        [Key] //set this as key since its unique
        public string TeamName { get; set; }

        public string City { get; set; }

        public List<Player> Players { get; set; } // A team has a list of players.

        public Team()
        {

        }
    }
}
