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
    public partial class Payment: MetroForm
    {
        public Payment()
        {
            InitializeComponent();
        }

        int carID = -1;
        private void loadForm()
        {
            try
            {
                if (OrderHelper.orderID == -1)
                {
                    txtOrderID.ReadOnly = false;
                }
                else
                {


                    string query = " Select * from [Order] where ID=" + OrderHelper.orderID;

                    DataTable dt = DataAccess.GetQueryData(query);

                    txtOrderID.Text = OrderHelper.orderID.ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    due = int.Parse(txtDue.Text = dt.Rows[0]["Due"].ToString());
                    carID = int.Parse(dt.Rows[0]["CarID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadGridData()
        {
            try
            {

                string query = " Select * from Payment Order by Date Desc";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvPayment.DataSource = dt;
                dgvPayment.Refresh();
                dgvPayment.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string paymentMethod = this.cbMethod.SelectedItem != null ? (this.cbMethod.SelectedItem.ToString()) : string.Empty;
            string date = datepicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string amount2 = txtAmount.Text;
            string orderID = txtOrderID.Text;
            
            if(string.IsNullOrEmpty(orderID)
              ||string.IsNullOrEmpty(amount2)
              || string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("All the informations required");
                return;
            }
            int amount = int.Parse(txtAmount.Text);
            try
            {
                if (due < amount)
                {
                    MessageBox.Show("Due is less than the amount");
                    return;
                }
                due -= amount;
                OrderHelper.paid += amount;
                string query = "Insert into Payment values (" + OrderHelper.orderID + ","+UserHelper.UserID+",'" + paymentMethod +"','"+date+"',"+amount+");" +
                    "Update [Order] set Paid=" + OrderHelper.paid + ", Due=" + due+"where ID="+ OrderHelper.orderID+
                    "update Car set Status = 'Sold' where ID =" + carID;

                DataAccess.ExecuteNonResultQuery(query);

                this.loadGridData();
                this.loadForm();
                MessageBox.Show("Saved");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        int due;

        private void Payment_Load(object sender, EventArgs e)
        {
            this.muserLabel.Text = UserHelper.UserName;
            this.userLabel.Text = UserHelper.UserName;

            if (UserHelper.UserTypeID == 1)
            {
                this.adminPanel.Visible = true;
                this.managerPanel.Visible = false;
            }
            this.loadGridData();
            this.loadForm();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;

            txtAmount.Text = "";
            int tempOrderID;

            if (!int.TryParse(txtOrderID.Text, out tempOrderID))
            {
                this.txtPrice.Text = this.txtDue.Text = this.txtAmount.Text = "";
                return;
            }

            OrderHelper.orderID = tempOrderID;
            try
            {
                if (OrderHelper.orderID < 0)
                {
                    return;
                }
                string checkQuery = " Select count(*) as CT from [Order] where ID=" + OrderHelper.orderID;
                DataTable dtc = DataAccess.GetQueryData(checkQuery);
                int count = (int)dtc.Rows[0]["CT"];
                if (count < 1)
                {
                    //MessageBox.Show("Order does not exist");
                    this.errorLabel.Visible = true;
                    this.txtPrice.Text = this.txtDue.Text = this.txtAmount.Text = "";
                    return;
                }
                string query = " Select * from [Order] where ID=" + OrderHelper.orderID;

                DataTable dt = DataAccess.GetQueryData(query);

                txtOrderID.Text = OrderHelper.orderID.ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                due = int.Parse(txtDue.Text = dt.Rows[0]["Due"].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.txtOrderID.ReadOnly = false;
            this.txtOrderID.Text = this.txtPrice.Text = this.txtDue.Text = this.txtAmount.Text = "";
            this.cbMethod.SelectedValue = -1;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Are you sure?", "Clear History", buttons: MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    string query = "Delete from Payment";

                    DataAccess.ExecuteNonResultQuery(query);

                    MessageBox.Show("Cleared");
                    this.loadGridData();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void mcars_Click(object sender, EventArgs e)
        {
            mCars car = new mCars();
            car.Show();
            this.Hide();
        }

        private void morders_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
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
            Customers cs = new Customers();
            cs.Show();
            this.Hide();
        }

        private void orderBtn_Click_1(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            this.Hide();
        }

        private void managersBtn_Click(object sender, EventArgs e)
        {
            Managers mg = new Managers();
            mg.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void mlogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dgvPayment.ClearSelection();
        }
    }
}
