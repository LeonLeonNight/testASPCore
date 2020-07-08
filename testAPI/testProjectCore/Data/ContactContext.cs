using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProjectCore.Models;

namespace testProjectCore.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
