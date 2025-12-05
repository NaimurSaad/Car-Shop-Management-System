namespace Project
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPayment = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBtn = new MetroFramework.Controls.MetroButton();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.txtCarID = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtDue = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderID = new MetroFramework.Controls.MetroTextBox();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.managerPanel = new MetroFramework.Controls.MetroPanel();
            this.muserLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mlogout = new MetroFramework.Controls.MetroButton();
            this.mcars = new MetroFramework.Controls.MetroButton();
            this.morders = new MetroFramework.Controls.MetroButton();
            this.ordersBtn = new MetroFramework.Controls.MetroButton();
            this.adminPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.managersBtn = new MetroFramework.Controls.MetroButton();
            this.LogOutBtn = new MetroFramework.Controls.MetroButton();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.orderBtn = new MetroFramework.Controls.MetroButton();
            this.CustomersBtn = new MetroFramework.Controls.MetroButton();
            this.carBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.panel1.SuspendLayout();
            this.managerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(132, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.34952F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvPayment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 449);
            this.panel3.TabIndex = 2;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AllowUserToResizeRows = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.EnableHeadersVisualStyles = false;
            this.dgvPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayment.Location = new System.Drawing.Point(0, 0);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(653, 447);
            this.dgvPayment.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 54);
            this.panel1.TabIndex = 0;
            // 
            // newBtn
            // 
            this.newBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.newBtn.Location = new System.Drawing.Point(35, 8);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(109, 38);
            this.newBtn.TabIndex = 3;
            this.newBtn.Text = "New";
            this.newBtn.UseSelectable = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearBtn.Location = new System.Drawing.Point(501, 8);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(132, 38);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear History";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.refreshBtn.Location = new System.Drawing.Point(268, 7);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 38);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // txtCarID
            // 
            // 
            // 
            // 
            this.txtCarID.CustomButton.Image = null;
            this.txtCarID.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtCarID.CustomButton.Name = "";
            this.txtCarID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCarID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCarID.CustomButton.TabIndex = 1;
            this.txtCarID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCarID.CustomButton.UseSelectable = true;
            this.txtCarID.CustomButton.Visible = false;
            this.txtCarID.Lines = new string[0];
            this.txtCarID.Location = new System.Drawing.Point(848, 149);
            this.txtCarID.MaxLength = 32767;
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.PasswordChar = '\0';
            this.txtCarID.PromptText = "Auto Generated";
            this.txtCarID.ReadOnly = true;
            this.txtCarID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCarID.SelectedText = "";
            this.txtCarID.SelectionLength = 0;
            this.txtCarID.SelectionStart = 0;
            this.txtCarID.ShortcutsEnabled = true;
            this.txtCarID.Size = new System.Drawing.Size(290, 23);
            this.txtCarID.TabIndex = 5;
            this.txtCarID.UseSelectable = true;
            this.txtCarID.WaterMark = "Auto Generated";
            this.txtCarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(843, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "Payment ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(844, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(844, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(849, 332);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(290, 22);
            this.datepicker.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(844, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(844, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(999, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Due";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(849, 398);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ReadOnly = true;
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(134, 23);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDue
            // 
            // 
            // 
            // 
            this.txtDue.CustomButton.Image = null;
            this.txtDue.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtDue.CustomButton.Name = "";
            this.txtDue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDue.CustomButton.TabIndex = 1;
            this.txtDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDue.CustomButton.UseSelectable = true;
            this.txtDue.CustomButton.Visible = false;
            this.txtDue.Lines = new string[0];
            this.txtDue.Location = new System.Drawing.Point(1004, 398);
            this.txtDue.MaxLength = 32767;
            this.txtDue.Name = "txtDue";
            this.txtDue.PasswordChar = '\0';
            this.txtDue.ReadOnly = true;
            this.txtDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDue.SelectedText = "";
            this.txtDue.SelectionLength = 0;
            this.txtDue.SelectionStart = 0;
            this.txtDue.ShortcutsEnabled = true;
            this.txtDue.Size = new System.Drawing.Size(134, 23);
            this.txtDue.TabIndex = 21;
            this.txtDue.UseSelectable = true;
            this.txtDue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(849, 456);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(290, 23);
            this.txtAmount.TabIndex = 22;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Card"});
            this.cbMethod.Location = new System.Drawing.Point(849, 273);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(290, 24);
            this.cbMethod.TabIndex = 23;
            // 
            // saveBtn
            // 
            this.saveBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.saveBtn.Location = new System.Drawing.Point(947, 504);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(843, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "Order ID";
            // 
            // txtOrderID
            // 
            // 
            // 
            // 
            this.txtOrderID.CustomButton.Image = null;
            this.txtOrderID.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtOrderID.CustomButton.Name = "";
            this.txtOrderID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderID.CustomButton.TabIndex = 1;
            this.txtOrderID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderID.CustomButton.UseSelectable = true;
            this.txtOrderID.CustomButton.Visible = false;
            this.txtOrderID.Lines = new string[0];
            this.txtOrderID.Location = new System.Drawing.Point(848, 208);
            this.txtOrderID.MaxLength = 32767;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.SelectionLength = 0;
            this.txtOrderID.SelectionStart = 0;
            this.txtOrderID.ShortcutsEnabled = true;
            this.txtOrderID.Size = new System.Drawing.Size(290, 23);
            this.txtOrderID.TabIndex = 24;
            this.txtOrderID.UseSelectable = true;
            this.txtOrderID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1115, 565);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseSelectable = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(944, 186);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(175, 16);
            this.errorLabel.TabIndex = 26;
            this.errorLabel.Text = "*The order ID does not exist!";
            this.errorLabel.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(826, 562);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // managerPanel
            // 
            this.managerPanel.Controls.Add(this.muserLabel);
            this.managerPanel.Controls.Add(this.pictureBox4);
            this.managerPanel.Controls.Add(this.mlogout);
            this.managerPanel.Controls.Add(this.mcars);
            this.managerPanel.Controls.Add(this.morders);
            this.managerPanel.Controls.Add(this.ordersBtn);
            this.managerPanel.HorizontalScrollbarBarColor = true;
            this.managerPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.managerPanel.HorizontalScrollbarSize = 10;
            this.managerPanel.Location = new System.Drawing.Point(20, 60);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(109, 528);
            this.managerPanel.TabIndex = 21;
            this.managerPanel.VerticalScrollbarBarColor = true;
            this.managerPanel.VerticalScrollbarHighlightOnWheel = false;
            this.managerPanel.VerticalScrollbarSize = 10;
            // 
            // muserLabel
            // 
            this.muserLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.muserLabel.Location = new System.Drawing.Point(5, 80);
            this.muserLabel.Name = "muserLabel";
            this.muserLabel.Size = new System.Drawing.Size(99, 37);
            this.muserLabel.TabIndex = 19;
            this.muserLabel.Text = "User";
            this.muserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Project.Properties.Resources.image_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(20, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // mlogout
            // 
            this.mlogout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mlogout.Location = new System.Drawing.Point(5, 314);
            this.mlogout.Name = "mlogout";
            this.mlogout.Size = new System.Drawing.Size(99, 38);
            this.mlogout.TabIndex = 4;
            this.mlogout.Text = "Log Out";
            this.mlogout.UseSelectable = true;
            this.mlogout.Click += new System.EventHandler(this.mlogout_Click);
            // 
            // mcars
            // 
            this.mcars.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mcars.Location = new System.Drawing.Point(5, 144);
            this.mcars.Name = "mcars";
            this.mcars.Size = new System.Drawing.Size(99, 38);
            this.mcars.TabIndex = 2;
            this.mcars.Text = "Cars";
            this.mcars.UseSelectable = true;
            this.mcars.Click += new System.EventHandler(this.mcars_Click);
            // 
            // morders
            // 
            this.morders.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.morders.Location = new System.Drawing.Point(5, 229);
            this.morders.Name = "morders";
            this.morders.Size = new System.Drawing.Size(99, 38);
            this.morders.TabIndex = 3;
            this.morders.Text = "Orders";
            this.morders.UseSelectable = true;
            this.morders.Click += new System.EventHandler(this.morders_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ordersBtn.Location = new System.Drawing.Point(5, 229);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(99, 38);
            this.ordersBtn.TabIndex = 20;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.UseSelectable = true;
            this.ordersBtn.Visible = false;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.metroPanel1);
            this.adminPanel.Controls.Add(this.managersBtn);
            this.adminPanel.Controls.Add(this.LogOutBtn);
            this.adminPanel.Controls.Add(this.userLabel);
            this.adminPanel.Controls.Add(this.pictureBox3);
            this.adminPanel.Controls.Add(this.orderBtn);
            this.adminPanel.Controls.Add(this.CustomersBtn);
            this.adminPanel.Controls.Add(this.carBtn);
            this.adminPanel.HorizontalScrollbarBarColor = true;
            this.adminPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.adminPanel.HorizontalScrollbarSize = 10;
            this.adminPanel.Location = new System.Drawing.Point(20, 60);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(109, 528);
            this.adminPanel.TabIndex = 29;
            this.adminPanel.VerticalScrollbarBarColor = true;
            this.adminPanel.VerticalScrollbarHighlightOnWheel = false;
            this.adminPanel.VerticalScrollbarSize = 10;
            this.adminPanel.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(109, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(109, 528);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(5, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 37);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "User";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Project.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(20, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(5, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 38);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Log Out";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(5, 144);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(99, 38);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Cars";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Location = new System.Drawing.Point(5, 229);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(99, 38);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Orders";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.Location = new System.Drawing.Point(5, 229);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(99, 38);
            this.metroButton4.TabIndex = 20;
            this.metroButton4.Text = "Orders";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Visible = false;
            // 
            // managersBtn
            // 
            this.managersBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.managersBtn.Location = new System.Drawing.Point(5, 398);
            this.managersBtn.Name = "managersBtn";
            this.managersBtn.Size = new System.Drawing.Size(99, 38);
            this.managersBtn.TabIndex = 20;
            this.managersBtn.Text = "Managers";
            this.managersBtn.UseSelectable = true;
            this.managersBtn.Click += new System.EventHandler(this.managersBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.LogOutBtn.Location = new System.Drawing.Point(4, 473);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(99, 38);
            this.LogOutBtn.TabIndex = 7;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseSelectable = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Project.Properties.Resources.image_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(20, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click_1);
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
            this.carBtn.Click += new System.EventHandler(this.carBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.payment;
            this.pictureBox2.Location = new System.Drawing.Point(911, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 608);
            this.ControlBox = false;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.managerPanel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.managerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroGrid dgvPayment;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton newBtn;
        private MetroFramework.Controls.MetroTextBox txtCarID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtDue;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private System.Windows.Forms.ComboBox cbMethod;
        private MetroFramework.Controls.MetroButton saveBtn;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtOrderID;
        private MetroFramework.Controls.MetroButton closeBtn;
        private System.Windows.Forms.Label errorLabel;
        private MetroFramework.Controls.MetroButton backBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel managerPanel;
        private MetroFramework.Controls.MetroLabel muserLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton mlogout;
        private MetroFramework.Controls.MetroButton mcars;
        private MetroFramework.Controls.MetroButton morders;
        private MetroFramework.Controls.MetroButton ordersBtn;
        private MetroFramework.Controls.MetroPanel adminPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton managersBtn;
        private MetroFramework.Controls.MetroButton LogOutBtn;
        private MetroFramework.Controls.MetroLabel userLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton orderBtn;
        private MetroFramework.Controls.MetroButton CustomersBtn;
        private MetroFramework.Controls.MetroButton carBtn;
    }
}