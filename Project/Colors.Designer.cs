namespace Project
{
    partial class Colors
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.txtColorName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtColorID = new MetroFramework.Controls.MetroTextBox();
            this.IDlabel = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvColors = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.54449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.45551F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.05578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.txtColorName);
            this.panel4.Controls.Add(this.metroLabel2);
            this.panel4.Controls.Add(this.txtColorID);
            this.panel4.Controls.Add(this.IDlabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(393, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 383);
            this.panel4.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(238, 345);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseSelectable = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.saveBtn.Location = new System.Drawing.Point(128, 216);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 38);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtColorName
            // 
            // 
            // 
            // 
            this.txtColorName.CustomButton.Image = null;
            this.txtColorName.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtColorName.CustomButton.Name = "";
            this.txtColorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColorName.CustomButton.TabIndex = 1;
            this.txtColorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColorName.CustomButton.UseSelectable = true;
            this.txtColorName.CustomButton.Visible = false;
            this.txtColorName.Lines = new string[0];
            this.txtColorName.Location = new System.Drawing.Point(119, 144);
            this.txtColorName.MaxLength = 32767;
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.PasswordChar = '\0';
            this.txtColorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColorName.SelectedText = "";
            this.txtColorName.SelectionLength = 0;
            this.txtColorName.SelectionStart = 0;
            this.txtColorName.ShortcutsEnabled = true;
            this.txtColorName.Size = new System.Drawing.Size(144, 23);
            this.txtColorName.TabIndex = 3;
            this.txtColorName.UseSelectable = true;
            this.txtColorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(51, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Name:";
            // 
            // txtColorID
            // 
            // 
            // 
            // 
            this.txtColorID.CustomButton.Image = null;
            this.txtColorID.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtColorID.CustomButton.Name = "";
            this.txtColorID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColorID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColorID.CustomButton.TabIndex = 1;
            this.txtColorID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColorID.CustomButton.UseSelectable = true;
            this.txtColorID.CustomButton.Visible = false;
            this.txtColorID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtColorID.Lines = new string[0];
            this.txtColorID.Location = new System.Drawing.Point(119, 80);
            this.txtColorID.MaxLength = 32767;
            this.txtColorID.Name = "txtColorID";
            this.txtColorID.PasswordChar = '\0';
            this.txtColorID.PromptText = "Auto generated";
            this.txtColorID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColorID.SelectedText = "";
            this.txtColorID.SelectionLength = 0;
            this.txtColorID.SelectionStart = 0;
            this.txtColorID.ShortcutsEnabled = true;
            this.txtColorID.Size = new System.Drawing.Size(144, 23);
            this.txtColorID.TabIndex = 1;
            this.txtColorID.UseSelectable = true;
            this.txtColorID.WaterMark = "Auto generated";
            this.txtColorID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColorID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.IDlabel.Location = new System.Drawing.Point(51, 80);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(32, 25);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvColors);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 383);
            this.panel3.TabIndex = 2;
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AllowUserToResizeRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvColors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColors.EnableHeadersVisualStyles = false;
            this.dgvColors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvColors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvColors.Location = new System.Drawing.Point(0, 0);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(382, 381);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrands_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(393, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 57);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 57);
            this.panel1.TabIndex = 0;
            // 
            // newBtn
            // 
            this.newBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.newBtn.Location = new System.Drawing.Point(137, 9);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(109, 38);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "New";
            this.newBtn.UseSelectable = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.refreshBtn.Location = new System.Drawing.Point(3, 9);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 38);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.deleteBtn.Location = new System.Drawing.Point(270, 9);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 38);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Colors";
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.Colors_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroButton newBtn;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroLabel IDlabel;
        private MetroFramework.Controls.MetroTextBox txtColorID;
        private MetroFramework.Controls.MetroTextBox txtColorName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroGrid dgvColors;
    }
}