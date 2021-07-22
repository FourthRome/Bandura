using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class TaskPageModel
    {
        public int TaskPageModelID { get; set; }
        public string Header { get; set; }
        public string TaskText { get; set; }
        public string UserAnswer { get; set; }
        public int AttemptNumberConstraint { get; set; }
    }
}
