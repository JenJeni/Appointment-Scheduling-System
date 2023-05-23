
namespace AppointmentSchedulingApplication.Views
{
    partial class ConsultantSchedule
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
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.usrDGV = new System.Windows.Forms.DataGridView();
            this.labelUsrSched = new System.Windows.Forms.Label();
            this.labelChooseUsr = new System.Windows.Forms.Label();
            this.btnExitUsrSchd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usrDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(572, 45);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(121, 21);
            this.cboUser.TabIndex = 0;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // usrDGV
            // 
            this.usrDGV.AllowUserToAddRows = false;
            this.usrDGV.AllowUserToDeleteRows = false;
            this.usrDGV.AllowUserToResizeColumns = false;
            this.usrDGV.AllowUserToResizeRows = false;
            this.usrDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usrDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrDGV.Location = new System.Drawing.Point(12, 72);
            this.usrDGV.Name = "usrDGV";
            this.usrDGV.ReadOnly = true;
            this.usrDGV.RowHeadersVisible = false;
            this.usrDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usrDGV.Size = new System.Drawing.Size(681, 150);
            this.usrDGV.TabIndex = 1;
            this.usrDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.usrDGV_CellFormatting);
            // 
            // labelUsrSched
            // 
            this.labelUsrSched.AutoSize = true;
            this.labelUsrSched.Location = new System.Drawing.Point(12, 9);
            this.labelUsrSched.Name = "labelUsrSched";
            this.labelUsrSched.Size = new System.Drawing.Size(140, 13);
            this.labelUsrSched.TabIndex = 2;
            this.labelUsrSched.Text = "Consultant Schedule Report";
            // 
            // labelChooseUsr
            // 
            this.labelChooseUsr.AutoSize = true;
            this.labelChooseUsr.Location = new System.Drawing.Point(432, 48);
            this.labelChooseUsr.Name = "labelChooseUsr";
            this.labelChooseUsr.Size = new System.Drawing.Size(134, 13);
            this.labelChooseUsr.TabIndex = 3;
            this.labelChooseUsr.Text = "Please select a consultant:";
            // 
            // btnExitUsrSchd
            // 
            this.btnExitUsrSchd.Location = new System.Drawing.Point(618, 242);
            this.btnExitUsrSchd.Name = "btnExitUsrSchd";
            this.btnExitUsrSchd.Size = new System.Drawing.Size(75, 33);
            this.btnExitUsrSchd.TabIndex = 4;
            this.btnExitUsrSchd.Text = "Exit";
            this.btnExitUsrSchd.UseVisualStyleBackColor = true;
            this.btnExitUsrSchd.Click += new System.EventHandler(this.btnExitUsrSchd_Click);
            // 
            // ConsultantSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 287);
            this.Controls.Add(this.btnExitUsrSchd);
            this.Controls.Add(this.labelChooseUsr);
            this.Controls.Add(this.labelUsrSched);
            this.Controls.Add(this.usrDGV);
            this.Controls.Add(this.cboUser);
            this.Name = "ConsultantSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.usrDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.DataGridView usrDGV;
        private System.Windows.Forms.Label labelUsrSched;
        private System.Windows.Forms.Label labelChooseUsr;
        private System.Windows.Forms.Button btnExitUsrSchd;
    }
}