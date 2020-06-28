using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_aspNetMvc_ef.Models.DAL.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }

        //NavigationProperty
        public IList<Player> Players { get; set; }
        public Team()
        {
            Players = new List<Player>();
        }
    }
}