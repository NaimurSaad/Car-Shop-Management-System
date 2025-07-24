namespace Project
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtCPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtMobile = new MetroFramework.Controls.MetroTextBox();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.registerBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.rbtnMale = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnFemale = new MetroFramework.Controls.MetroRadioButton();
            this.dobSelect = new MetroFramework.Controls.MetroDateTime();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.passhideshow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passhideshow)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(660, 444);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseSelectable = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(30, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(152, 76);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(326, 25);
            this.txtName.TabIndex = 15;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(30, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Email:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(30, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 25);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Password:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(30, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 25);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Confirm Pass..:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(30, 336);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Address:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(30, 380);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 25);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Mobile (+880):";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(152, 120);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(326, 25);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(152, 164);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(326, 25);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCPassword
            // 
            // 
            // 
            // 
            this.txtCPassword.CustomButton.AccessibleName = "Show";
            this.txtCPassword.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtCPassword.CustomButton.Image = null;
            this.txtCPassword.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtCPassword.CustomButton.Name = "";
            this.txtCPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPassword.CustomButton.TabIndex = 1;
            this.txtCPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPassword.CustomButton.UseSelectable = true;
            this.txtCPassword.CustomButton.Visible = false;
            this.txtCPassword.DisplayIcon = true;
            this.txtCPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCPassword.Lines = new string[0];
            this.txtCPassword.Location = new System.Drawing.Point(152, 208);
            this.txtCPassword.MaxLength = 32767;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPassword.SelectedText = "";
            this.txtCPassword.SelectionLength = 0;
            this.txtCPassword.SelectionStart = 0;
            this.txtCPassword.ShortcutsEnabled = true;
            this.txtCPassword.Size = new System.Drawing.Size(326, 25);
            this.txtCPassword.TabIndex = 23;
            this.txtCPassword.UseSelectable = true;
            this.txtCPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DisplayIcon = true;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(152, 336);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(326, 25);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.CustomButton.Image = null;
            this.txtMobile.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtMobile.CustomButton.Name = "";
            this.txtMobile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobile.CustomButton.TabIndex = 1;
            this.txtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobile.CustomButton.UseSelectable = true;
            this.txtMobile.CustomButton.Visible = false;
            this.txtMobile.DisplayIcon = true;
            this.txtMobile.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMobile.Lines = new string[0];
            this.txtMobile.Location = new System.Drawing.Point(152, 380);
            this.txtMobile.MaxLength = 32767;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.ShortcutsEnabled = true;
            this.txtMobile.Size = new System.Drawing.Size(326, 25);
            this.txtMobile.TabIndex = 25;
            this.txtMobile.UseSelectable = true;
            this.txtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(31, 444);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.registerBtn.Location = new System.Drawing.Point(368, 430);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(110, 37);
            this.registerBtn.TabIndex = 27;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseSelectable = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(30, 248);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 25);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Gender:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(30, 291);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 25);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Date of Birth:";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnMale.Location = new System.Drawing.Point(170, 253);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 31;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseSelectable = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnFemale.Location = new System.Drawing.Point(345, 253);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(73, 20);
            this.rbtnFemale.TabIndex = 32;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseSelectable = true;
            // 
            // dobSelect
            // 
            this.dobSelect.Location = new System.Drawing.Point(152, 291);
            this.dobSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.dobSelect.Name = "dobSelect";
            this.dobSelect.Size = new System.Drawing.Size(326, 30);
            this.dobSelect.TabIndex = 33;
            this.dobSelect.Value = new System.DateTime(2025, 6, 25, 17, 1, 30, 0);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project.Properties.Resources.signup;
            this.pictureBox3.Location = new System.Drawing.Point(524, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 241);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // passhideshow
            // 
            this.passhideshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passhideshow.Image = ((System.Drawing.Image)(resources.GetObject("passhideshow.Image")));
            this.passhideshow.Location = new System.Drawing.Point(484, 166);
            this.passhideshow.Name = "passhideshow";
            this.passhideshow.Size = new System.Drawing.Size(23, 23);
            this.passhideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passhideshow.TabIndex = 28;
            this.passhideshow.TabStop = false;
            this.passhideshow.Click += new System.EventHandler(this.passhideshow_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dobSelect);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.passhideshow);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.closeBtn);
            this.Name = "SignUp";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passhideshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtCPassword;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtMobile;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroButton registerBtn;
        private System.Windows.Forms.PictureBox passhideshow;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroRadioButton rbtnMale;
        private MetroFramework.Controls.MetroRadioButton rbtnFemale;
        private MetroFramework.Controls.MetroDateTime dobSelect;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}