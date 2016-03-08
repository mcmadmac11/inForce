using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace inForce.Models
{
    public class InForceDbContext : DbContext
    {
        DbSet<Agent> Agents { get;set; }
        DbSet<Company> Companies { get; set; }

        public System.Data.Entity.DbSet<inForce.Models.Salesforce.Contact> Contacts { get; set; }

        public InForceDbContext() : base("DefaultConnection")
        {

        }
    }
}