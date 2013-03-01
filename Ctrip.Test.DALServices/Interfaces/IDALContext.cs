using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ctrip.Test.DALServices
{
    public interface IDALContext : IUnitOfWork
    {
        IPkgOrderRepository PkgOrders { get; }
    }
}
