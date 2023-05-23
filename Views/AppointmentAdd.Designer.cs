
namespace AppointmentSchedulingApplication.Views
{
    partial class AppointmentAdd
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
            this.cancelNewApptBtn = new System.Windows.Forms.Button();
            this.saveNewApptBtn = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cboApptType = new System.Windows.Forms.ComboBox();
            this.apptIdTxt = new System.Windows.Forms.TextBox();
            this.labelApptEnd = new System.Windows.Forms.Label();
            this.labelApptStart = new System.Windows.Forms.Label();
            this.labelApptType = new System.Windows.Forms.Label();
            this.labelUsrId = new System.Windows.Forms.Label();
            this.labelApptId = new System.Windows.Forms.Label();
            this.labelNewAppt = new System.Windows.Forms.Label();
            this.labelCus = new System.Windows.Forms.Label();
            this.labelCusId = new System.Windows.Forms.Label();
            this.cboCusId = new System.Windows.Forms.ComboBox();
            this.cusNameTxt = new System.Windows.Forms.TextBox();
            this.cboUsrId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelNewApptBtn
            // 
            this.cancelNewApptBtn.Location = new System.Drawing.Point(320, 375);
            this.cancelNewApptBtn.Name = "cancelNewApptBtn";
            this.cancelNewApptBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelNewApptBtn.TabIndex = 33;
            this.cancelNewApptBtn.TabStop = false;
            this.cancelNewApptBtn.Text = "Cancel";
            this.cancelNewApptBtn.UseVisualStyleBackColor = true;
            this.cancelNewApptBtn.Click += new System.EventHandler(this.cancelNewApptBtn_Click);
            // 
            // saveNewApptBtn
            // 
            this.saveNewApptBtn.Location = new System.Drawing.Point(231, 375);
            this.saveNewApptBtn.Name = "saveNewApptBtn";
            this.saveNewApptBtn.Size = new System.Drawing.Size(75, 33);
            this.saveNewApptBtn.TabIndex = 32;
            this.saveNewApptBtn.TabStop = false;
            this.saveNewApptBtn.Text = "Save";
            this.saveNewApptBtn.UseVisualStyleBackColor = true;
            this.saveNewApptBtn.Click += new System.EventHandler(this.saveNewApptBtn_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(153, 275);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 31;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(153, 242);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 30;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // cboApptType
            // 
            this.cboApptType.FormattingEnabled = true;
            this.cboApptType.Location = new System.Drawing.Point(153, 211);
            this.cboApptType.Name = "cboApptType";
            this.cboApptType.Size = new System.Drawing.Size(200, 21);
            this.cboApptType.TabIndex = 29;
            this.cboApptType.Click += new System.EventHandler(this.cboApptType_Click);
            // 
            // apptIdTxt
            // 
            this.apptIdTxt.Enabled = false;
            this.apptIdTxt.Location = new System.Drawing.Point(153, 80);
            this.apptIdTxt.Name = "apptIdTxt";
            this.apptIdTxt.ReadOnly = true;
            this.apptIdTxt.Size = new System.Drawing.Size(84, 20);
            this.apptIdTxt.TabIndex = 25;
            this.apptIdTxt.TabStop = false;
            // 
            // labelApptEnd
            // 
            this.labelApptEnd.AutoSize = true;
            this.labelApptEnd.Location = new System.Drawing.Point(106, 281);
            this.labelApptEnd.Name = "labelApptEnd";
            this.labelApptEnd.Size = new System.Drawing.Size(29, 13);
            this.labelApptEnd.TabIndex = 24;
            this.labelApptEnd.Text = "End:";
            // 
            // labelApptStart
            // 
            this.labelApptStart.AutoSize = true;
            this.labelApptStart.Location = new System.Drawing.Point(103, 248);
            this.labelApptStart.Name = "labelApptStart";
            this.labelApptStart.Size = new System.Drawing.Size(32, 13);
            this.labelApptStart.TabIndex = 23;
            this.labelApptStart.Text = "Start:";
            // 
            // labelApptType
            // 
            this.labelApptType.AutoSize = true;
            this.labelApptType.Location = new System.Drawing.Point(101, 219);
            this.labelApptType.Name = "labelApptType";
            this.labelApptType.Size = new System.Drawing.Size(34, 13);
            this.labelApptType.TabIndex = 22;
            this.labelApptType.Text = "Type:";
            // 
            // labelUsrId
            // 
            this.labelUsrId.AutoSize = true;
            this.labelUsrId.Location = new System.Drawing.Point(91, 150);
            this.labelUsrId.Name = "labelUsrId";
            this.labelUsrId.Size = new System.Drawing.Size(44, 13);
            this.labelUsrId.TabIndex = 20;
            this.labelUsrId.Text = "User Id:";
            // 
            // labelApptId
            // 
            this.labelApptId.AutoSize = true;
            this.labelApptId.Location = new System.Drawing.Point(54, 83);
            this.labelApptId.Name = "labelApptId";
            this.labelApptId.Size = new System.Drawing.Size(81, 13);
            this.labelApptId.TabIndex = 18;
            this.labelApptId.Text = "Appointment Id:";
            // 
            // labelNewAppt
            // 
            this.labelNewAppt.AutoSize = true;
            this.labelNewAppt.Location = new System.Drawing.Point(16, 14);
            this.labelNewAppt.Name = "labelNewAppt";
            this.labelNewAppt.Size = new System.Drawing.Size(91, 13);
            this.labelNewAppt.TabIndex = 17;
            this.labelNewAppt.Text = "New Appointment";
            // 
            // labelCus
            // 
            this.labelCus.AutoSize = true;
            this.labelCus.Location = new System.Drawing.Point(81, 184);
            this.labelCus.Name = "labelCus";
            this.labelCus.Size = new System.Drawing.Size(54, 13);
            this.labelCus.TabIndex = 35;
            this.labelCus.Text = "Customer:";
            // 
            // labelCusId
            // 
            this.labelCusId.AutoSize = true;
            this.labelCusId.Location = new System.Drawing.Point(69, 116);
            this.labelCusId.Name = "labelCusId";
            this.labelCusId.Size = new System.Drawing.Size(66, 13);
            this.labelCusId.TabIndex = 37;
            this.labelCusId.Text = "Customer Id:";
            // 
            // cboCusId
            // 
            this.cboCusId.FormattingEnabled = true;
            this.cboCusId.Location = new System.Drawing.Point(153, 113);
            this.cboCusId.Name = "cboCusId";
            this.cboCusId.Size = new System.Drawing.Size(84, 21);
            this.cboCusId.TabIndex = 39;
            this.cboCusId.SelectedIndexChanged += new System.EventHandler(this.cboCusId_SelectedIndexChanged);
            // 
            // cusNameTxt
            // 
            this.cusNameTxt.Location = new System.Drawing.Point(153, 181);
            this.cusNameTxt.Name = "cusNameTxt";
            this.cusNameTxt.ReadOnly = true;
            this.cusNameTxt.Size = new System.Drawing.Size(200, 20);
            this.cusNameTxt.TabIndex = 40;
            this.cusNameTxt.TextChanged += new System.EventHandler(this.cusNameTxt_TextChanged);
            // 
            // cboUsrId
            // 
            this.cboUsrId.FormattingEnabled = true;
            this.cboUsrId.Location = new System.Drawing.Point(153, 147);
            this.cboUsrId.Name = "cboUsrId";
            this.cboUsrId.Size = new System.Drawing.Size(84, 21);
            this.cboUsrId.TabIndex = 41;
            this.cboUsrId.SelectedIndexChanged += new System.EventHandler(this.cboUsrId_SelectedIndexChanged);
            // 
            // AppointmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 420);
            this.Controls.Add(this.cboUsrId);
            this.Controls.Add(this.cusNameTxt);
            this.Controls.Add(this.cboCusId);
            this.Controls.Add(this.labelCusId);
            this.Controls.Add(this.labelCus);
            this.Controls.Add(this.cancelNewApptBtn);
            this.Controls.Add(this.saveNewApptBtn);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboApptType);
            this.Controls.Add(this.apptIdTxt);
            this.Controls.Add(this.labelApptEnd);
            this.Controls.Add(this.labelApptStart);
            this.Controls.Add(this.labelApptType);
            this.Controls.Add(this.labelUsrId);
            this.Controls.Add(this.labelApptId);
            this.Controls.Add(this.labelNewAppt);
            this.Name = "AppointmentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelNewApptBtn;
        private System.Windows.Forms.Button saveNewApptBtn;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cboApptType;
        private System.Windows.Forms.TextBox apptIdTxt;
        private System.Windows.Forms.Label labelApptEnd;
        private System.Windows.Forms.Label labelApptStart;
        private System.Windows.Forms.Label labelApptType;
        private System.Windows.Forms.Label labelUsrId;
        private System.Windows.Forms.Label labelApptId;
        private System.Windows.Forms.Label labelNewAppt;
        private System.Windows.Forms.Label labelCus;
        private System.Windows.Forms.Label labelCusId;
        private System.Windows.Forms.ComboBox cboCusId;
        private System.Windows.Forms.TextBox cusNameTxt;
        private System.Windows.Forms.ComboBox cboUsrId;
    }
}