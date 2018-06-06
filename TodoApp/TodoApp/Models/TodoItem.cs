using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models {
    public class TodoItem {
        public bool done { get; internal set; }
        public string name { get; internal set; }
    }
}