using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ToDoList;

namespace ToDoList
{
    internal class ToDoManager
    {
        public List<TaskItem> _tasks;
        public readonly string _filePath = "tasks.json";
        public int _lastTaskId;
    }
}
