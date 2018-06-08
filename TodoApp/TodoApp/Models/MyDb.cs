using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models {

    public class MyDb {

        public static List<TodoItem> listToBuy = new List<TodoItem>() {
            new TodoItem() { Name = "salt", Done = true },
            new TodoItem() { Name = "candy", Done = false },
            new TodoItem() { Name = "spaghetti", Done = true },
            new TodoItem() { Name = "beef", Done = false },
            new TodoItem() { Name = "tomato", Done = false }
            };
    }
}