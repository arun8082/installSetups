namespace dco_setup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.rdbtn_po = new System.Windows.Forms.RadioButton();
            this.rdbtn_dco = new System.Windows.Forms.RadioButton();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_verifyDrivers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkList_drivers = new System.Windows.Forms.CheckedListBox();
            this.btn_driverPath = new System.Windows.Forms.Button();
            this.lbl_driverPath = new System.Windows.Forms.Label();
            this.txt_driverPath = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.rdbtn_po);
            this.pnl_main.Controls.Add(this.rdbtn_dco);
            this.pnl_main.Controls.Add(this.lbl_status);
            this.pnl_main.Controls.Add(this.btn_install);
            this.pnl_main.Controls.Add(this.btn_verifyDrivers);
            this.pnl_main.Controls.Add(this.groupBox1);
            this.pnl_main.Controls.Add(this.btn_driverPath);
            this.pnl_main.Controls.Add(this.lbl_driverPath);
            this.pnl_main.Controls.Add(this.txt_driverPath);
            this.pnl_main.Controls.Add(this.lbl_welcome);
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(631, 327);
            this.pnl_main.TabIndex = 0;
            // 
            // rdbtn_po
            // 
            this.rdbtn_po.AutoSize = true;
            this.rdbtn_po.Location = new System.Drawing.Point(144, 67);
            this.rdbtn_po.Name = "rdbtn_po";
            this.rdbtn_po.Size = new System.Drawing.Size(40, 17);
            this.rdbtn_po.TabIndex = 9;
            this.rdbtn_po.Text = "PO";
            this.rdbtn_po.UseVisualStyleBackColor = true;
            this.rdbtn_po.CheckedChanged += new System.EventHandler(this.rdbtn_po_CheckedChanged);
            // 
            // rdbtn_dco
            // 
            this.rdbtn_dco.AutoSize = true;
            this.rdbtn_dco.Location = new System.Drawing.Point(22, 67);
            this.rdbtn_dco.Name = "rdbtn_dco";
            this.rdbtn_dco.Size = new System.Drawing.Size(48, 17);
            this.rdbtn_dco.TabIndex = 8;
            this.rdbtn_dco.Text = "DCO";
            this.rdbtn_dco.UseVisualStyleBackColor = true;
            this.rdbtn_dco.CheckedChanged += new System.EventHandler(this.rdbtn_dco_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(19, 295);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Status: ";
            // 
            // btn_install
            // 
            this.btn_install.Enabled = false;
            this.btn_install.Location = new System.Drawing.Point(414, 285);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(92, 23);
            this.btn_install.TabIndex = 6;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_verifyDrivers
            // 
            this.btn_verifyDrivers.Location = new System.Drawing.Point(316, 285);
            this.btn_verifyDrivers.Name = "btn_verifyDrivers";
            this.btn_verifyDrivers.Size = new System.Drawing.Size(92, 23);
            this.btn_verifyDrivers.TabIndex = 5;
            this.btn_verifyDrivers.Text = "Verify Drivers";
            this.btn_verifyDrivers.UseVisualStyleBackColor = true;
            this.btn_verifyDrivers.Click += new System.EventHandler(this.btn_verifyDrivers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkList_drivers);
            this.groupBox1.Location = new System.Drawing.Point(19, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drivers List";
            // 
            // chkList_drivers
            // 
            this.chkList_drivers.Enabled = false;
            this.chkList_drivers.FormattingEnabled = true;
            this.chkList_drivers.IntegralHeight = false;
            this.chkList_drivers.Location = new System.Drawing.Point(25, 28);
            this.chkList_drivers.Name = "chkList_drivers";
            this.chkList_drivers.Size = new System.Drawing.Size(537, 154);
            this.chkList_drivers.TabIndex = 0;
            // 
            // btn_driverPath
            // 
            this.btn_driverPath.Location = new System.Drawing.Point(439, 39);
            this.btn_driverPath.Name = "btn_driverPath";
            this.btn_driverPath.Size = new System.Drawing.Size(92, 23);
            this.btn_driverPath.TabIndex = 3;
            this.btn_driverPath.Text = "Select Folder";
            this.btn_driverPath.UseVisualStyleBackColor = true;
            this.btn_driverPath.Click += new System.EventHandler(this.btn_driverPath_Click);
            // 
            // lbl_driverPath
            // 
            this.lbl_driverPath.AutoSize = true;
            this.lbl_driverPath.Location = new System.Drawing.Point(19, 44);
            this.lbl_driverPath.Name = "lbl_driverPath";
            this.lbl_driverPath.Size = new System.Drawing.Size(119, 13);
            this.lbl_driverPath.TabIndex = 2;
            this.lbl_driverPath.Text = "Choose Driver Directory";
            // 
            // txt_driverPath
            // 
            this.txt_driverPath.Location = new System.Drawing.Point(144, 41);
            this.txt_driverPath.Name = "txt_driverPath";
            this.txt_driverPath.Size = new System.Drawing.Size(289, 20);
            this.txt_driverPath.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(14, 10);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(396, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to DCO & PO Installation Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Designed by Arunendra Kumar @CDAC-Mumbai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DCO & PO Installer Setup v0.1 ";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_driverPath;
        private System.Windows.Forms.TextBox txt_driverPath;
        private System.Windows.Forms.Button btn_driverPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkList_drivers;
        private System.Windows.Forms.Button btn_verifyDrivers;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.RadioButton rdbtn_po;
        private System.Windows.Forms.RadioButton rdbtn_dco;
        private System.Windows.Forms.Label label1;
    }
}

