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
    public partial class Loading: Form
    {
        public Loading()
        {
           // this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            //BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.loadingBar.Value += 5;
           // this.pictureBox1.Left += 30;
            if (loadingBar.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }



        // Show the progress bar while loading

    }
}
