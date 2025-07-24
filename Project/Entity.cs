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
    public partial class Entity: MetroForm
    {
        public Entity()
        {
            InitializeComponent();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.TopLevel = false;
            customer.AutoScroll = true;
            customer.Dock = DockStyle.Fill;
            customer.FormBorderStyle = FormBorderStyle.None;
            this.metroPanel2.Controls.Clear();
            this.metroPanel2.Controls.Add(customer);
            customer.Show();

        }
    }
}
