namespace BlazorImp.Models
{
    public class CourseElement
    {
        public int CourseElementID { get; set; }
        public CourseElementType Type { get; set; }
        public int? PageID { get; set; }
        public int? CourseElementSequenceID { get; set; }
    }

    public enum CourseElementType
    {
        None,
        Page,
        CourseElementSequence
    }
}
