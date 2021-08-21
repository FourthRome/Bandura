using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using BlazorImp.Data;

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


        [NotMapped]
        public CourseSequence ParentSequence { get; set; }
        [NotMapped]
        private BlazorImpContext DbContext { get; set; }  // TODO: Find out if the context here can be lost or preserved for too long
        [NotMapped]
        public bool ShouldPropagateProgress { get; set; } = true;

        public Page()
        {
        }

        private Page(BlazorImpContext dbContext)
        {
            DbContext = dbContext;
        }


        public async Task LoadTreeFromDb()
        {
        }

        public async Task FillFlatCourseTree(List<Page> tree)
        {
            tree.Add(this);
        }

        public async Task<(int, int)> GetScore(int courseID, int userID, bool calledByParent=true)
        {
            int score = 0;
            int maxScore = 0;
            if (PageType == PageType.TaskPage)
            {
                maxScore = 1;
                PageStat stat = await DbContext.PageStats.Where(
                        s =>
                        s.CourseID == courseID &&
                        s.UserID == userID &&
                        s.PageID == PageID)
                        .FirstOrDefaultAsync();
                if (stat != null)
                {
                    score = stat.CorrectAnswerGiven ? 1 : 0;
                }
            }

            return (score, maxScore);
        }
    }

    public enum PageType
    {
        None,
        InfoPage,
        SurveyPage,
        VideoPage,
        TaskPage,
        FinalPage,
        ScorePage
    }
}
