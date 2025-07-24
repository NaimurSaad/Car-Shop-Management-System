namespace Project
{
    partial class Entity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.adminBtn = new MetroFramework.Controls.MetroButton();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.orderBtn = new MetroFramework.Controls.MetroButton();
            this.CustomersBtn = new MetroFramework.Controls.MetroButton();
            this.carBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.adminBtn);
            this.metroPanel1.Controls.Add(this.userLabel);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.orderBtn);
            this.metroPanel1.Controls.Add(this.CustomersBtn);
            this.metroPanel1.Controls.Add(this.carBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(109, 537);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // adminBtn
            // 
            this.adminBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.adminBtn.Location = new System.Drawing.Point(5, 395);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(99, 38);
            this.adminBtn.TabIndex = 20;
            this.adminBtn.Text = "Admins";
            this.adminBtn.UseSelectable = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userLabel.Location = new System.Drawing.Point(33, 77);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(46, 25);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderBtn
            // 
            this.orderBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.orderBtn.Location = new System.Drawing.Point(5, 314);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(99, 38);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "Orders";
            this.orderBtn.UseSelectable = true;
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CustomersBtn.Location = new System.Drawing.Point(5, 229);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(99, 38);
            this.CustomersBtn.TabIndex = 3;
            this.CustomersBtn.Text = "Customers";
            this.CustomersBtn.UseSelectable = true;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // carBtn
            // 
            this.carBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.carBtn.Location = new System.Drawing.Point(5, 144);
            this.carBtn.Name = "carBtn";
            this.carBtn.Size = new System.Drawing.Size(99, 38);
            this.carBtn.TabIndex = 2;
            this.carBtn.Text = "Cars";
            this.carBtn.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(135, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1107, 534);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Entity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 617);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Entity";
            this.Text = "Cars";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton orderBtn;
        private MetroFramework.Controls.MetroButton CustomersBtn;
        private MetroFramework.Controls.MetroButton carBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel userLabel;
        private MetroFramework.Controls.MetroButton adminBtn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}