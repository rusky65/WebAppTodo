using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers {
    public class TodoController : Controller {
        private List<TodoItem> listToBuy = new List<TodoItem>() {
            new TodoItem() { name = "salt", done = true },
            new TodoItem() { name = "candy", done = false },
            new TodoItem() { name = "spaghetti", done = true },
            new TodoItem() { name = "beef", done = false },
            new TodoItem() { name = "tomato", done = false }
            };

        public ActionResult Index() {
            return View(listToBuy);
        }

        public ActionResult Create(string Name) {

            if (!string.IsNullOrEmpty(Name)) {
                listToBuy.Add(new TodoItem() { name = Name, done = true });

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}