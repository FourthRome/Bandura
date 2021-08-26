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
        public bool ShouldPropagateProgress { get; set; } = true;

        private IDbContextFactory<BlazorImpContext> _dbContextFactory;

        public async Task LoadTreeFromDb(IDbContextFactory<BlazorImpContext> dbFactory)
        {
            // TODO: This is a REALLY dirty hack
            // Find a way to refactor this; probably Entities should be left as POCO classes,
            // not these super-entities
            _dbContextFactory = dbFactory;
        }

        public async Task FillFlatCourseTree(List<Page> tree)
        {
            tree.Add(this);
        }

        public async Task<(int, int)> GetScore(int courseID, int userID, bool calledByParent=true)
        {
            using var context = _dbContextFactory.CreateDbContext();
            int score = 0;
            int maxScore = 0;
            if (PageType == PageType.TaskPage)
            {
                maxScore = 1;
                PageStat stat = await context.PageStats.Where(
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
