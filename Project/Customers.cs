using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Customers: MetroForm
    {
        public Customers()
        {
            InitializeComponent();
        }
        private int selectedRowIndex = -1;
        private void loadGridData()
        {
            try
            {
                string query = "Select ID, Name, Email, Password, Gender, DOB, Address, Mobile from UserInfo where UserTypeID = 2";
                DataTable dt = DataAccess.GetQueryData(query);

                dgvCustomers.DataSource = dt;
                dgvCustomers.Refresh();
                dgvCustomers.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                dgvCustomers.ClearSelection();
                return;
            }

            int id = int.Parse(dgvCustomers.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            if (id <= 0)
            {
                MessageBox.Show("Invalid ID");
            }

            this.selectedRowIndex = e.RowIndex;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {


        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedRowIndex < 0)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            int id = int.Parse(dgvCustomers.Rows[this.selectedRowIndex].Cells["ID"].Value.ToString());

            try
            {
                string checkquery = "Select count(*) CT from [Order] where CustomerID =" + id;
                DataTable dt = DataAccess.GetQueryData(checkquery);

                int count = (int)dt.Rows[0]["CT"];

                if (count > 0)
                {
                    MessageBox.Show("The customer has orders. Can't Delete ");
                    return;
                }

                string query = "delete from Customer where ID = " + id +"delete from USerInfo where ID ="+id;

                DataAccess.ExecuteNonResultQuery(query);

                this.loadGridData();
                MessageBox.Show("Deleted");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.Show();
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

        private void managersBtn_Click(object sender, EventArgs e)
        {
            Managers mg = new Managers();
            mg.Show();
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
