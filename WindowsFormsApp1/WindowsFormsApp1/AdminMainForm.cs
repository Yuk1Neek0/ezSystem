using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
namespace WindowsFormsApp1
{
    public partial class AdminMainForm : Form
    {
        public static SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\document\database.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=true");
        public AdminMainForm()
        {
            InitializeComponent();
            displayStudentData();
        }
        public void displayStudentData()
        {
            List<StudentsData> listData = StudentList.studentListData();
            student_Data.DataSource = listData;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e) // add student's info to database
        {
            if (student_ID.Text == ""||student_FirstName.Text==""||student_LastName.Text==""||student_Sex.Text==""||student_Program.Text=="")
            {
                MessageBox.Show("Please enter student's whole information!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Connect.State != ConnectionState.Open)
                {
                    try
                    {
                        Connect.Open();
                        if (studentExist()) 
                        {
                            MessageBox.Show("Student's ID has been used!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertStudent = "INSERT INTO student (stuId,firstName,lastName,sex,program) VALUES(@id,@fname,@lname,@sex,@program)";

                            using (SqlCommand cmd = new SqlCommand(insertStudent, Connect))
                            {
                                cmd.Parameters.AddWithValue("@id", student_ID.Text);
                                cmd.Parameters.AddWithValue("@fname", student_FirstName.Text);
                                cmd.Parameters.AddWithValue("@lname", student_LastName.Text);
                                cmd.Parameters.AddWithValue("@sex", student_Sex.Text);
                                cmd.Parameters.AddWithValue("@program", student_Program.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Student Information Add Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayStudentData();
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) // search student's info from database
        {
            if (student_ID.Text == "")
            {
                MessageBox.Show("Please enter student's ID", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Connect.State != ConnectionState.Open)
                {
                    try
                    {
                        Connect.Open();
                        if (!studentExist()) 
                        {
                            MessageBox.Show("Student Not Found!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string searchStudent = "SELECT * FROM student WHERE stuId = @id";
                            using (SqlCommand cmd = new SqlCommand(searchStudent, Connect))
                            {
                                cmd.Parameters.AddWithValue("@id", student_ID.Text);
                                SqlDataReader reader = cmd.ExecuteReader();
                                List<StudentsData> listdata = new List<StudentsData>();

                                while (reader.Read())
                                {
                                    StudentsData studentData = new StudentsData();
                                    studentData.studentID = (int)reader["stuId"];
                                    studentData.studentFName = reader["firstName"].ToString();
                                    studentData.studentLName = reader["lastName"].ToString();
                                    studentData.studentSex = reader["sex"].ToString();
                                    studentData.studentProgram = reader["program"].ToString();
                                    listdata.Add(studentData);
                                }
                                student_Data.DataSource = listdata;
                                MessageBox.Show("Student Information Search Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                }
            }
        }

        public bool studentExist()
        {
            string searchStudent = "SELECT * FROM student WHERE stuId = @id";
            using (SqlCommand cmd = new SqlCommand(searchStudent, Connect))
            {
                cmd.Parameters.AddWithValue("@id", student_ID.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count <= 0)  return false;
                else return true;
            }

               
        }

        private void updateBtn_Click(object sender, EventArgs e) // UPDATE student's info from database
        {
            if (student_ID.Text == "")
            {
                MessageBox.Show("Please enter student's ID", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Connect.State != ConnectionState.Open)
                {
                    try
                    {
                        Connect.Open();
                        if (!studentExist())
                        {
                            MessageBox.Show("Student Not Found!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string updateStudent = "Update student SET firstName = @fname, lastName = @lname, sex = @sex, program = @program " +
                                "WHERE stuId=@id";
                            using (SqlCommand cmd = new SqlCommand(updateStudent, Connect))
                            {
                                cmd.Parameters.AddWithValue("@id", student_ID.Text);
                                cmd.Parameters.AddWithValue("@fname", student_FirstName.Text);
                                cmd.Parameters.AddWithValue("@lname", student_LastName.Text);
                                cmd.Parameters.AddWithValue("@sex", student_Sex.Text);
                                cmd.Parameters.AddWithValue("@program", student_Program.Text);
                                
                                cmd.ExecuteNonQuery();
                                displayStudentData();

                                MessageBox.Show("Student Information Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                }
            }
        }

        private void student_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e) //Delete student's info from database
        {
            if (student_ID.Text == "")
            {
                MessageBox.Show("Please enter student's ID", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Connect.State != ConnectionState.Open)
                {
                    try
                    {
                        Connect.Open();
                        if (!studentExist())
                        {
                            MessageBox.Show("Student Not Found!", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure to delete this student?", "Warning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            {
                                MessageBox.Show("Delete has been cancled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string deleteStudent = "DELETE FROM student WHERE stuId = @id";
                                using (SqlCommand cmd = new SqlCommand(deleteStudent, Connect))
                                {
                                    cmd.Parameters.AddWithValue("@id",student_ID.Text);
                                    cmd.ExecuteNonQuery();

                                    displayStudentData();
                                    MessageBox.Show("Student Information Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            displayStudentData();
        }
    }
}
