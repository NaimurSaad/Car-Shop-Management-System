namespace Project
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dobSelect = new MetroFramework.Controls.MetroDateTime();
            this.rbtnFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnMale = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.passhideshow = new System.Windows.Forms.PictureBox();
            this.txtMobile = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtCPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passhideshow)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.saveBtn.Location = new System.Drawing.Point(409, 483);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(98, 30);
            this.saveBtn.TabIndex = 43;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.backBtn.Location = new System.Drawing.Point(18, 483);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(98, 30);
            this.backBtn.TabIndex = 44;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(190, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // dobSelect
            // 
            this.dobSelect.Location = new System.Drawing.Point(152, 358);
            this.dobSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.dobSelect.Name = "dobSelect";
            this.dobSelect.Size = new System.Drawing.Size(326, 30);
            this.dobSelect.TabIndex = 62;
            this.dobSelect.Value = new System.DateTime(2025, 6, 25, 17, 1, 30, 0);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnFemale.Location = new System.Drawing.Point(345, 323);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(73, 20);
            this.rbtnFemale.TabIndex = 61;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseSelectable = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnMale.Location = new System.Drawing.Point(171, 322);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 60;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(30, 358);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 25);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "Date of Birth:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(30, 315);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 25);
            this.metroLabel7.TabIndex = 58;
            this.metroLabel7.Text = "Gender:";
            // 
            // passhideshow
            // 
            this.passhideshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passhideshow.Image = ((System.Drawing.Image)(resources.GetObject("passhideshow.Image")));
            this.passhideshow.Location = new System.Drawing.Point(484, 233);
            this.passhideshow.Name = "passhideshow";
            this.passhideshow.Size = new System.Drawing.Size(23, 23);
            this.passhideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passhideshow.TabIndex = 57;
            this.passhideshow.TabStop = false;
            this.passhideshow.Click += new System.EventHandler(this.passhideshow_Click);
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
            this.txtMobile.Location = new System.Drawing.Point(152, 444);
            this.txtMobile.MaxLength = 32767;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.ShortcutsEnabled = true;
            this.txtMobile.Size = new System.Drawing.Size(326, 25);
            this.txtMobile.TabIndex = 56;
            this.txtMobile.UseSelectable = true;
            this.txtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtAddress.Location = new System.Drawing.Point(152, 401);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(326, 25);
            this.txtAddress.TabIndex = 55;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtCPassword.Location = new System.Drawing.Point(152, 275);
            this.txtCPassword.MaxLength = 32767;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPassword.SelectedText = "";
            this.txtCPassword.SelectionLength = 0;
            this.txtCPassword.SelectionStart = 0;
            this.txtCPassword.ShortcutsEnabled = true;
            this.txtCPassword.Size = new System.Drawing.Size(326, 25);
            this.txtCPassword.TabIndex = 54;
            this.txtCPassword.UseSelectable = true;
            this.txtCPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPassword.Location = new System.Drawing.Point(152, 231);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(326, 25);
            this.txtPassword.TabIndex = 53;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtEmail.Location = new System.Drawing.Point(152, 187);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(326, 25);
            this.txtEmail.TabIndex = 52;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(30, 444);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 25);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "Mobile (+880):";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(30, 401);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Address:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(30, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 25);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "Confirm Pass..:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(30, 229);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 25);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Password:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(30, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Email:";
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
            this.txtName.Location = new System.Drawing.Point(152, 143);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(326, 25);
            this.txtName.TabIndex = 46;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(30, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Name:";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 536);
            this.Controls.Add(this.dobSelect);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.passhideshow);
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
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditProfile";
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passhideshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroDateTime dobSelect;
        private MetroFramework.Controls.MetroRadioButton rbtnFemale;
        private MetroFramework.Controls.MetroRadioButton rbtnMale;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox passhideshow;
        private MetroFramework.Controls.MetroTextBox txtMobile;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtCPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}