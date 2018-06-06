using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page. TESZT for modification";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TodoList() {
            var listToBuy = new List<TodoItem>();

            listToBuy.Add(new TodoItem() { name = "salt", done = true } );
            listToBuy.Add(new TodoItem() { name = "candy", done = false });
            listToBuy.Add(new TodoItem() { name = "spaghetti", done = true });
            listToBuy.Add(new TodoItem() { name = "beef", done = false });
            listToBuy.Add(new TodoItem() { name = "tomato", done = false });

            return View(listToBuy);
        }
    }
}