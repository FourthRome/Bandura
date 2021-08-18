using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    interface ICourseSequenceElement
    {
        public Task LoadTreeFromDb();
        public Task FillFlatCourseTree(List<int> tree);
    }
}
