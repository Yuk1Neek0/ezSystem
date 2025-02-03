using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\document\database.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void register_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Messgae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        Connect.Open();

                        string selectAccount = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = @status"; // Using sql check username

                        using (SqlCommand cmd = new SqlCommand(selectAccount, Connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", login_userName.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table= new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AdminMainForm adminMainForm = new AdminMainForm();

                                adminMainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Register Failed! Incorrect Username/Password/Inactive Condition", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool emptyFields()
        {
            if (login_password.Text == "" || login_userName.Text == "")
            {
                return true;
            }
            else return false;
        }
    }
}
