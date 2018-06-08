using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers {
    public class TodoController : Controller {

        public ActionResult Index() {
            return View(MyDb.listToBuy);
        }

        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, bool isDone ) {

            if (!string.IsNullOrEmpty(name)) {
                MyDb.listToBuy.Add(new TodoItem() { Name = name, Done = isDone });

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}