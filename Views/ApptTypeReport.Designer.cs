
namespace AppointmentSchedulingApplication.Views
{
    partial class ApptTypeReport
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
            this.labelApptType = new System.Windows.Forms.Label();
            this.dgvApptTypes = new System.Windows.Forms.DataGridView();
            this.reportTxt = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApptTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelApptType
            // 
            this.labelApptType.AutoSize = true;
            this.labelApptType.Location = new System.Drawing.Point(13, 13);
            this.labelApptType.Name = "labelApptType";
            this.labelApptType.Size = new System.Drawing.Size(146, 13);
            this.labelApptType.TabIndex = 0;
            this.labelApptType.Text = "Appointment Types By Month";
            // 
            // dgvApptTypes
            // 
            this.dgvApptTypes.AllowUserToAddRows = false;
            this.dgvApptTypes.AllowUserToDeleteRows = false;
            this.dgvApptTypes.AllowUserToResizeColumns = false;
            this.dgvApptTypes.AllowUserToResizeRows = false;
            this.dgvApptTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApptTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApptTypes.Location = new System.Drawing.Point(16, 64);
            this.dgvApptTypes.Name = "dgvApptTypes";
            this.dgvApptTypes.ReadOnly = true;
            this.dgvApptTypes.RowHeadersVisible = false;
            this.dgvApptTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApptTypes.Size = new System.Drawing.Size(451, 150);
            this.dgvApptTypes.TabIndex = 1;
            this.dgvApptTypes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvApptTypes_DataBindingComplete);
            // 
            // reportTxt
            // 
            this.reportTxt.Location = new System.Drawing.Point(16, 235);
            this.reportTxt.Multiline = true;
            this.reportTxt.Name = "reportTxt";
            this.reportTxt.Size = new System.Drawing.Size(451, 150);
            this.reportTxt.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ApptTypeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportTxt);
            this.Controls.Add(this.dgvApptTypes);
            this.Controls.Add(this.labelApptType);
            this.Name = "ApptTypeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApptTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApptType;
        private System.Windows.Forms.DataGridView dgvApptTypes;
        private System.Windows.Forms.TextBox reportTxt;
        private System.Windows.Forms.Button btnExit;
    }
}