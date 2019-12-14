using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ChelseaManager.Models
{
    class ChelseaManagerContext : DbContext
    {
        public ChelseaManagerContext() : base("AppContext")
        {

        }

       // public virtual DbSet<Players_View> Players_View { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Coach> Coaches { get; set; }

        public virtual DbSet<Position> Positiones{ get; set; }

        public virtual DbSet<CoachRole> Roles { get; set; }
    }
}
