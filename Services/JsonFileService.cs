using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ToDoList.Services
{
    internal class JsonFileService : IFileService
    {
        private readonly string _filePath = "tasks.json";

        public List<TaskItem> Load()
        {
            if (!File.Exists(_filePath))
            {
                return new List<TaskItem>();
            }
            string json = File.ReadAllText(_filePath);
            var tasks = JsonSerializer.Deserialize<List<TaskItem>>(json);

            return tasks ?? new List<TaskItem>();
        }

        public void Save(List<TaskItem> tasks)
        {
            var options = new JsonSerializerOptions { WriteIndented = true}; // zapytaj czata o to
            string json = JsonSerializer.Serialize(tasks, options);
            File.WriteAllText(_filePath, json);
        }
    }
}
