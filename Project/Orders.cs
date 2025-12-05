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
    public partial class Orders : MetroForm
    {
        public Orders()
        {
            InitializeComponent();

        }
        private void loadGridData()
        {
            try
            {
                string query = "select ID as OrderID, CustomerID, CarID,DateTime, Status, Price, Paid, Due from [Order] Order by DateTime Desc ";

                DataTable dt = DataAccess.GetQueryData(query);



                dgvOrders.DataSource = dt;
                dgvOrders.Refresh();
                this.clearLabels();
                dgvOrders.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Orders_Load(object sender, EventArgs e)
        {

            if (UserHelper.UserTypeID != 1)
            {
                this.managerPanel.Visible = true;
            }
            this.userLabel.Text = UserHelper.UserName;
            this.muserLabel.Text = UserHelper.UserName;

            this.rbtnCarDetails.Checked = true;
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();
        }
        private void clearLabels()
        {
            brandLabel.Text = modelLabel.Text = engineLabel.Text = regyrLabel.Text = gearLabel.Text = "";
            colorLabel.Text = priceLabel.Text = nameLabel.Text = emailLabel.Text = mobileLabel.Text = addressLabel.Text = genderLabel.Text = dobLabel.Text = "";
            dgvOrders.ClearSelection();
            OrderHelper.orderID = -1;
            status = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();

        }

        int selectedRowIndex = -1;
        int ID = -1;
        string status = "";
        int carID = -1;
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRowIndex = e.RowIndex;

            if (e.RowIndex < 0)
            {
                this.clearLabels();
                return;
            }

            carID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["CarID"].Value.ToString());
            ID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            int customerID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString());
            status = (dgvOrders.Rows[e.RowIndex].Cells["Status"].Value.ToString());

            OrderHelper.orderID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            OrderHelper.paid = int.Parse(dgvOrders.Rows[e.RowIndex].Cells["Paid"].Value.ToString());


            try
            {
                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car,Brand,Color where Car.BrandID = Brand.ID and Car.ColorID = Color.ID and Car.ID = " + carID;

                DataTable dt = DataAccess.GetQueryData(query);

                brandLabel.Text = dt.Rows[0]["Brand"].ToString();
                modelLabel.Text = dt.Rows[0]["Model"].ToString();
                engineLabel.Text = dt.Rows[0]["EngineCC"].ToString();
                regyrLabel.Text = dt.Rows[0]["RegYear"].ToString();
                gearLabel.Text = dt.Rows[0]["Gear"].ToString();
                colorLabel.Text = dt.Rows[0]["Color"].ToString();
                priceLabel.Text = dt.Rows[0]["Price"].ToString();

                string query2 = "select * from userinfo where ID = " + customerID;
                DataTable dt2 = DataAccess.GetQueryData(query2);

                nameLabel.Text = dt2.Rows[0]["Name"].ToString();
                emailLabel.Text = dt2.Rows[0]["Email"].ToString();
                genderLabel.Text = dt2.Rows[0]["Gender"].ToString();
                dobLabel.Text = Convert.ToDateTime(dt2.Rows[0]["DOB"]).ToString("dd-MM-yyyy");
                addressLabel.Text = dt2.Rows[0]["Address"].ToString();
                mobileLabel.Text = "+880 " + dt2.Rows[0]["Mobile"].ToString();
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
            Cars car = new Cars();
            car.Show();
            this.Hide();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Hide();
        }



        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtnCarDetails_CheckedChanged(object sender, EventArgs e)
        {
            this.panel4.Visible = true;
            this.panel5.Visible = false;

        }

        private void rbtnCustomerDetails_CheckedChanged(object sender, EventArgs e)
        {
            this.panel5.Visible = true;


        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.selectedRowIndex < 0)
                {
                    MessageBox.Show("Select an order first");
                    return;
                }
                string checkQuery = "select * from [Order] where ID ="+OrderHelper.orderID;
                DataTable dt = DataAccess.GetQueryData(checkQuery);
                if (dt.Rows[0]["Status"].ToString() != "On Process")
                {
                    MessageBox.Show("The order is not in 'On Process' state");
                    return;
                }
                string query = "update [Order] set Status = 'Delivered' where ID ="+OrderHelper.orderID+
                    "update Car set Status = 'Delivered' where ID ="+carID;
                DataAccess.ExecuteNonResultQuery(query);

                MessageBox.Show("Delivered");

                this.loadGridData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if (status == "Cancelled")
            {
                MessageBox.Show("The order was cancelled");
                return;
            }
            Payment pm = new Payment();
            pm.Show();
            this.Hide();
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
                string checkQuery = "select * from [Order] where ID =" + OrderHelper.orderID;
 
                DataTable dt = DataAccess.GetQueryData(checkQuery);
                if (dt.Rows[0]["Status"].ToString() != "On Process")
                {
                    MessageBox.Show("The order is not in 'On Process' state");
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure?", "Cancel Order", buttons: MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    string query = "update [Order] set Status = 'Cancelled' where ID =" + OrderHelper.orderID +
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

        private void mcars_Click(object sender, EventArgs e)
        {
            mCars car = new mCars();
            car.Show();
            this.Hide();
        }

        private void mlogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
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
