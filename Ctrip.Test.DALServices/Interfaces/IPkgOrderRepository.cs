using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ctrip.Test.Model;

namespace Ctrip.Test.DALServices
{
    public interface IPkgOrderRepository : IRepository<PkgOrder>
    {
        IEnumerable<PkgOrder> GetPkgOrders();

        PkgOrder GetPkgOrder(int pkgOrderId);
    }
}
