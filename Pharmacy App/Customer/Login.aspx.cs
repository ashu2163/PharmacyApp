using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Net;
using System.Web.Security;
using System.Data.SqlClient;

namespace Pharmacy_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            String str = WebConfigurationManager.ConnectionStrings["PharmacyApp_DBConnectionString"].ConnectionString;
            SqlConnection myconn = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myconn;
            cmd.CommandText = "Select * from Customer";
            myconn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (Login1.UserName == rdr["customer_email"].ToString() && Login1.Password == rdr["customer_password"].ToString())
                {
                    Session["Customer_Id"] = rdr["customer_email"];
                    // Session["name"] = Login1.UserName;
                    //FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                    Response.Redirect("Home.aspx");
                }
            }
            myconn.Close();


        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/A-Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Seller/S-Login.aspx");
        }
    }
}