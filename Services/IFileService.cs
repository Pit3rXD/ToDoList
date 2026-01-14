using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Services
{
    public interface IFileService
    {
        List<TaskItem> Load();
        void Save (List<TaskItem> tasks);
    }
}
