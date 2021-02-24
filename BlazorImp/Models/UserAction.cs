using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class UserAction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        public long? Timestamp { get; set; }
        public string Context { get; set; }
    }
}
