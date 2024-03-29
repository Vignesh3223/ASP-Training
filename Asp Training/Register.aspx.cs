using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Training
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-AUR9CJ4;Initial Catalog=Asp_training;Integrated Security=True");
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string uname = TextBox3.Text;
            string email = TextBox4.Text;
            string passwd = TextBox5.Text;
            string cnfmpasswd = TextBox6.Text;
            string insertQuery = $"INSERT INTO Candidate " +
                                $"(Firstname, Lastname, Username, Email, Password, ConfirmPassword) " +
                                $"VALUES (@fname, @lname, @uname, @email, @passwd, @cnfmpasswd)";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@lname", lname);
                command.Parameters.AddWithValue("@uname", uname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@passwd", passwd);
                command.Parameters.AddWithValue("@cnfmpasswd", cnfmpasswd);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registered Successfully..!'); setTimeout(function(){ window.location.href = 'Login.aspx'; }, 1000);", true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Registration Failed..!')", true);
                }
            }
        }
    }
}
