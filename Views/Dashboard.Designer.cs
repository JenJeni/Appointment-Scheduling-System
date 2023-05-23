
namespace AppointmentSchedulingApplication.Views
{
    partial class Dashboard
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
            this.exitDashBtn = new System.Windows.Forms.Button();
            this.rBtnCurrWeek = new System.Windows.Forms.RadioButton();
            this.rBtnCurrMonth = new System.Windows.Forms.RadioButton();
            this.rBtnAllAppt = new System.Windows.Forms.RadioButton();
            this.delAppBtn = new System.Windows.Forms.Button();
            this.updApptBtn = new System.Windows.Forms.Button();
            this.newApptBtn = new System.Windows.Forms.Button();
            this.apptDGV = new System.Windows.Forms.DataGridView();
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.delCustBtn = new System.Windows.Forms.Button();
            this.updateCustBtn = new System.Windows.Forms.Button();
            this.newCustBtn = new System.Windows.Forms.Button();
            this.labelAppt = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.groupBxReports = new System.Windows.Forms.GroupBox();
            this.btnCustomerCount = new System.Windows.Forms.Button();
            this.btnUsrSched = new System.Windows.Forms.Button();
            this.btnMonthType = new System.Windows.Forms.Button();
            this.labelViewAppt = new System.Windows.Forms.Label();
            this.apptCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBxCal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.apptDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.groupBxReports.SuspendLayout();
            this.groupBxCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitDashBtn
            // 
            this.exitDashBtn.Location = new System.Drawing.Point(1017, 482);
            this.exitDashBtn.Name = "exitDashBtn";
            this.exitDashBtn.Size = new System.Drawing.Size(75, 33);
            this.exitDashBtn.TabIndex = 17;
            this.exitDashBtn.TabStop = false;
            this.exitDashBtn.Text = "Exit";
            this.exitDashBtn.UseVisualStyleBackColor = true;
            this.exitDashBtn.Click += new System.EventHandler(this.exitDashBtn_Click);
            // 
            // rBtnCurrWeek
            // 
            this.rBtnCurrWeek.AutoSize = true;
            this.rBtnCurrWeek.Location = new System.Drawing.Point(54, 30);
            this.rBtnCurrWeek.Name = "rBtnCurrWeek";
            this.rBtnCurrWeek.Size = new System.Drawing.Size(54, 17);
            this.rBtnCurrWeek.TabIndex = 16;
            this.rBtnCurrWeek.TabStop = true;
            this.rBtnCurrWeek.Text = "Week";
            this.rBtnCurrWeek.UseVisualStyleBackColor = true;
            this.rBtnCurrWeek.CheckedChanged += new System.EventHandler(this.rBtnCurrWeek_CheckedChanged);
            // 
            // rBtnCurrMonth
            // 
            this.rBtnCurrMonth.AutoSize = true;
            this.rBtnCurrMonth.Location = new System.Drawing.Point(114, 30);
            this.rBtnCurrMonth.Name = "rBtnCurrMonth";
            this.rBtnCurrMonth.Size = new System.Drawing.Size(55, 17);
            this.rBtnCurrMonth.TabIndex = 15;
            this.rBtnCurrMonth.TabStop = true;
            this.rBtnCurrMonth.Text = "Month";
            this.rBtnCurrMonth.UseVisualStyleBackColor = true;
            this.rBtnCurrMonth.CheckedChanged += new System.EventHandler(this.rBtnCurrMonth_CheckedChanged);
            // 
            // rBtnAllAppt
            // 
            this.rBtnAllAppt.AutoSize = true;
            this.rBtnAllAppt.Location = new System.Drawing.Point(175, 30);
            this.rBtnAllAppt.Name = "rBtnAllAppt";
            this.rBtnAllAppt.Size = new System.Drawing.Size(39, 17);
            this.rBtnAllAppt.TabIndex = 14;
            this.rBtnAllAppt.TabStop = true;
            this.rBtnAllAppt.Text = "All ";
            this.rBtnAllAppt.UseVisualStyleBackColor = true;
            this.rBtnAllAppt.CheckedChanged += new System.EventHandler(this.rBtnAllAppt_CheckedChanged);
            // 
            // delAppBtn
            // 
            this.delAppBtn.Location = new System.Drawing.Point(1017, 141);
            this.delAppBtn.Name = "delAppBtn";
            this.delAppBtn.Size = new System.Drawing.Size(75, 33);
            this.delAppBtn.TabIndex = 22;
            this.delAppBtn.TabStop = false;
            this.delAppBtn.Text = "Delete";
            this.delAppBtn.UseVisualStyleBackColor = true;
            this.delAppBtn.Click += new System.EventHandler(this.delAppBtn_Click);
            // 
            // updApptBtn
            // 
            this.updApptBtn.Location = new System.Drawing.Point(1017, 102);
            this.updApptBtn.Name = "updApptBtn";
            this.updApptBtn.Size = new System.Drawing.Size(75, 33);
            this.updApptBtn.TabIndex = 21;
            this.updApptBtn.TabStop = false;
            this.updApptBtn.Text = "Update";
            this.updApptBtn.UseVisualStyleBackColor = true;
            this.updApptBtn.Click += new System.EventHandler(this.updApptBtn_Click);
            // 
            // newApptBtn
            // 
            this.newApptBtn.Location = new System.Drawing.Point(1017, 60);
            this.newApptBtn.Name = "newApptBtn";
            this.newApptBtn.Size = new System.Drawing.Size(75, 33);
            this.newApptBtn.TabIndex = 20;
            this.newApptBtn.TabStop = false;
            this.newApptBtn.Text = "New";
            this.newApptBtn.UseVisualStyleBackColor = true;
            this.newApptBtn.Click += new System.EventHandler(this.newApptBtn_Click);
            // 
            // apptDGV
            // 
            this.apptDGV.AllowUserToAddRows = false;
            this.apptDGV.AllowUserToResizeColumns = false;
            this.apptDGV.AllowUserToResizeRows = false;
            this.apptDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.apptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDGV.Location = new System.Drawing.Point(300, 62);
            this.apptDGV.Name = "apptDGV";
            this.apptDGV.ReadOnly = true;
            this.apptDGV.RowHeadersVisible = false;
            this.apptDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptDGV.Size = new System.Drawing.Size(711, 162);
            this.apptDGV.TabIndex = 19;
            this.apptDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apptDGV_CellClick);
            this.apptDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.apptDGV_CellFormatting);
            this.apptDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.apptDGV_DataBindingComplete);
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToResizeColumns = false;
            this.customerDGV.AllowUserToResizeRows = false;
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(300, 271);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDGV.RowHeadersVisible = false;
            this.customerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDGV.Size = new System.Drawing.Size(711, 185);
            this.customerDGV.TabIndex = 43;
            this.customerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDGV_CellClick);
            this.customerDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.customerDGV_DataBindingComplete);
            // 
            // delCustBtn
            // 
            this.delCustBtn.Location = new System.Drawing.Point(1017, 349);
            this.delCustBtn.Name = "delCustBtn";
            this.delCustBtn.Size = new System.Drawing.Size(75, 33);
            this.delCustBtn.TabIndex = 42;
            this.delCustBtn.TabStop = false;
            this.delCustBtn.Text = "Delete";
            this.delCustBtn.UseVisualStyleBackColor = true;
            this.delCustBtn.Click += new System.EventHandler(this.delCustBtn_Click);
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.Location = new System.Drawing.Point(1017, 310);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(75, 33);
            this.updateCustBtn.TabIndex = 41;
            this.updateCustBtn.TabStop = false;
            this.updateCustBtn.Text = "Update";
            this.updateCustBtn.UseVisualStyleBackColor = true;
            this.updateCustBtn.Click += new System.EventHandler(this.updateCustBtn_Click);
            // 
            // newCustBtn
            // 
            this.newCustBtn.Location = new System.Drawing.Point(1017, 271);
            this.newCustBtn.Name = "newCustBtn";
            this.newCustBtn.Size = new System.Drawing.Size(75, 33);
            this.newCustBtn.TabIndex = 40;
            this.newCustBtn.TabStop = false;
            this.newCustBtn.Text = "New";
            this.newCustBtn.UseVisualStyleBackColor = true;
            this.newCustBtn.Click += new System.EventHandler(this.newCustBtn_Click);
            // 
            // labelAppt
            // 
            this.labelAppt.AutoSize = true;
            this.labelAppt.Location = new System.Drawing.Point(300, 43);
            this.labelAppt.Name = "labelAppt";
            this.labelAppt.Size = new System.Drawing.Size(71, 13);
            this.labelAppt.TabIndex = 44;
            this.labelAppt.Text = "Appointments";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(300, 255);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(56, 13);
            this.labelCustomer.TabIndex = 45;
            this.labelCustomer.Text = "Customers";
            // 
            // groupBxReports
            // 
            this.groupBxReports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBxReports.Controls.Add(this.btnCustomerCount);
            this.groupBxReports.Controls.Add(this.btnUsrSched);
            this.groupBxReports.Controls.Add(this.btnMonthType);
            this.groupBxReports.Location = new System.Drawing.Point(22, 246);
            this.groupBxReports.Name = "groupBxReports";
            this.groupBxReports.Size = new System.Drawing.Size(237, 210);
            this.groupBxReports.TabIndex = 46;
            this.groupBxReports.TabStop = false;
            this.groupBxReports.Text = "Reports";
            // 
            // btnCustomerCount
            // 
            this.btnCustomerCount.Location = new System.Drawing.Point(6, 134);
            this.btnCustomerCount.Name = "btnCustomerCount";
            this.btnCustomerCount.Size = new System.Drawing.Size(225, 44);
            this.btnCustomerCount.TabIndex = 2;
            this.btnCustomerCount.Text = "Customers Without Appointment";
            this.btnCustomerCount.UseVisualStyleBackColor = true;
            this.btnCustomerCount.Click += new System.EventHandler(this.btnCustomerCount_Click);
            // 
            // btnUsrSched
            // 
            this.btnUsrSched.Location = new System.Drawing.Point(6, 86);
            this.btnUsrSched.Name = "btnUsrSched";
            this.btnUsrSched.Size = new System.Drawing.Size(225, 42);
            this.btnUsrSched.TabIndex = 1;
            this.btnUsrSched.Text = "Consultant Schedule";
            this.btnUsrSched.UseVisualStyleBackColor = true;
            this.btnUsrSched.Click += new System.EventHandler(this.btnUsrSched_Click);
            // 
            // btnMonthType
            // 
            this.btnMonthType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMonthType.Location = new System.Drawing.Point(6, 34);
            this.btnMonthType.Name = "btnMonthType";
            this.btnMonthType.Size = new System.Drawing.Size(225, 46);
            this.btnMonthType.TabIndex = 0;
            this.btnMonthType.Text = "Appointment Types By Month";
            this.btnMonthType.UseVisualStyleBackColor = false;
            this.btnMonthType.Click += new System.EventHandler(this.btnMonthType_Click);
            // 
            // labelViewAppt
            // 
            this.labelViewAppt.AutoSize = true;
            this.labelViewAppt.Location = new System.Drawing.Point(15, 32);
            this.labelViewAppt.Name = "labelViewAppt";
            this.labelViewAppt.Size = new System.Drawing.Size(33, 13);
            this.labelViewAppt.TabIndex = 47;
            this.labelViewAppt.Text = "View:";
            // 
            // apptCalendar
            // 
            this.apptCalendar.Location = new System.Drawing.Point(4, 54);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.TabIndex = 48;
            // 
            // groupBxCal
            // 
            this.groupBxCal.Controls.Add(this.apptCalendar);
            this.groupBxCal.Controls.Add(this.rBtnAllAppt);
            this.groupBxCal.Controls.Add(this.labelViewAppt);
            this.groupBxCal.Controls.Add(this.rBtnCurrMonth);
            this.groupBxCal.Controls.Add(this.rBtnCurrWeek);
            this.groupBxCal.Location = new System.Drawing.Point(22, 12);
            this.groupBxCal.Name = "groupBxCal";
            this.groupBxCal.Size = new System.Drawing.Size(237, 228);
            this.groupBxCal.TabIndex = 49;
            this.groupBxCal.TabStop = false;
            this.groupBxCal.Text = "Calendar";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 527);
            this.Controls.Add(this.groupBxCal);
            this.Controls.Add(this.groupBxReports);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelAppt);
            this.Controls.Add(this.customerDGV);
            this.Controls.Add(this.delCustBtn);
            this.Controls.Add(this.updateCustBtn);
            this.Controls.Add(this.newCustBtn);
            this.Controls.Add(this.delAppBtn);
            this.Controls.Add(this.updApptBtn);
            this.Controls.Add(this.newApptBtn);
            this.Controls.Add(this.apptDGV);
            this.Controls.Add(this.exitDashBtn);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apptDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.groupBxReports.ResumeLayout(false);
            this.groupBxCal.ResumeLayout(false);
            this.groupBxCal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitDashBtn;
        private System.Windows.Forms.RadioButton rBtnCurrWeek;
        private System.Windows.Forms.RadioButton rBtnCurrMonth;
        private System.Windows.Forms.RadioButton rBtnAllAppt;
        private System.Windows.Forms.Button delAppBtn;
        private System.Windows.Forms.Button updApptBtn;
        private System.Windows.Forms.Button newApptBtn;
        private System.Windows.Forms.DataGridView apptDGV;
        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Button delCustBtn;
        private System.Windows.Forms.Button updateCustBtn;
        private System.Windows.Forms.Button newCustBtn;
        private System.Windows.Forms.Label labelAppt;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.GroupBox groupBxReports;
        private System.Windows.Forms.Button btnCustomerCount;
        private System.Windows.Forms.Button btnUsrSched;
        private System.Windows.Forms.Button btnMonthType;
        private System.Windows.Forms.Label labelViewAppt;
        private System.Windows.Forms.MonthCalendar apptCalendar;
        private System.Windows.Forms.GroupBox groupBxCal;
    }
}