using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ctrip.Test.Model;

namespace Ctrip.Test.DALServices
{
    public interface IPkgOrderService
    {
        IEnumerable<PkgOrder> GetPkgOrders();

        PkgOrder GetPkgOrder(int id);
    }
}
