using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlutoDBFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new PlutoDbContext();
            //var courses = context.GetCourses();
            var courses = context.GetCourses();

            ASPxGridView1.DataSource = courses.ToList();
            ASPxGridView1.DataBind();
            ASPxGridView1.KeyFieldName = "CourseID";

            var course = new Course();
            //course.Level = CourseLevel.Beginner;
            course.Level = Level.Intermediate;
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            SortTable();
        }

        /// <summary>
        /// Place Title column in position 4
        /// </summary>
        private void SortTable()
        {
            ASPxGridView1.Columns["Title"].VisibleIndex = 4;
        }
    }
}