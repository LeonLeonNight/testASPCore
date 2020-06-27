using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_aspNetMvc_ef.Models.DAL.DbContexts;
using test_aspNetMvc_ef.Models.DAL.Entity;

namespace test_aspNetMvc_ef.Service
{
    public class PurchaseService
    {
        public string Buy(Purchase purchase)
        {
            DataBaseContext db = new DataBaseContext();
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thank's " + purchase.Person + " за покупку!";
        }
    }
}