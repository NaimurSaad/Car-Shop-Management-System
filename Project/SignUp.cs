using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class SignUp: MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;
            string cpassword = this.txtCPassword.Text;
            string gender = "";
            if (this.rbtnMale.Checked)
            {
                gender = this.rbtnMale.Text;
            }
            else if(this.rbtnFemale.Checked)
            {
                gender = this.rbtnFemale.Text;
            }

            string dob = dobSelect.Value.ToString("yyyy-MM-dd");


            string address = this.txtAddress.Text;
            string mobile = this.txtMobile.Text;

            if (string.IsNullOrWhiteSpace(name)
                || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(cpassword)
                || string.IsNullOrWhiteSpace(gender)
                || string.IsNullOrWhiteSpace(dob)
                || string.IsNullOrWhiteSpace(address)
                || string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("All information is required");
                return;
            }
            if (password!=cpassword)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            try
            {
                string checkQuery = "Select count(*) as ct from UserInfo where Email = '" + email + "'";
                DataTable dt = DataAccess.GetQueryData(checkQuery);

                int count = (int)dt.Rows[0]["ct"];

                if (count > 0)
                {
                    MessageBox.Show("Email already exists. Please use a different one.");
                    return;
                }

                string query = "insert into UserInfo (Name, Email, Password, Gender, Dob, Address, Mobile, UsertypeID) values ('" + name + "','" + email + "','" + password + "','" + gender + "','" + dob + "','" + address + "','" + mobile + "',2)";
                DataAccess.ExecuteNonResultQuery(query);



                MessageBox.Show("Account created successfully");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void passhideshow_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '*')
            {
                passhideshow.Image = Properties.Resources.eyeOpen;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                passhideshow.Image = Properties.Resources.eyeClose;
                this.txtPassword.PasswordChar = '*';

            }
        }


    }
}
