using System.Collections.Generic;
using System.Linq;
using Ctrip.Test.DAL;
using Ctrip.Test.Model;

namespace Ctrip.Test.DALServices
{
    internal class PkgOrderRepository : Repository<PkgOrder>, IPkgOrderRepository
    {
        public PkgOrderRepository(PkgOrderDB context)
            : base(context)
        {
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return from o in DbSet
                   select o;
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return (from o in DbSet
                    where o.OrderId == pkgOrderId
                    select o).FirstOrDefault();
        }
    }
}
