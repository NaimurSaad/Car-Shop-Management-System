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
    public partial class Cars: MetroForm
    {
        public Cars()
        {
            InitializeComponent();
         //   this.tableLayoutPanel2.Visible = false;
        }
        
        private int selectedRowIndex = -1;
        private void loadGridData()
        {
            try
            {
                //if (this.metroCheckBox1.Checked == true)
                //{
                //    string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID";

                //    DataTable dt = DataAccess.GetQueryData(query);

                //    dgvCars.DataSource = dt;
                //    dgvCars.Refresh();
                //    this.clearform();
                //}
                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvCars.DataSource = dt;
                dgvCars.Refresh();
                this.clearform();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearform()
        {
            txtCarID.Text = txtEnginecc.Text = txtModel.Text = txtRegYr.Text = txtPrice.Text = "";
            rbtnAuto.Checked = rbtnManual.Checked = false;
            cbBrand.SelectedItem = cbColor.SelectedItem = cbStatus.SelectedItem = null;
            dgvCars.ClearSelection();
            this.selectedRowIndex = -1;
        }
        private void loadBrands()
        {

            string query = "select * from Brand";

            DataTable dt = DataAccess.GetQueryData(query);

            cbBrand.DataSource = dt;
            cbBrand.DisplayMember = "Name";
            cbBrand.ValueMember = "ID";
            cbBrand.SelectedValue = -1;

        }
        private void loadcolors()
        {

            string query = "select * from Color";

            DataTable dt = DataAccess.GetQueryData(query);

            cbColor.DataSource = dt;
            cbColor.DisplayMember = "Name";
            cbColor.ValueMember = "ID";
            cbColor.SelectedValue = -1;

        }

        private void Cars_Load(object sender, EventArgs e)
        {
            this.userLabel.Text = UserHelper.UserName;
            this.loadGridData();
            this.loadBrands();
            this.loadcolors();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();
            this.loadBrands();
            this.loadcolors();
            this.clearform();
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                this.clearform();
                return;
            }
            int id = int.Parse(dgvCars.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            if (id <= 0)
            {
                MessageBox.Show("Invalid ID");
            }

             this.selectedRowIndex = e.RowIndex;

            try
            {
                string query = "select * from Car where ID = "+id;

                DataTable dt = DataAccess.GetQueryData(query);

                txtCarID.Text = dt.Rows[0]["ID"].ToString();
                txtModel.Text = dt.Rows[0]["Model"].ToString();
                txtEnginecc.Text = dt.Rows[0]["EngineCC"].ToString();
                txtRegYr.Text = dt.Rows[0]["RegYear"].ToString();
                cbBrand.SelectedValue = dt.Rows[0]["BrandID"].ToString();
                cbColor.SelectedValue = dt.Rows[0]["ColorID"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
                cbStatus.Text = dt.Rows[0]["Status"].ToString();

                if (dt.Rows[0]["Gear"].ToString() == "Automatic")
                {
                    rbtnAuto.Checked = true;
                }
                else
                {
                    rbtnManual.Checked = true;
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

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.clearform();
           // this.tableLayoutPanel2.Visible = true;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string model = this.txtModel.Text;
            string regYr = this.txtRegYr.Text;
            string engineCC = this.txtEnginecc.Text;
            string price = this.txtPrice.Text;
            var gear = this.rbtnAuto.Checked ? this.rbtnAuto.Text
                : this.rbtnManual.Checked ? this.rbtnManual.Text : "";

            string status = this.cbStatus.SelectedItem != null ? (this.cbStatus.SelectedItem.ToString()) : string.Empty;

            int brandId = this.cbBrand.SelectedValue != null ? int.Parse(this.cbBrand.SelectedValue.ToString()) : -1;
            int colorId = this.cbColor.SelectedValue != null ? int.Parse(this.cbColor.SelectedValue.ToString()) : -1;

            if (string.IsNullOrWhiteSpace(model)
                || string.IsNullOrWhiteSpace(regYr)
                || string.IsNullOrWhiteSpace(engineCC)
                || string.IsNullOrWhiteSpace(price)
                || string.IsNullOrWhiteSpace(gear)
                || string.IsNullOrWhiteSpace(status)
                || brandId <= 0
                || colorId <= 0)
            {
                MessageBox.Show("All information is required.");
                return;
            }
            try
            {

                string query = "";

                if (this.selectedRowIndex < 0)
                {
                    query = "insert into car values (" + brandId + ",'" + model + "'," + regYr + ",'" 
                        + engineCC + "','" + gear + "'," + colorId + ",'" + price + "','" + status + "')";
                }
                else
                {
                    query = "update car set BrandID = " + brandId + ", Model = '" + model + "', RegYear = '"
                        + regYr + "', EngineCC = '" + engineCC + "', Gear = '" + gear + "', ColorID = "
                        + colorId + ", Price = '" + price + "', Status = '" + status + "' where ID =" + txtCarID.Text;
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

            int id = int.Parse(dgvCars.Rows[this.selectedRowIndex].Cells["ID"].Value.ToString());

            try
            {
                string query = "delete from car where ID = "+id;

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

        private void moreBrandBtn_Click(object sender, EventArgs e)
        {
            Brands brand = new Brands();
            brand.Show();
        }

        private void moreColorBtn_Click(object sender, EventArgs e)
        {
            Colors color = new Colors();
            color.Show();
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

        private void managersBtn_Click(object sender, EventArgs e)
        {
            Managers mg = new Managers();
            mg.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            try
            {
                string query = " SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear, Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car,Brand,Color where Car.BrandID = Brand.ID  and Car.ColorID = Color.ID and Model like '%" + search + "%'";

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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();

                 rp.Show();
                 this.Hide();
        }
    }
}
