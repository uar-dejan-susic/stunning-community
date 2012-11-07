using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StunningCommunity.Model;

namespace StunningCommunity.Data
{
    public class StunningContext : DbContext
    {

        public StunningContext() : base( "StunningCommunity" ) { }

        public ObjectContext ObjectContext { get { return ( (IObjectContextAdapter)this ).ObjectContext; } }

        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            base.OnModelCreating( modelBuilder );
        }

    }
}
