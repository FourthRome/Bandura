namespace BlazorImp.Models
{
    public class CourseSequenceElement
    {
        public int CourseSequenceElementID { get; set; }
        public int ParentCourseSequenceID { get; set; }
        public int ElementIndex { get; set; }
        public CourseElementType Type { get; set; }
        public int? PageID { get; set; }  // This object can represent a page
        public int? CourseSequenceID { get; set; }  // Or a sequence (these should be mutually exclusive)
    }


    public enum CourseElementType
    {
        None,
        Page,
        Sequence
    }
}
