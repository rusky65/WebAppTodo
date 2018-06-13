using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models {

    public class MyDb {

        public static List<TodoItem> listToBuy = new List<TodoItem>() {
            new TodoItem() { Id=1, Name = "salt", Done = true },
            new TodoItem() { Id=2, Name = "candy", Done = false },
            new TodoItem() { Id=3, Name = "spaghetti", Done = true },
            new TodoItem() { Id=4, Name = "beef", Done = false },
            new TodoItem() { Id=5, Name = "tomato", Done = false }
            };
    }
}