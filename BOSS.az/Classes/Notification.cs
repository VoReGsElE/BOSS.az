using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS.az.Classes
{
    public class Notification
    {
        private readonly DateTime date = DateTime.Now;
        public string Message { get; set; }

        public Notification(string message)
        {
            Message = message;
        }

        public void Show()
        {
            Console.Write($"Message\n{Message}\nSend Date: {date:F}\n================\n\n");
        }

    }
}
