
namespace AppointmentSchedulingApplication.Views
{
    partial class CustomerAdd
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
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label customerNameLabel;
            this.cancelNewCustBtn = new System.Windows.Forms.Button();
            this.saveNewCustBtn = new System.Windows.Forms.Button();
            this.countryTxt = new System.Windows.Forms.TextBox();
            this.postalCodeTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.customerIdTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.labelNewCust = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            countryLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(79, 242);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 64;
            countryLabel.Text = "Country:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(58, 209);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 62;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(98, 176);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 60;
            cityLabel.Text = "City:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(84, 275);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 58;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(77, 143);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 56;
            addressLabel.Text = "Address:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(59, 77);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(66, 13);
            customerIdLabel.TabIndex = 54;
            customerIdLabel.Text = "Customer Id:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLabel.Location = new System.Drawing.Point(40, 110);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 53;
            customerNameLabel.Text = "Customer Name:";
            // 
            // cancelNewCustBtn
            // 
            this.cancelNewCustBtn.Location = new System.Drawing.Point(334, 341);
            this.cancelNewCustBtn.Name = "cancelNewCustBtn";
            this.cancelNewCustBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelNewCustBtn.TabIndex = 67;
            this.cancelNewCustBtn.TabStop = false;
            this.cancelNewCustBtn.Text = "Cancel";
            this.cancelNewCustBtn.UseVisualStyleBackColor = true;
            this.cancelNewCustBtn.Click += new System.EventHandler(this.cancelNewCustBtn_Click);
            // 
            // saveNewCustBtn
            // 
            this.saveNewCustBtn.Location = new System.Drawing.Point(253, 341);
            this.saveNewCustBtn.Name = "saveNewCustBtn";
            this.saveNewCustBtn.Size = new System.Drawing.Size(75, 33);
            this.saveNewCustBtn.TabIndex = 66;
            this.saveNewCustBtn.TabStop = false;
            this.saveNewCustBtn.Text = "Save";
            this.saveNewCustBtn.UseVisualStyleBackColor = true;
            this.saveNewCustBtn.Click += new System.EventHandler(this.saveNewCustBtn_Click);
            // 
            // countryTxt
            // 
            this.countryTxt.Location = new System.Drawing.Point(138, 242);
            this.countryTxt.Name = "countryTxt";
            this.countryTxt.Size = new System.Drawing.Size(228, 20);
            this.countryTxt.TabIndex = 4;
            this.countryTxt.TextChanged += new System.EventHandler(this.countryTxt_TextChanged);
            // 
            // postalCodeTxt
            // 
            this.postalCodeTxt.Location = new System.Drawing.Point(138, 209);
            this.postalCodeTxt.Name = "postalCodeTxt";
            this.postalCodeTxt.Size = new System.Drawing.Size(228, 20);
            this.postalCodeTxt.TabIndex = 3;
            this.postalCodeTxt.TextChanged += new System.EventHandler(this.postalCodeTxt_TextChanged);
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(138, 176);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(228, 20);
            this.cityTxt.TabIndex = 2;
            this.cityTxt.TextChanged += new System.EventHandler(this.cityTxt_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(139, 274);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(101, 20);
            this.phoneTxt.TabIndex = 5;
            this.phoneTxt.Text = "XXX-XXXX";
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(138, 143);
            this.addressTxt.MaxLength = 50;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(228, 20);
            this.addressTxt.TabIndex = 1;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // customerIdTxt
            // 
            this.customerIdTxt.Enabled = false;
            this.customerIdTxt.Location = new System.Drawing.Point(139, 76);
            this.customerIdTxt.Name = "customerIdTxt";
            this.customerIdTxt.ReadOnly = true;
            this.customerIdTxt.Size = new System.Drawing.Size(101, 20);
            this.customerIdTxt.TabIndex = 52;
            this.customerIdTxt.TabStop = false;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(138, 110);
            this.customerNameTxt.MaxLength = 45;
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(228, 20);
            this.customerNameTxt.TabIndex = 0;
            this.customerNameTxt.TextChanged += new System.EventHandler(this.customerNameTxt_TextChanged);
            // 
            // labelNewCust
            // 
            this.labelNewCust.AutoSize = true;
            this.labelNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCust.Location = new System.Drawing.Point(17, 15);
            this.labelNewCust.Name = "labelNewCust";
            this.labelNewCust.Size = new System.Drawing.Size(76, 13);
            this.labelNewCust.TabIndex = 51;
            this.labelNewCust.Text = "New Customer";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(246, 272);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(120, 23);
            this.btnValidate.TabIndex = 68;
            this.btnValidate.Text = "Validate Phone";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 386);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cancelNewCustBtn);
            this.Controls.Add(this.saveNewCustBtn);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTxt);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTxt);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdTxt);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.labelNewCust);
            this.Name = "CustomerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelNewCustBtn;
        private System.Windows.Forms.Button saveNewCustBtn;
        private System.Windows.Forms.TextBox countryTxt;
        private System.Windows.Forms.TextBox postalCodeTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox customerIdTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label labelNewCust;
        private System.Windows.Forms.Button btnValidate;
    }
}