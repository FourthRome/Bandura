﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int UserID { get; set; }
        public int ModuleID { get; set; }
        public int StepNumber { get; set; }
    }
}
