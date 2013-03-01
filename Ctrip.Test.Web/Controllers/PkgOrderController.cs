using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ctrip.Test.DALServices;
using Ctrip.Test.Model;

namespace Ctrip.Test.Web.Controllers
{
    public class PkgOrderController : Controller
    {
        IPkgOrderService service;

        public PkgOrderController(IPkgOrderService service)
        {
            this.service = service;
        }

        //
        // GET: /PkgOrder/

        public ActionResult Index()
        {
            var pkgOrders = service.GetPkgOrders().Take(20);
            return View(pkgOrders);
        }

    }
}
