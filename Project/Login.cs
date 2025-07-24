using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroFramework.Forms;

namespace Project
{
    public partial class Login: MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }





        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if(string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All the information is required");
                return;
            }

            try
            {
                string checkQuery = "Select count(*) as ct from UserInfo where Email = '" + email + "'";
                DataTable dtc = DataAccess.GetQueryData(checkQuery);

                int count = (int)dtc.Rows[0]["ct"];

                if (count == 0)
                {
                    MessageBox.Show("Account does not exist.");
                    return;
                }

                string query = "select * from UserInfo where Email ='"+email+"'";
                DataTable dt = DataAccess.GetQueryData(query);

                string dtemail = dt.Rows[0]["Email"].ToString();
                string dtpassword = dt.Rows[0]["Password"].ToString();
                int dtUserTypeID = (int)dt.Rows[0]["UsertypeID"];
                int dtUserID = (int)dt.Rows[0]["ID"];
                string dtName = dt.Rows[0]["Name"].ToString();

                if (dtpassword != password)
                {
                    this.errorLabel.Visible = true;
                    return;
                }
                if (dtUserTypeID == 2)
                {
                    UserHelper.UserID = dtUserID;
                    UserHelper.UserTypeID = dtUserTypeID;
                    UserHelper.UserName = dtName;
                    Cars2 car = new Cars2();
                    car.Show();
                    this.Hide();
                }
                else if (dtUserTypeID == 1)
                {
                    UserHelper.UserID = dtUserID;
                    UserHelper.UserTypeID = dtUserTypeID;
                    UserHelper.UserName = dtName;
                    Cars car = new Cars();
                    car.Show();
                    this.Hide();
                }
                else
                {
                    UserHelper.UserID = dtUserID;
                    UserHelper.UserTypeID = dtUserTypeID;
                    UserHelper.UserName = dtName;
                    mCars car = new mCars();
                    car.Show();
                    this.Hide();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '*')
            {
                pictureBox1.Image = Properties.Resources.eyeOpen;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBox1.Image = Properties.Resources.eyeClose;
                this.txtPassword.PasswordChar = '*';

            }
        }
    }
}
