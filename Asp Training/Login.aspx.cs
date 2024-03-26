using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Asp_Training
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True");
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string passwd = TextBox2.Text;
            string selectquery = $"SELECT * FROM Candidate where Username = @uname AND Password = @passwd";
            using (SqlCommand command = new SqlCommand(selectquery, connection))
            {
                command.Parameters.AddWithValue("@uname", uname);
                command.Parameters.AddWithValue("@passwd", passwd);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    if (reader.HasRows)
                    {
                        Session["LoggedIn"] = true;
                        Session["Username"] = uname;
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Logged In Successfully..!'); setTimeout(function(){ window.location.href = 'Default.aspx'; }, 1000);", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Invalid Username or Password..!')", true);
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please Enter the credentials..!')", true);
                }
            }
        }
    }
}