using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test_aspNetMvc_ef.Models.DAL.DbContexts;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Models.DAL.Initializer
{
    public class PlayerDbInitialaizer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext db)
        {
            db.Players.Add(new Player { Name = "Месси", Age = 26, Position = "" });
            db.Players.Add(new Player { Name = "Роналду", Author = "И. Тургенев", Price = 180 });
            db.Players.Add(new Player { Name = "Бейл", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}