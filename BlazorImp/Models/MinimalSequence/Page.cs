using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorImp.Models
{
    public class Page: ICourseSequenceElement
    {
        public int PageID { get; set; }
        public PageType PageType { get; set; }
        public int? FinalPageModelID { get; set; }
        public int? InfoPageModelID { get; set; }
        public int? SurveyPageModelID { get; set; }
        public int? TaskPageModelID { get; set; }
        public int? VideoPageModelID { get; set; }

        public async Task LoadTreeFromDb()
        {
        }

        public async Task FillFlatCourseTree(List<int> tree)
        {
            tree.Add(PageID);
        }
    }

    public enum PageType
    {
        None,
        InfoPage,
        SurveyPage,
        VideoPage,
        TaskPage,
        FinalPage
    }
}
