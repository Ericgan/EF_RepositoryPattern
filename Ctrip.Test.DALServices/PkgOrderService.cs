using System.Collections.Generic;
using Ctrip.Test.Model;

namespace Ctrip.Test.DALServices
{
    public class PkgOrderService : IPkgOrderService
    {
        private IDALContext context;

        public PkgOrderService(IDALContext context)
        {
            this.context = context;
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return context.PkgOrders.GetPkgOrders();
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return context.PkgOrders.GetPkgOrder(pkgOrderId);
        }
    }
}
