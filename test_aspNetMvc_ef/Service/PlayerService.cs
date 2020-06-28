using System.Collections.Generic;
using System.Linq;
using test_aspNetMvc_ef.Models.DAL.DbContexts;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Service
{
    public class PlayerService
    {
        private DataBaseContext db = new DataBaseContext();

        public IEnumerable<Player> GetAll()
        {
            var result = db.Players;
            return result;
        }
    }
}