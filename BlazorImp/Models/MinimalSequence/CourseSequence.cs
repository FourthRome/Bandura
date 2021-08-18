using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BlazorImp.Data;

namespace BlazorImp.Models
{
    public class CourseSequence: ICourseSequenceElement
    {
        public int CourseSequenceID { get; set; }
        public string Title { get; set; }  // For convenience purposes; it can be left blank 

        [NotMapped]
        private BlazorImpContext DbContext { get; set; }  // TODO: Find out if the context here can be lost or preserved for too long

        [NotMapped]
        private List<ICourseSequenceElement> Sequence { get; set; } = new();

        public CourseSequence()
        {
        }

        private CourseSequence(BlazorImpContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task LoadTreeFromDb()
        {
            // This function is called recursively and is potentially problematic
            // For now I'll try to call it explicitly, which leaves any CourseElement object that is
            // just created not fully initialized (if you don't count empty Sequence property created by default)
            // var context = DbFactory.CreateDbContext();

            // TODO: Don't rely on DbContext being available, read about options
            var childrenElementsQuery = from element in DbContext.CourseSequenceElements
                                        where element.ParentCourseSequenceID == CourseSequenceID
                                        orderby element.ElementIndex
                                        select element;

            foreach (CourseSequenceElement element in childrenElementsQuery)
            {
                if (element.Type == CourseElementType.Sequence)
                {
                    CourseSequence seq = await DbContext.CourseSequences.Where(
                            s =>
                            s.CourseSequenceID == element.CourseSequenceID)  // TODO: Make this code null-safe
                            .FirstAsync();
                    await seq.LoadTreeFromDb();  // Here is a potential issue, as the tree can technically get recursive
                    Sequence.Add(seq);
                }
                else if (element.Type == CourseElementType.Page)
                {
                    Page page = await DbContext.Pages.Where(
                            p =>
                            p.PageID == element.PageID)  // TODO: Make this code null-safe
                            .FirstAsync();
                    await page.LoadTreeFromDb();  // There is, however, no problem here, as Pages are leaf nodes
                    Sequence.Add(page);
                }
            }
        }

        public async Task FillFlatCourseTree(List<int> tree)
        {
            foreach (ICourseSequenceElement element in Sequence)
            {
                await element.FillFlatCourseTree(tree);
            }
        }
    }
}
