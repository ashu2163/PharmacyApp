using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy_App
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(Session["Customer_Id"] ==null)
            {
                Response.Redirect("Login.aspx");
            }*/
           /* Label1.Visible = false;
           DropDownList2.Visible = false;
            TextBox1.Visible = false;*/

        }
        PharmacyApp_DBEntities5 db = new PharmacyApp_DBEntities5();
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                DropDownList2.DataSource = (from md in db.medicines
                                            join sr in db.sellers on DropDownList1.SelectedItem.Text equals sr.seller_city
                                            join s_m in db.seller_medicine on sr.seller_id equals s_m.seller_id
                                            where md.medicine_id == s_m.medicine_id
                                            select md.medicine_name).ToList().Distinct();

                DropDownList2.DataBind();
                TextBox1.Visible = true;
                DropDownList2.Visible = true;

            }
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(DropDownList2.SelectedItem.Text);
            ListBox1.Items.Add(DropDownList2.SelectedItem.Text);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
                if (DropDownList1.SelectedItem == null)
                {
                    Label1.Visible = true;
                    Label1.Text = "Please select city first";
                }

                DropDownList2.DataSource = (from md in db.medicines
                                            join sr in db.sellers on DropDownList1.SelectedItem.Text equals sr.seller_city
                                            join s_m in db.seller_medicine on sr.seller_id equals s_m.seller_id
                                            where md.medicine_id == s_m.medicine_id && (TextBox1.Text == md.medicine_name || TextBox1.Text == md.medicine_type)
                                            select md.medicine_name).ToList().Distinct();

                DropDownList2.DataBind();
            
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}