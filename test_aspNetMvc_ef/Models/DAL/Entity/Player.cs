using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_aspNetMvc_ef.Models.DAL.Entity
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        //NavigationProperty
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}