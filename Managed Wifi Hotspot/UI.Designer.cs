namespace Managed_Wifi_Hotspot
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_stop_ap = new MetroFramework.Controls.MetroButton();
            this.btn_start_ap = new MetroFramework.Controls.MetroButton();
            this.txt_ap_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_ap_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_connected_devices = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_internet_access = new System.Windows.Forms.DataGridView();
            this.access_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access_ip_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfy_info = new System.Windows.Forms.NotifyIcon(this.components);
            this.err_worker = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connected_devices)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_internet_access)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_stop_ap);
            this.groupBox1.Controls.Add(this.btn_start_ap);
            this.groupBox1.Controls.Add(this.txt_ap_password);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txt_ap_name);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AP Details";
            // 
            // btn_stop_ap
            // 
            this.btn_stop_ap.Enabled = false;
            this.btn_stop_ap.Location = new System.Drawing.Point(103, 102);
            this.btn_stop_ap.Name = "btn_stop_ap";
            this.btn_stop_ap.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_ap.TabIndex = 11;
            this.btn_stop_ap.Text = "STOP AP";
            this.btn_stop_ap.UseSelectable = true;
            this.btn_stop_ap.Click += new System.EventHandler(this.btn_stop_ap_Click);
            // 
            // btn_start_ap
            // 
            this.btn_start_ap.Enabled = false;
            this.btn_start_ap.Location = new System.Drawing.Point(8, 102);
            this.btn_start_ap.Name = "btn_start_ap";
            this.btn_start_ap.Size = new System.Drawing.Size(75, 23);
            this.btn_start_ap.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_start_ap.TabIndex = 10;
            this.btn_start_ap.Text = "START AP";
            this.btn_start_ap.UseSelectable = true;
            this.btn_start_ap.Click += new System.EventHandler(this.btn_start_ap_Click);
            // 
            // txt_ap_password
            // 
            this.txt_ap_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_ap_password.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_ap_password.Lines = new string[0];
            this.txt_ap_password.Location = new System.Drawing.Point(239, 57);
            this.txt_ap_password.MaxLength = 32767;
            this.txt_ap_password.Name = "txt_ap_password";
            this.txt_ap_password.PasswordChar = '*';
            this.txt_ap_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_password.SelectedText = "";
            this.txt_ap_password.Size = new System.Drawing.Size(219, 23);
            this.txt_ap_password.TabIndex = 9;
            this.txt_ap_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ap_password.UseSelectable = true;
            this.txt_ap_password.TextChanged += new System.EventHandler(this.txt_ap_password_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(224, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Password (not less than 6 characters):";
            // 
            // txt_ap_name
            // 
            this.txt_ap_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_ap_name.Lines = new string[0];
            this.txt_ap_name.Location = new System.Drawing.Point(186, 18);
            this.txt_ap_name.MaxLength = 32767;
            this.txt_ap_name.Name = "txt_ap_name";
            this.txt_ap_name.PasswordChar = '\0';
            this.txt_ap_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ap_name.SelectedText = "";
            this.txt_ap_name.Size = new System.Drawing.Size(272, 23);
            this.txt_ap_name.TabIndex = 7;
            this.txt_ap_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ap_name.UseSelectable = true;
            this.txt_ap_name.TextChanged += new System.EventHandler(this.txt_ap_name_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(172, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Wireless Access Point name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_connected_devices);
            this.groupBox2.Location = new System.Drawing.Point(24, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connected Devices";
            // 
            // dgv_connected_devices
            // 
            this.dgv_connected_devices.AllowUserToAddRows = false;
            this.dgv_connected_devices.AllowUserToDeleteRows = false;
            this.dgv_connected_devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_connected_devices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_connected_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_connected_devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ip_address,
            this.set_time});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_connected_devices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_connected_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_connected_devices.Location = new System.Drawing.Point(3, 16);
            this.dgv_connected_devices.Name = "dgv_connected_devices";
            this.dgv_connected_devices.ReadOnly = true;
            this.dgv_connected_devices.RowHeadersVisible = false;
            this.dgv_connected_devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_connected_devices.Size = new System.Drawing.Size(490, 201);
            this.dgv_connected_devices.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Computer Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ip_address
            // 
            this.ip_address.HeaderText = "IP Address";
            this.ip_address.Name = "ip_address";
            this.ip_address.ReadOnly = true;
            // 
            // set_time
            // 
            this.set_time.HeaderText = "Set Time Allowed";
            this.set_time.Name = "set_time";
            this.set_time.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_internet_access);
            this.groupBox3.Location = new System.Drawing.Point(24, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devices with Internet Access";
            // 
            // dgv_internet_access
            // 
            this.dgv_internet_access.AllowUserToAddRows = false;
            this.dgv_internet_access.AllowUserToDeleteRows = false;
            this.dgv_internet_access.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_internet_access.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_internet_access.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_internet_access.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.access_name,
            this.access_ip_address,
            this.time_left});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_internet_access.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_internet_access.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_internet_access.Location = new System.Drawing.Point(3, 16);
            this.dgv_internet_access.Name = "dgv_internet_access";
            this.dgv_internet_access.ReadOnly = true;
            this.dgv_internet_access.RowHeadersVisible = false;
            this.dgv_internet_access.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_internet_access.Size = new System.Drawing.Size(490, 201);
            this.dgv_internet_access.TabIndex = 0;
            // 
            // access_name
            // 
            this.access_name.HeaderText = "Computer Name";
            this.access_name.Name = "access_name";
            this.access_name.ReadOnly = true;
            // 
            // access_ip_address
            // 
            this.access_ip_address.HeaderText = "IP Address";
            this.access_ip_address.Name = "access_ip_address";
            this.access_ip_address.ReadOnly = true;
            // 
            // time_left
            // 
            this.time_left.HeaderText = "Time Left";
            this.time_left.Name = "time_left";
            this.time_left.ReadOnly = true;
            // 
            // nfy_info
            // 
            this.nfy_info.Text = "notifyIcon1";
            this.nfy_info.Visible = true;
            // 
            // err_worker
            // 
            this.err_worker.ContainerControl = this;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 669);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Managed Wifi Hotspot";
            this.Load += new System.EventHandler(this.UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connected_devices)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_internet_access)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_worker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_stop_ap;
        private MetroFramework.Controls.MetroButton btn_start_ap;
        private MetroFramework.Controls.MetroTextBox txt_ap_password;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_ap_name;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_connected_devices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_internet_access;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn set_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn access_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn access_ip_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_left;
        private System.Windows.Forms.NotifyIcon nfy_info;
        private System.Windows.Forms.ErrorProvider err_worker;
    }
}

