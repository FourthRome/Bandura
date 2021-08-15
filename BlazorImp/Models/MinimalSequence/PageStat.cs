namespace BlazorImp.Models
{
    public class PageStat
    {
        public int PageStatID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public bool HasTaskStat { get; set; }
        public bool? CorrectAsnwerGiven { get; set; }
    }
}
