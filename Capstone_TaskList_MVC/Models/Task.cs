using System;
using System.Collections.Generic;

namespace Capstone_TaskList_MVC.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool CompletedStatus { get; set; }
        public string Userid { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
