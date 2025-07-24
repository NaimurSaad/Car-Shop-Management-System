using MetroFramework.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;

namespace Project
{
    public partial class Managers : MetroForm
    {
        public Managers()
        {
            InitializeComponent();
        }

        private int selectedRowIndex = -1;
        private void loadGridData()
        {
            try
            {

                string query = "Select ID, Name, Email, Password, Gender, Dob, Address, Mobile, Salary from UserInfo where UsertypeID = 3";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvManagers.DataSource = dt;
                dgvManagers.Refresh();
                this.clearform();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearform()
        {
            txtID.Text = txtName.Text = txtEmail.Text = txtPassword.Text = txtMobile.Text = txtAddress.Text = txtSalary.Text = "";
            rbtnMale.Checked = rbtnFemale.Checked = false;
            dobSelect.Value = DateTime.Now;
            dgvManagers.ClearSelection();
            this.selectedRowIndex = -1;
        }


        private void Managers_Load(object sender, EventArgs e)
        {
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();
            this.clearform();
        }

        string oldEmail = "";
        private void dgvManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                this.clearform();
                return;
            }
            int id = int.Parse(dgvManagers.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            if (id <= 0)
            {
                MessageBox.Show("Invalid ID");
            }

            this.selectedRowIndex = e.RowIndex;

            try
            {

                string query = "select * from UserInfo where ID =" +id;

                DataTable dt = DataAccess.GetQueryData(query);

                oldEmail = dt.Rows[0]["Email"].ToString();

                txtID.Text = dt.Rows[0]["ID"].ToString();
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
                txtSalary.Text = dt.Rows[0]["Salary"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.clearform();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;
            string gender = "";
            if (this.rbtnMale.Checked)
            {
                gender = this.rbtnMale.Text;
            }
            else if (this.rbtnFemale.Checked)
            {
                gender = this.rbtnFemale.Text;
            }

            string dob = dobSelect.Value.ToString("yyyy-MM-dd HH:mm:ss");


            string address = this.txtAddress.Text;
            string mobile = this.txtMobile.Text;
            string salary = this.txtSalary.Text;

            if (string.IsNullOrWhiteSpace(name)
                || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(gender)
                || string.IsNullOrWhiteSpace(dob)
                || string.IsNullOrWhiteSpace(address)
                || string.IsNullOrWhiteSpace(salary)
                || string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("All information is required");
                return;
            }


            try
            {

                string query = "";

                if (this.selectedRowIndex < 0)
                {
                    string checkQuery = "Select count(*) as ct from UserInfo where Email = '" + email + "'";
                    DataTable dt = DataAccess.GetQueryData(checkQuery);

                    int count = (int)dt.Rows[0]["ct"];

                    if (count > 0)
                    {
                        MessageBox.Show("Email already exists. Please use a different one.");
                        return;
                    }
                    query = "insert into UserInfo (Name, Email, Password, Gender, Dob, Address, Mobile, Salary, UsertypeID) values ('" + name + "','" + email + "','" + password + "','" + gender + "','" + dob + "','" + address + "','" + mobile + "'," + salary + ",3)";
               
                }
                else
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
                         query = "update UserInfo set Name = '" + name + "', Email = '" + email + "', Password = '"
                                        + password + "', Gender = '" + gender + "', Dob = '" + dob + "', Address = '" + address + "', Mobile = " + mobile + " where ID = " + txtID.Text;

                        DataAccess.ExecuteNonResultQuery(query);
                        UserHelper.UserName = name;
                      //  MessageBox.Show("Saved");

                    }
                    else
                    {
                         query = "update UserInfo set Name = '" + name + "', Email = '" + email + "', Password = '"
                                        + password + "', Gender = '" + gender + "', Dob = '" + dob + "', Address = '" + address + "', Mobile = " + mobile + " where ID = " + txtID.Text;


                    }
                }

                DataAccess.ExecuteNonResultQuery(query);

                this.loadGridData();
                this.clearform();
                MessageBox.Show("Saved");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedRowIndex < 0)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            int id = int.Parse(dgvManagers.Rows[this.selectedRowIndex].Cells["ID"].Value.ToString());

            try
            {
                string query = "delete from UserInfo where ID = " + id;

                DataAccess.ExecuteNonResultQuery(query);

                this.loadGridData();
                this.clearform();
                MessageBox.Show("Deleted");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Hide();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }
    }
}
