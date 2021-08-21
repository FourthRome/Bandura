namespace BlazorImp.Models
{
    public class PageStat
    {
        public int PageStatID { get; set; }
        public int PageID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public bool CorrectAnswerGiven { get; set; }
    }
}
