using System.IO.Pipes;

internal class Program
{
    private static void Main(string[] args)
    {

    }
    class TaskItem
    {
        private string _title;
        private DateTime _dateAdded;
        private DateTime? _dueDate;
        private bool _isCompleted;

        public int Id { get; }
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty");
                }
                _title = value;
            }
        }
        public DateTime DateAdded { get; private set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(int id, string title, DateTime dateAdded, DateTime? dueDate, bool isCompelete)
        {
            Id = id;
            Title = title;
            DateAdded = dateAdded;
            DueDate = dueDate;
            IsCompleted = isCompelete;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"[{Id}] {Title} (added: {DateAdded:yyyy-MM-dd}, due: {DueDate?.ToString("yyyy-MM-dd") ?? "none"}, status: {(IsCompleted ? "complete" : "pending")})");
        }
    }
}