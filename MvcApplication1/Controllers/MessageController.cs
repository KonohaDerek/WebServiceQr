using MvcApplication1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MessageController : Controller
    {
        //實做Service的物件
        MessageDBService data = new MessageDBService();

        //
        // GET: /Message/

        public ActionResult Index()
        {
            return View(data.GetData());
        }

        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(String Article_title,String Content) {
            //呼叫Service中的DBCreate方法
            data.DBCreate(Article_title, Content);
            //導向指定的Action
            return RedirectToAction("Index");




        }


    }
}
