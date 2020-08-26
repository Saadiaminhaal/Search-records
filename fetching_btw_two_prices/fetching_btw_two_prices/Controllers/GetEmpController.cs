using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fetching_btw_two_prices.Controllers
{
    public class GetEmpController : Controller
    {
        fetching_btw_two_pricesEntities db = new fetching_btw_two_pricesEntities();
        // GET: GetEmp
        public ActionResult Index()
        {
            return View(db.Employeees.ToList());
        }
        [HttpPost]
        public ActionResult Index(float start, float end)
        {
            return View(db.GetFunctionEmp(start,end));
        }
    }
}