
namespace AppointmentSchedulingApplication.Views
{
    partial class Login
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
            this.labelPwd = new System.Windows.Forms.Label();
            this.labelUsrName = new System.Windows.Forms.Label();
            this.labelLoginIntro = new System.Windows.Forms.Label();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.usrNameTxt = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(55, 134);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(53, 13);
            this.labelPwd.TabIndex = 13;
            this.labelPwd.Text = "Password";
            // 
            // labelUsrName
            // 
            this.labelUsrName.AutoSize = true;
            this.labelUsrName.Location = new System.Drawing.Point(55, 104);
            this.labelUsrName.Name = "labelUsrName";
            this.labelUsrName.Size = new System.Drawing.Size(55, 13);
            this.labelUsrName.TabIndex = 12;
            this.labelUsrName.Text = "Username";
            // 
            // labelLoginIntro
            // 
            this.labelLoginIntro.AutoSize = true;
            this.labelLoginIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginIntro.Location = new System.Drawing.Point(119, 30);
            this.labelLoginIntro.Name = "labelLoginIntro";
            this.labelLoginIntro.Size = new System.Drawing.Size(171, 20);
            this.labelLoginIntro.TabIndex = 11;
            this.labelLoginIntro.Text = "Login To Your Account";
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(135, 131);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(205, 20);
            this.pwdTxt.TabIndex = 10;
            this.pwdTxt.UseSystemPasswordChar = true;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // usrNameTxt
            // 
            this.usrNameTxt.Location = new System.Drawing.Point(135, 101);
            this.usrNameTxt.Name = "usrNameTxt";
            this.usrNameTxt.Size = new System.Drawing.Size(205, 20);
            this.usrNameTxt.TabIndex = 9;
            this.usrNameTxt.TextChanged += new System.EventHandler(this.usrNameTxt_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(234, 194);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 33);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(110, 194);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(107, 33);
            this.signInBtn.TabIndex = 7;
            this.signInBtn.TabStop = false;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 289);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUsrName);
            this.Controls.Add(this.labelLoginIntro);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.usrNameTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signInBtn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Label labelUsrName;
        private System.Windows.Forms.Label labelLoginIntro;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.TextBox usrNameTxt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button signInBtn;
    }
}