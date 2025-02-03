using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    internal class StudentList
    {
        public static SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\document\database.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=true");
        public static List<StudentsData> studentListData()
        {

            List<StudentsData> listdata= new List<StudentsData> ();

            if(Connect.State!= ConnectionState.Open)
            {
                try
                {
                    Connect.Open();

                    string selectData = "SELECT * FROM student";

                    using (SqlCommand cmd = new SqlCommand(selectData, Connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            StudentsData studentData = new StudentsData();
                            studentData.studentID = (int)reader["stuId"];
                            studentData.studentFName = reader["firstName"].ToString();
                            studentData.studentLName = reader["lastName"].ToString();
                            studentData.studentSex = reader["sex"].ToString();
                            studentData.studentProgram = reader["program"].ToString();
                            listdata.Add(studentData);
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
            return listdata;

        }
    }
}
