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
using System.Collections;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Cars2 : MetroForm
    {
        public Cars2()
        {
            InitializeComponent();
            if (UserHelper.UserTypeID == 3)
            {
                this.orderBtn.Visible = false;
                this.ordersBtn.Visible = true;
                this.myOrderBtn.Visible = false;

            }
        }

        private int selectedRowIndex = -1;
        private void loadGridData()
        {
            try
            {
                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID and Status = 'Available'";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvCars.DataSource = dt;
                dgvCars.Refresh();
                dgvCars.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Cars2_Load(object sender, EventArgs e)
        {
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();

        }
        int carID = -1;
        string carStatus="";
        string price = "";
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                dgvCars.ClearSelection();
                return;
            }
             carID = int.Parse(dgvCars.Rows[e.RowIndex].Cells["ID"].Value.ToString());
             price = dgvCars.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            //  carStatus = dgvCars.Rows[e.RowIndex].Cells["Status"].Value.ToString();

            if (carID <= 0)
            {
                MessageBox.Show("Select a car first");
                return;
            }

            this.selectedRowIndex = e.RowIndex;
        }
        private void orderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (carStatus != "Available")
                //{
                //    MessageBox.Show("The car is not available");
                //    return;
                //}
                DialogResult result = MessageBox.Show("Confirm?","Order", buttons: MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    string query = "insert into [Order] values (" + UserHelper.UserID + ", " + carID + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'On Process',"+price+",0,"+price+")"+
                        "update car set Status = 'Pending' where ID = " + carID;

                    DataAccess.ExecuteNonResultQuery(query);

                    MessageBox.Show("Order Placed");

                    MyOrder orders = new MyOrder();
                    orders.Show();
                    this.Hide();

                }
                

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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void myOrderBtn_Click(object sender, EventArgs e)
        {
            MyOrder order = new MyOrder();
            order.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID and Status = 'Available' and Model like '%"+search+"%'";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvCars.DataSource = dt;
                dgvCars.Refresh();
                dgvCars.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }
    }
}
