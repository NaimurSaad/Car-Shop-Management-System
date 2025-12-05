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
    public partial class Reports: MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void loadGridData()
        {
            try
            {
                string query = "SELECT [Order].DateTime, [Order].ID AS OrderID, Car.ID AS CarID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, [Order].CustomerID, UserInfo.Name AS CustomerName, UserInfo.Email, UserInfo.Mobile, Car.Status AS Status, [Order].Price AS Price, [Order].Paid, [Order].Due FROM [Order], Car, Brand, Color, UserInfo WHERE [Order].CarID = Car.ID AND Car.BrandID = Brand.ID AND Car.ColorID = Color.ID AND [Order].CustomerID = UserInfo.ID AND (Car.Status = 'Sold' OR Car.Status = 'Delivered') ORDER BY [Order].DateTime DESC";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvReports.DataSource = dt;

                dgvReports.Refresh();
                dgvReports.ClearSelection();

                string query2 = "SELECT FORMAT(o.DateTime, 'MMM yyyy') AS [Month], COUNT(*) AS TotalOrders, SUM(o.Price) AS TotalPrice, SUM(o.Paid) AS TotalPaid, SUM(o.Due) AS TotalDue FROM [Order] o, Car c WHERE o.CarID = c.ID AND (c.Status = 'Sold' OR c.Status = 'Delivered') GROUP BY FORMAT(o.DateTime, 'MMM yyyy') ORDER BY MIN(o.DateTime) DESC";

                DataTable dt2 = DataAccess.GetQueryData(query2);

                dgvMReports.DataSource = dt2;


                dgvMReports.Refresh();
                dgvMReports.ClearSelection();

                string ccQuery = "Select Count (*) CT from Car";
                DataTable cc = DataAccess.GetQueryData(ccQuery);
                this.totalCarsLbl.Text =  cc.Rows[0]["CT"].ToString();
                
                string ccsQuery = "Select Count (*) CT from Car where Status = 'Sold' OR Status = 'Delivered'";
                DataTable ccs = DataAccess.GetQueryData(ccsQuery);
                this.totalSoldlbl.Text = ccs.Rows[0]["CT"].ToString();

                string sumQuery = "SELECT SUM(o.Price) AS TotalPrice, SUM(o.Paid) AS TotalPaid, SUM(o.Due) AS TotalDue FROM [Order] o, Car c WHERE o.CarID = c.ID AND (c.Status = 'Sold' OR c.Status = 'Delivered')";
                DataTable sm = DataAccess.GetQueryData(sumQuery);
                this.totalPaidLbl.Text = sm.Rows[0]["TotalPaid"].ToString();
                this.totalPriceLbl.Text = sm.Rows[0]["TotalPrice"].ToString();
                this.totalDueLbl.Text = sm.Rows[0]["TotalDue"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Reports_Load(object sender, EventArgs e)
        {

            if (UserHelper.UserTypeID != 1)
            {
                this.managerPanel.Visible = true;
            }
            this.userLabel.Text = UserHelper.UserName;
            this.muserLabel.Text = UserHelper.UserName;
            this.loadGridData();
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
                return;
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


        private void orders_Click(object sender, EventArgs e)
        {
            Orders od = new Orders();
            od.Show();
            this.Hide();
        }

        string mreport;
        private void dgvMReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            try
            {

                DateTime datetime = DateTime.ParseExact(dgvMReports.Rows[e.RowIndex].Cells["Month"].Value.ToString(), "MMM yyyy", null);

                string query = "SELECT [Order].DateTime, [Order].ID AS OrderID, Car.ID AS CarID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, [Order].CustomerID, UserInfo.Name AS CustomerName, UserInfo.Email, UserInfo.Mobile, Car.Status AS Status, [Order].Price AS Price, [Order].Paid, [Order].Due " +
                               "FROM [Order], Car, Brand, Color, UserInfo " +
                               "WHERE [Order].CarID = Car.ID AND Car.BrandID = Brand.ID AND Car.ColorID = Color.ID AND [Order].CustomerID = UserInfo.ID " +
                               "AND (Car.Status = 'Sold' OR Car.Status = 'Delivered') " +
                               "AND YEAR([Order].DateTime) = " + datetime.Year + " AND MONTH([Order].DateTime) = " + datetime.Month + " " +
                               "ORDER BY [Order].DateTime DESC";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvReports.DataSource = dt;

                dgvReports.Refresh();
                dgvReports.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}

