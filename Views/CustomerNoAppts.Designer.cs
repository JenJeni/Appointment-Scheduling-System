
namespace AppointmentSchedulingApplication.Views
{
    partial class CustomerNoAppts
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
            this.labelCustCount = new System.Windows.Forms.Label();
            this.dgvCusCount = new System.Windows.Forms.DataGridView();
            this.btnExitCusCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustCount
            // 
            this.labelCustCount.AutoSize = true;
            this.labelCustCount.Location = new System.Drawing.Point(13, 13);
            this.labelCustCount.Name = "labelCustCount";
            this.labelCustCount.Size = new System.Drawing.Size(210, 13);
            this.labelCustCount.TabIndex = 0;
            this.labelCustCount.Text = "Active Customers Without An Appointment:";
            // 
            // dgvCusCount
            // 
            this.dgvCusCount.AllowUserToAddRows = false;
            this.dgvCusCount.AllowUserToDeleteRows = false;
            this.dgvCusCount.AllowUserToResizeColumns = false;
            this.dgvCusCount.AllowUserToResizeRows = false;
            this.dgvCusCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCusCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusCount.Location = new System.Drawing.Point(13, 61);
            this.dgvCusCount.Name = "dgvCusCount";
            this.dgvCusCount.ReadOnly = true;
            this.dgvCusCount.RowHeadersVisible = false;
            this.dgvCusCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCusCount.Size = new System.Drawing.Size(307, 150);
            this.dgvCusCount.TabIndex = 1;
            // 
            // btnExitCusCount
            // 
            this.btnExitCusCount.Location = new System.Drawing.Point(245, 228);
            this.btnExitCusCount.Name = "btnExitCusCount";
            this.btnExitCusCount.Size = new System.Drawing.Size(75, 30);
            this.btnExitCusCount.TabIndex = 2;
            this.btnExitCusCount.Text = "Exit";
            this.btnExitCusCount.UseVisualStyleBackColor = true;
            this.btnExitCusCount.Click += new System.EventHandler(this.btnExitCusCount_Click);
            // 
            // CustomerCountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 274);
            this.Controls.Add(this.btnExitCusCount);
            this.Controls.Add(this.dgvCusCount);
            this.Controls.Add(this.labelCustCount);
            this.Name = "CustomerCountReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustCount;
        private System.Windows.Forms.DataGridView dgvCusCount;
        private System.Windows.Forms.Button btnExitCusCount;
    }
}