using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Training
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string createTableQuery = $"CREATE TABLE Employees (" +
                                        $"Id int primary key," +
                                        $"Firstname varchar(50)," +
                                        $"Lastname varchar(50)," +
                                        $"Email varchar(50)" +
                                        ")";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        successMessage.Text = "Employee Table created successfully.";
                        errorMessage.Text = "";
                        successMessage.Visible = true;
                        errorMessage.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error creating table: " + ex.Message;
                        successMessage.Visible = false;
                        errorMessage.Visible = true;
                    }
                }
            }
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            string displayQuery = $"SELECT * FROM Employees";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(displayQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                        reader.Close();
                        successMessage.Text = "Data Retrieved Successfully";
                        errorMessage.Text = "";
                        successMessage.Visible = true;
                        errorMessage.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error retrieving data: " + ex.Message;
                        successMessage.Visible = false;
                        errorMessage.Visible = true;
                    }
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string value1 = TextBox6.Text;
            string value2 = TextBox7.Text;
            string value3 = TextBox8.Text;
            string value4 = TextBox9.Text;
            string insertQuery = $"INSERT INTO Employees " +
                                 $"(Id, Firstname, Lastname, Email) " +
                                 $"VALUES (@id, @fname, @lname, @email)";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", value1);
                    command.Parameters.AddWithValue("@fname", value2);
                    command.Parameters.AddWithValue("@lname", value3);
                    command.Parameters.AddWithValue("@email", value4);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        successMessage.Text = "Record inserted successfully.";
                        errorMessage.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        successMessage.Visible = true;
                        errorMessage.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error inserting values: " + ex.Message;
                        successMessage.Visible = false;
                        errorMessage.Visible = true;
                    }
                }
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Button btnSelect = (Button)sender;
            GridViewRow row = (GridViewRow)btnSelect.NamingContainer;
            if (row != null)
            {
                int rowIndex = row.RowIndex;

                if (rowIndex >= 0 && rowIndex < GridView1.Rows.Count)
                {
                    GridViewRow selectedRow = GridView1.Rows[rowIndex];
                    string id = selectedRow.Cells[0].Text;
                    string firstName = selectedRow.Cells[1].Text;
                    string lastName = selectedRow.Cells[2].Text;
                    string email = selectedRow.Cells[3].Text;
                    TextBox6.Text = id;
                    TextBox7.Text = firstName;
                    TextBox8.Text = lastName;
                    TextBox9.Text = email;
                    successMessage.Text = "Record fetched Successfully";
                    errorMessage.Text = "";
                    successMessage.Visible = true;
                    errorMessage.Visible = false;
                }
                else
                {
                    successMessage.Text = "";
                    errorMessage.Text = "Error fetching data: Row index is out of range.";
                    successMessage.Visible = false;
                    errorMessage.Visible = true;
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string value1 = TextBox6.Text;
            string value2 = TextBox7.Text;
            string value3 = TextBox8.Text;
            string value4 = TextBox9.Text;
            string updateQuery = $"UPDATE Employees SET Firstname = @fname, Lastname = @lname, Email = @email WHERE Id = @id";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", value1);
                    command.Parameters.AddWithValue("@fname", value2);
                    command.Parameters.AddWithValue("@lname", value3);
                    command.Parameters.AddWithValue("@email", value4);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        successMessage.Text = "Record updated successfully.";
                        errorMessage.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        successMessage.Visible = true;
                        errorMessage.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error updating data: " + ex.Message;
                        successMessage.Visible = false;
                        errorMessage.Visible = true;
                    }
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string value1 = TextBox6.Text;
            string value2 = TextBox7.Text;
            string value3 = TextBox8.Text;
            string value4 = TextBox9.Text;
            string deleteQuery = $"DELETE FROM Employees where Id = @id";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", value1);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            successMessage.Text = "Record deleted successfully.";
                            errorMessage.Text = "";
                            successMessage.Visible = true;
                            errorMessage.Visible = false;
                        }
                        else
                        {
                            successMessage.Text = "";
                            errorMessage.Text = "No records found with the provided Id.";
                            successMessage.Visible = false;
                            errorMessage.Visible = true;
                        }
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error deleting data: " + ex.Message;
                    }
                }
            }
        }
        protected void btnDrop_Click(object sender, EventArgs e)
        {
            string dropTableQuery = $"DROP TABLE Employees";
            string connectionString = "Data Source=DESKTOP-I5NO16G\\SQLEXPRESS2019;Initial Catalog=Asp_training;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(dropTableQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        successMessage.Text = "Employee Table dropped successfully.";
                        errorMessage.Text = "";
                        successMessage.Visible = true;
                        errorMessage.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        successMessage.Text = "";
                        errorMessage.Text = "Error dropping table: " + ex.Message;
                        successMessage.Visible = false;
                        errorMessage.Visible = true;
                    }
                }
            }
        }
    }
}
