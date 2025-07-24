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
    public partial class Colors: MetroForm
    {
        public Colors()
        {
            InitializeComponent();
        }
        private int selectedRowIndex = -1;

        private void loadGridData()
        {
            try
            {
                string query = "Select * from Color";

                DataTable dt = DataAccess.GetQueryData(query);

                dgvColors.DataSource = dt;
                dgvColors.Refresh();
                this.clearform();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearform()
        {
            txtColorID.Text = txtColorName.Text = "";

            dgvColors.ClearSelection();
            this.selectedRowIndex = -1;
        }

        private void Colors_Load(object sender, EventArgs e)
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
            int id = int.Parse(dgvColors.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            if (id <= 0)
            {
                MessageBox.Show("Invalid ID");
            }

            this.selectedRowIndex = e.RowIndex;

            try
            {
                string query = "select * from Color where ID = " + id;

                DataTable dt = DataAccess.GetQueryData(query);

                txtColorID.Text = dt.Rows[0]["ID"].ToString();
                txtColorName.Text = dt.Rows[0]["Name"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = txtColorName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Color name is required");
                return;
            }
            try
            {
                string query = "";

                if (this.selectedRowIndex < 0)
                {
                    query = "insert into Color values ('" + name + "')";
                }
                else
                {
                    query = "update Color set Name = '" + name + "' where ID =" + txtColorID.Text;
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
            int id = int.Parse(dgvColors.Rows[this.selectedRowIndex].Cells["ID"].Value.ToString());

            try
            {
                string query = "delete from Color where ID = " + id;

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
