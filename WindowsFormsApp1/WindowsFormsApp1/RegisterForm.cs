using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\document\database.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=true");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // register_loginBtn
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(emptyFields())
            {
                MessageBox.Show("All fields are required to be filled","Error Messgae",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                if(Connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        Connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern"; // Using sql check username

                        using (SqlCommand checkUsername = new SqlCommand(selectUsername,Connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", register_userName.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)  //check if the name has used or not
                            {
                                string usern = register_userName.Text.Substring(0,1).ToUpper()+ register_userName.Text.Substring(1).ToUpper();
                                MessageBox.Show(usern + "is already taken","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else if (register_cpassword.Text!=register_password.Text)
                            {
                                MessageBox.Show("Password deos not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length<6)
                            {
                                MessageBox.Show("Invalid password,at least 6 digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else
                            {
                                string insertData = "INSERT INTO users (username,password,status) VALUES(@usern,@pass,@status)";
                                using (SqlCommand cmd = new SqlCommand(insertData, Connect)) 
                                {
                                    cmd.Parameters.AddWithValue("@usern",register_userName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", "Active");

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Register Successfully!","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed!"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                } 
                    
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if(register_cpassword.Text == ""||register_password.Text==""||register_userName.Text=="")
            {
                return true;
            }
            else return false;
        }
    }
}
