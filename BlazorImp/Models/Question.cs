using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public enum QuestionType
    {
        WithoutRightAnswer,
        Regular,
        Quiz
    }

    public class Question
    {
        public int QuestionId { get; set; }

        public string Value { get; set; }

        public QuestionType QuestionType { get; set; }

        public int RightAnswerId { get; set; }
        public RightAnswer RightAnswer { get; set; }

        public int? QuizDataId { get; set; }
        public QuizData? QuizData { get; set; }

        public int? AdditionalDataId { get; set; }
        public QuestionAdditionalData? AdditionalData { get; set; }
    }
}
