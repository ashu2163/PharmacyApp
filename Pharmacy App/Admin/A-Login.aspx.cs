using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy_App.Admin
{
    public partial class A_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            String str = WebConfigurationManager.ConnectionStrings["PharmacyApp_DBConnectionString"].ConnectionString;
            SqlConnection myconn = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myconn;
            cmd.CommandText = "Select * from admin";
            myconn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (Login1.UserName == rdr["admin_email"].ToString() && Login1.Password == rdr["admin_password"].ToString())
                {
                    Session["admin_Id"] = rdr["admin_email"];
                    // Session["name"] = Login1.UserName;
                    //FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                    Response.Redirect("Home.aspx");
                }
            }
            myconn.Close();

        }
    }
}