using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    interface ICourseSequenceElement
    {
        public CourseSequence ParentSequence { get; set; }
        public bool ShouldPropagateProgress { get; set; }

        public Task LoadTreeFromDb();
        public Task FillFlatCourseTree(List<Page> tree);
        public Task<(int, int)> GetScore(int courseID, int userID, bool calledByParent);
    }
}
