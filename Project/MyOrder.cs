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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public partial class MyOrder: MetroForm
    {
        public MyOrder()
        {
            InitializeComponent();
        }
        private void loadGridData()
        {
            try
            {
                string query = "select ID as OrderID, CarID,DateTime, Status, Price, Paid, Due from [Order] where CustomerID= "+UserHelper.UserID+ " Order by DateTime Desc";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvOrders.DataSource = dt;
                dgvOrders.Refresh();
                dgvOrders.ClearSelection();
                this.clearLabels();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearLabels()
        {
            brandLabel.Text = "";
            modelLabel.Text = "";
            engineLabel.Text = "";
            regyrLabel.Text = "";
            gearLabel.Text = "";
            colorLabel.Text = "";
            priceLabel.Text = "";

        }


        private void MyOrder_Load(object sender, EventArgs e)
        {
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();

        }
        int selectedRowIndex = -1;
        int carID = -1;
        int orderID = -1;
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;

            if (e.RowIndex < 0)
            {
                dgvOrders.ClearSelection();
                return;
            }

            carID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["CarID"].Value.ToString());
            orderID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());

            try
            {

                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID and Car.ID =" + carID;

                DataTable dt = DataAccess.GetQueryData(query);

                brandLabel.Text = dt.Rows[0]["Brand"].ToString();
                modelLabel.Text = dt.Rows[0]["Model"].ToString();
                engineLabel.Text = dt.Rows[0]["EngineCC"].ToString();
                regyrLabel.Text = dt.Rows[0]["RegYear"].ToString();
                gearLabel.Text = dt.Rows[0]["Gear"].ToString();
                colorLabel.Text = dt.Rows[0]["Color"].ToString();
                priceLabel.Text = dt.Rows[0]["Price"].ToString();


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

        private void carBtn_Click(object sender, EventArgs e)
        {
            Cars2 car = new Cars2();
            car.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.selectedRowIndex < 0)
                {
                    MessageBox.Show("Select an order first");
                    return;
                }
                string checkQuery = "select * from [Order] where ID =" + orderID;

                DataTable dt = DataAccess.GetQueryData(checkQuery);
                if (dt.Rows[0]["Status"].ToString() != "On Process")
                {
                    MessageBox.Show("The order is not in 'On Process' state");
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure?", "Cancel Order", buttons: MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                    string query = "update [Order] set Status = 'Cancelled' where ID =" + orderID +
                    "update Car set Status = 'Available' where ID =" + carID;
                    DataAccess.ExecuteNonResultQuery(query);

                    MessageBox.Show("Cancelled");

                    this.loadGridData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
