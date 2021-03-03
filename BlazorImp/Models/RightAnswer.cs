﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class RightAnswer
    {
        public int RightAnswerId { get; set; }

        public string? Value { get; set; }

        public int? QuestionId { get; set; }
        public Question? Question { get; set; }
    }
}
