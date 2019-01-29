using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlutoDBFirst
{
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
        }
    }
}