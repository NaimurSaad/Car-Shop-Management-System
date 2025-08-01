﻿using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class EditProfile: MetroForm
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        string oldEmail = "";
        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {

                string query = "select * from UserInfo where ID =" + UserHelper.UserID;

                DataTable dt = DataAccess.GetQueryData(query);

                oldEmail = dt.Rows[0]["Email"].ToString();

                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                if (dt.Rows[0]["Gender"].ToString() == "Male")
                {
                    this.rbtnMale.Checked = true;
                }
                else
                {
                    this.rbtnFemale.Checked = true;
                }
                dobSelect.Value = Convert.ToDateTime(dt.Rows[0]["Dob"]);

                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtMobile.Text = dt.Rows[0]["Mobile"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void saveBtn_Click(object sender, EventArgs e)
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
            else if (this.rbtnFemale.Checked)
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
            if (password != cpassword)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            try
            {
                if (oldEmail != email)
                {
                    string checkQuery = "Select count(*) as ct from UserInfo where Email = '" + email + "'";
                    DataTable dt = DataAccess.GetQueryData(checkQuery);

                    int count = (int)dt.Rows[0]["ct"];

                    if (count > 0)
                    {
                        MessageBox.Show("Email already exists. Please use a different one.");
                        return;
                    }
                    string query = "update UserInfo set Name = '" + name + "', Email = '" + email + "', Password = '"
                                    + password + "', Gender = '" + gender + "', Dob = '" + dob + "', Address = '" + address + "', Mobile = " + mobile + " where ID = " + UserHelper.UserID;

                    DataAccess.ExecuteNonResultQuery(query);
                    UserHelper.UserName = name;
                    MessageBox.Show("Saved");
                    this.Hide();
                }
                else
                {
                    string query = "update UserInfo set Name = '" + name + "', Email = '" + email + "', Password = '"
                                    + password + "', Gender = '" + gender + "', Dob = '" + dob + "', Address = '" + address + "', Mobile = " + mobile + " where ID = " + UserHelper.UserID;

                    DataAccess.ExecuteNonResultQuery(query);
                    UserHelper.UserName = name;
                    MessageBox.Show("Saved");
                    this.Hide();
                }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
