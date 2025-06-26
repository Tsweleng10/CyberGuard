using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class TaskItem
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool Completed { get; set; }

        public void Display()
        {
            Console.WriteLine(Completed ? "[✔]" + Title : "[ ]" + Title);
            Console.WriteLine("  Description: " + Description);
            if (ReminderDate.HasValue)
            {
                Console.WriteLine("  Reminder: " + ReminderDate.Value.ToShortDateString());
            }
            Console.WriteLine();
        }
    }
}
