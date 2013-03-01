using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ctrip.Test.DALServices.Test
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void GetPkgOrdersTest()
        {
            IDALContext context = new DALContext(); //mock
            IPkgOrderService service = new PkgOrderService(context);
            var pkgOrders = service.GetPkgOrders();
        }
    }
}
