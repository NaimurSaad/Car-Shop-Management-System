using MetroFramework.Forms;
using System;
using System.Collections;
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
    public partial class Brands: MetroForm
    {
        public Brands()
        {
            InitializeComponent();
        }

        private int selectedRowIndex = -1;

        private void loadGridData()
        {
            try
            {
                string query = "Select * from Brand";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvBrands.DataSource = dt;
                dgvBrands.Refresh();
                this.clearform();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearform()
        {
            txtBrandID.Text = txtBrandName.Text = "";

            dgvBrands.ClearSelection();
            this.selectedRowIndex = -1;
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            this.loadGridData();
            this.clearform();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.loadGridData();
            this.clearform();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.clearform();

        }
        private void dgvBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                this.clearform();
                return;
            }
            int id = int.Parse(dgvBrands.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            if (id <= 0)
            {
                MessageBox.Show("Invalid ID");
            }

            this.selectedRowIndex = e.RowIndex;

            try
            {
                string query = "select * from Brand where ID = " + id;

                DataTable dt = DataAccess.GetQueryData(query);

                txtBrandID.Text = dt.Rows[0]["ID"].ToString();
                txtBrandName.Text = dt.Rows[0]["Name"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = txtBrandName.Text;

            if(string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Brand name is required");
                return;
            }
            try
            {
                string query = "";

                if (this.selectedRowIndex < 0)
                {
                    query = "insert into Brand values ('" + name + "')";
                }
                else
                {
                    query = "update Brand set Name = '" + name + "' where ID =" + txtBrandID.Text;
                }


                DataAccess.ExecuteNonResultQuery(query);
                this.loadGridData();
                this.clearform();
                MessageBox.Show("Saved");

            }
            catch(Exception ex)
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
            int id = int.Parse(dgvBrands.Rows[this.selectedRowIndex].Cells["ID"].Value.ToString());

            try
            {
                string query = "delete from Brand where ID = " + id;

                DataAccess.ExecuteNonResultQuery(query);
                this.loadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}
