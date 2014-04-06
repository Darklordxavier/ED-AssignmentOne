using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supervisor_Screen
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //User currentUser = someDatabase.CurrentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //lblCurrentUser.Text = currentUser.Name;
            //lblcurrentdepartment.text = currentuser.department.name;
            //lbldepartmentbudget.text = currentuser.department.budget;
            //lblremainingbudget.text = currentuser.department.remainingbudget;
            //GridViewReports.DataSource = do something here to get ALL the reports in THIS depeartment
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                //GridViewReports -> display all reports
            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {
                //GridViewReports -> display all approved reports
            }
            else
            {
                //display all the rejected reports
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            lblCurrentUser = null; //or something like thiss
        }

        protected void btnViewReport_Click(object sender, EventArgs e)
        {
            //Report report = GridViewReports.SelectedRow.ID; //Get a report object from the database based on the ID of the report, that's the idea

        }
    }
}