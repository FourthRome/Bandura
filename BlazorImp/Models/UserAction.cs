using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class UserAction
    {
        public int UserActionID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public int? SourcePageID { get; set; }
        public int? DestinationPageID { get; set; }
        public int? TaskAttemptID { get; set; }
        public ActionType Type { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }

    public enum ActionType
    {
        Undefined,
        Login,
        EnterCourse,
        SendSurvey,
        SendTaskAnswer,
        GoToNextStep,
        GoToLastStep,
        GoToMaterial,
        StartTask,
        FinishTask,
        Logout
    }
}
