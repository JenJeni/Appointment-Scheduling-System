
namespace AppointmentSchedulingApplication.Views
{
    partial class AppointmentUpdate
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
            this.cancelApptUpdBtn = new System.Windows.Forms.Button();
            this.saveApptUpdBtn = new System.Windows.Forms.Button();
            this.labelUpdAppt = new System.Windows.Forms.Label();
            this.cboUsrIdUpd = new System.Windows.Forms.ComboBox();
            this.cusNameTxtUpd = new System.Windows.Forms.TextBox();
            this.cboCusIdUpd = new System.Windows.Forms.ComboBox();
            this.labelCusId = new System.Windows.Forms.Label();
            this.labelCus = new System.Windows.Forms.Label();
            this.dtpEndUpd = new System.Windows.Forms.DateTimePicker();
            this.dtpStartUpd = new System.Windows.Forms.DateTimePicker();
            this.cboApptTypeUpd = new System.Windows.Forms.ComboBox();
            this.apptIdTxtUpd = new System.Windows.Forms.TextBox();
            this.labelApptEnd = new System.Windows.Forms.Label();
            this.labelApptStart = new System.Windows.Forms.Label();
            this.labelApptType = new System.Windows.Forms.Label();
            this.labelUsrId = new System.Windows.Forms.Label();
            this.labelApptId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelApptUpdBtn
            // 
            this.cancelApptUpdBtn.Location = new System.Drawing.Point(320, 375);
            this.cancelApptUpdBtn.Name = "cancelApptUpdBtn";
            this.cancelApptUpdBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelApptUpdBtn.TabIndex = 50;
            this.cancelApptUpdBtn.TabStop = false;
            this.cancelApptUpdBtn.Text = "Cancel";
            this.cancelApptUpdBtn.UseVisualStyleBackColor = true;
            this.cancelApptUpdBtn.Click += new System.EventHandler(this.cancelApptUpdBtn_Click);
            // 
            // saveApptUpdBtn
            // 
            this.saveApptUpdBtn.Location = new System.Drawing.Point(239, 375);
            this.saveApptUpdBtn.Name = "saveApptUpdBtn";
            this.saveApptUpdBtn.Size = new System.Drawing.Size(75, 33);
            this.saveApptUpdBtn.TabIndex = 49;
            this.saveApptUpdBtn.TabStop = false;
            this.saveApptUpdBtn.Text = "Save";
            this.saveApptUpdBtn.UseVisualStyleBackColor = true;
            this.saveApptUpdBtn.Click += new System.EventHandler(this.saveApptUpdBtn_Click);
            // 
            // labelUpdAppt
            // 
            this.labelUpdAppt.AutoSize = true;
            this.labelUpdAppt.Location = new System.Drawing.Point(13, 11);
            this.labelUpdAppt.Name = "labelUpdAppt";
            this.labelUpdAppt.Size = new System.Drawing.Size(104, 13);
            this.labelUpdAppt.TabIndex = 34;
            this.labelUpdAppt.Text = "Update Appointment";
            // 
            // cboUsrIdUpd
            // 
            this.cboUsrIdUpd.FormattingEnabled = true;
            this.cboUsrIdUpd.Location = new System.Drawing.Point(157, 144);
            this.cboUsrIdUpd.Name = "cboUsrIdUpd";
            this.cboUsrIdUpd.Size = new System.Drawing.Size(84, 21);
            this.cboUsrIdUpd.TabIndex = 64;
            this.cboUsrIdUpd.SelectedIndexChanged += new System.EventHandler(this.cboUsrIdUpd_SelectedIndexChanged);
            // 
            // cusNameTxtUpd
            // 
            this.cusNameTxtUpd.Location = new System.Drawing.Point(157, 178);
            this.cusNameTxtUpd.Name = "cusNameTxtUpd";
            this.cusNameTxtUpd.ReadOnly = true;
            this.cusNameTxtUpd.Size = new System.Drawing.Size(200, 20);
            this.cusNameTxtUpd.TabIndex = 63;
            this.cusNameTxtUpd.TextChanged += new System.EventHandler(this.cusNameTxtUpd_TextChanged);
            // 
            // cboCusIdUpd
            // 
            this.cboCusIdUpd.FormattingEnabled = true;
            this.cboCusIdUpd.Location = new System.Drawing.Point(157, 110);
            this.cboCusIdUpd.Name = "cboCusIdUpd";
            this.cboCusIdUpd.Size = new System.Drawing.Size(84, 21);
            this.cboCusIdUpd.TabIndex = 62;
            this.cboCusIdUpd.SelectedIndexChanged += new System.EventHandler(this.cboCusIdUpd_SelectedIndexChanged);
            // 
            // labelCusId
            // 
            this.labelCusId.AutoSize = true;
            this.labelCusId.Location = new System.Drawing.Point(73, 113);
            this.labelCusId.Name = "labelCusId";
            this.labelCusId.Size = new System.Drawing.Size(66, 13);
            this.labelCusId.TabIndex = 61;
            this.labelCusId.Text = "Customer Id:";
            // 
            // labelCus
            // 
            this.labelCus.AutoSize = true;
            this.labelCus.Location = new System.Drawing.Point(85, 181);
            this.labelCus.Name = "labelCus";
            this.labelCus.Size = new System.Drawing.Size(54, 13);
            this.labelCus.TabIndex = 60;
            this.labelCus.Text = "Customer:";
            // 
            // dtpEndUpd
            // 
            this.dtpEndUpd.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtpEndUpd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndUpd.Location = new System.Drawing.Point(157, 272);
            this.dtpEndUpd.Name = "dtpEndUpd";
            this.dtpEndUpd.Size = new System.Drawing.Size(200, 20);
            this.dtpEndUpd.TabIndex = 59;
            this.dtpEndUpd.ValueChanged += new System.EventHandler(this.dtpEndUpd_ValueChanged);
            // 
            // dtpStartUpd
            // 
            this.dtpStartUpd.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtpStartUpd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartUpd.Location = new System.Drawing.Point(157, 239);
            this.dtpStartUpd.Name = "dtpStartUpd";
            this.dtpStartUpd.Size = new System.Drawing.Size(200, 20);
            this.dtpStartUpd.TabIndex = 58;
            this.dtpStartUpd.ValueChanged += new System.EventHandler(this.dtpStartUpd_ValueChanged);
            // 
            // cboApptTypeUpd
            // 
            this.cboApptTypeUpd.FormattingEnabled = true;
            this.cboApptTypeUpd.Location = new System.Drawing.Point(157, 208);
            this.cboApptTypeUpd.Name = "cboApptTypeUpd";
            this.cboApptTypeUpd.Size = new System.Drawing.Size(200, 21);
            this.cboApptTypeUpd.TabIndex = 57;
            this.cboApptTypeUpd.SelectedIndexChanged += new System.EventHandler(this.cboApptTypeUpd_SelectedIndexChanged);
            // 
            // apptIdTxtUpd
            // 
            this.apptIdTxtUpd.Enabled = false;
            this.apptIdTxtUpd.Location = new System.Drawing.Point(157, 77);
            this.apptIdTxtUpd.Name = "apptIdTxtUpd";
            this.apptIdTxtUpd.ReadOnly = true;
            this.apptIdTxtUpd.Size = new System.Drawing.Size(84, 20);
            this.apptIdTxtUpd.TabIndex = 56;
            this.apptIdTxtUpd.TabStop = false;
            // 
            // labelApptEnd
            // 
            this.labelApptEnd.AutoSize = true;
            this.labelApptEnd.Location = new System.Drawing.Point(110, 278);
            this.labelApptEnd.Name = "labelApptEnd";
            this.labelApptEnd.Size = new System.Drawing.Size(29, 13);
            this.labelApptEnd.TabIndex = 55;
            this.labelApptEnd.Text = "End:";
            // 
            // labelApptStart
            // 
            this.labelApptStart.AutoSize = true;
            this.labelApptStart.Location = new System.Drawing.Point(107, 245);
            this.labelApptStart.Name = "labelApptStart";
            this.labelApptStart.Size = new System.Drawing.Size(32, 13);
            this.labelApptStart.TabIndex = 54;
            this.labelApptStart.Text = "Start:";
            // 
            // labelApptType
            // 
            this.labelApptType.AutoSize = true;
            this.labelApptType.Location = new System.Drawing.Point(105, 216);
            this.labelApptType.Name = "labelApptType";
            this.labelApptType.Size = new System.Drawing.Size(34, 13);
            this.labelApptType.TabIndex = 53;
            this.labelApptType.Text = "Type:";
            // 
            // labelUsrId
            // 
            this.labelUsrId.AutoSize = true;
            this.labelUsrId.Location = new System.Drawing.Point(95, 147);
            this.labelUsrId.Name = "labelUsrId";
            this.labelUsrId.Size = new System.Drawing.Size(44, 13);
            this.labelUsrId.TabIndex = 52;
            this.labelUsrId.Text = "User Id:";
            // 
            // labelApptId
            // 
            this.labelApptId.AutoSize = true;
            this.labelApptId.Location = new System.Drawing.Point(58, 80);
            this.labelApptId.Name = "labelApptId";
            this.labelApptId.Size = new System.Drawing.Size(81, 13);
            this.labelApptId.TabIndex = 51;
            this.labelApptId.Text = "Appointment Id:";
            // 
            // AppointmentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 420);
            this.Controls.Add(this.cboUsrIdUpd);
            this.Controls.Add(this.cusNameTxtUpd);
            this.Controls.Add(this.cboCusIdUpd);
            this.Controls.Add(this.labelCusId);
            this.Controls.Add(this.labelCus);
            this.Controls.Add(this.dtpEndUpd);
            this.Controls.Add(this.dtpStartUpd);
            this.Controls.Add(this.cboApptTypeUpd);
            this.Controls.Add(this.apptIdTxtUpd);
            this.Controls.Add(this.labelApptEnd);
            this.Controls.Add(this.labelApptStart);
            this.Controls.Add(this.labelApptType);
            this.Controls.Add(this.labelUsrId);
            this.Controls.Add(this.labelApptId);
            this.Controls.Add(this.cancelApptUpdBtn);
            this.Controls.Add(this.saveApptUpdBtn);
            this.Controls.Add(this.labelUpdAppt);
            this.Name = "AppointmentUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelApptUpdBtn;
        private System.Windows.Forms.Button saveApptUpdBtn;
        private System.Windows.Forms.Label labelUpdAppt;
        private System.Windows.Forms.ComboBox cboUsrIdUpd;
        private System.Windows.Forms.TextBox cusNameTxtUpd;
        private System.Windows.Forms.ComboBox cboCusIdUpd;
        private System.Windows.Forms.Label labelCusId;
        private System.Windows.Forms.Label labelCus;
        private System.Windows.Forms.DateTimePicker dtpEndUpd;
        private System.Windows.Forms.DateTimePicker dtpStartUpd;
        private System.Windows.Forms.ComboBox cboApptTypeUpd;
        private System.Windows.Forms.TextBox apptIdTxtUpd;
        private System.Windows.Forms.Label labelApptEnd;
        private System.Windows.Forms.Label labelApptStart;
        private System.Windows.Forms.Label labelApptType;
        private System.Windows.Forms.Label labelUsrId;
        private System.Windows.Forms.Label labelApptId;
    }
}