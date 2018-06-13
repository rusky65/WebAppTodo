using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers {
    public class TodoController : Controller {

        Db db = new Db();

        public ActionResult Index() {
            return View(db.TodoItems.ToList());
        }

        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, bool done ) {

            if (!string.IsNullOrEmpty(name)) {
                db.TodoItems.Add(new TodoItem() { Name = name, Done = done });

                //to save changes into database have to call the "SaveChanges()"
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        /// <summary>
        /// Item to display for editing.
        /// </summary>
        /// <param name="id">unique key of the item</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id) {
            //we have to search the item for editing.

            //this is a filtered list
            //MyDb.listToBuy.Where(x=>x.Id==id);

            var item = db.TodoItems.Single(x => x.Id == id);

            // if we confused to get the exact item. item can get the null value.
            //var item = MyDb.listToBuy.SingleOrDefault(x => x.Id == id);

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, string name, bool done) {
            var item = db.TodoItems.Single(x => x.Id == id);
            item.Name = name;
            item.Done = done;

            //to save changes into database have to call the "SaveChanges()"
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete (int id) {
            var item = db.TodoItems.Single(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id) {
            var item = db.TodoItems.Single(x => x.Id == id);
            db.TodoItems.Remove(item);

            //to save changes into database have to call the "SaveChanges()"
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id) {
            var item = db.TodoItems.Single(x => x.Id == id);

            return View(item);
        }
    }
}