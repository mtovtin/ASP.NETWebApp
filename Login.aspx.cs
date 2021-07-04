using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResidentsApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var valid = false;
            var userName = UserTextBox.Text.Trim();
            var userPassword = PasswordTextBox.Text.Trim();
            foreach(var user in DataProvider.Users)
            {
                if (user.Key == userName && user.Value == userPassword)
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
                Response.Redirect("MainPage.aspx");
        }
    }
}