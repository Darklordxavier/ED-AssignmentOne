using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlueConsultingBusinessLogic;

namespace GUI.DepartmentSupervisor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const double TOTAL_BUDGET = 10000;
        protected void Page_Load(object sender, EventArgs e)
        {
            updatePage();
        }

        private void updatePage()
        {
            lblCurrentUser.Text = User.Identity.Name;
            lblDepartmentName.Text = DatabaseAccess.getDepartmentName(User.Identity.Name);
            lblTotalBudget.Text = "$" + TOTAL_BUDGET;
            lblRemainingBudget.Text = "";
        }
    }
}