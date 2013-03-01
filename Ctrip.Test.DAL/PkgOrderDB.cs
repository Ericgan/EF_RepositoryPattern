using System.Data.Entity;
using Ctrip.Test.Model;

namespace Ctrip.Test.DAL
{
    public class PkgOrderDB : DbContext
    {
        public PkgOrderDB() : base("PkgOrderDB"){ }

        public DbSet<PkgOrder> PkgOrders { get; set; }
    }
}
