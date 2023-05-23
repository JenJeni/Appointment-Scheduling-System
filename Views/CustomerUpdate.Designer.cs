
namespace AppointmentSchedulingApplication.Views
{
    partial class CustomerUpdate
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
            this.cancelCustUpdateBtn = new System.Windows.Forms.Button();
            this.saveCustUpdateBtn = new System.Windows.Forms.Button();
            this.updCountryTxt = new System.Windows.Forms.TextBox();
            this.updPostalCodeTxt = new System.Windows.Forms.TextBox();
            this.updateCityTxt = new System.Windows.Forms.TextBox();
            this.updatePhoneTxt = new System.Windows.Forms.TextBox();
            this.updateAddressTxt = new System.Windows.Forms.TextBox();
            this.updCustIdTxt = new System.Windows.Forms.TextBox();
            this.updateCustNameTxt = new System.Windows.Forms.TextBox();
            this.labelUpdateCust = new System.Windows.Forms.Label();
            this.btnValidatePhone = new System.Windows.Forms.Button();
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
            countryLabel.Location = new System.Drawing.Point(83, 249);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 81;
            countryLabel.Text = "Country:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(63, 216);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 79;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(102, 183);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 77;
            cityLabel.Text = "City:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(88, 283);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 75;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(81, 150);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 73;
            addressLabel.Text = "Address:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(64, 84);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(66, 13);
            customerIdLabel.TabIndex = 71;
            customerIdLabel.Text = "Customer Id:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(45, 117);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 70;
            customerNameLabel.Text = "Customer Name:";
            // 
            // cancelCustUpdateBtn
            // 
            this.cancelCustUpdateBtn.Location = new System.Drawing.Point(333, 341);
            this.cancelCustUpdateBtn.Name = "cancelCustUpdateBtn";
            this.cancelCustUpdateBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelCustUpdateBtn.TabIndex = 84;
            this.cancelCustUpdateBtn.TabStop = false;
            this.cancelCustUpdateBtn.Text = "Cancel";
            this.cancelCustUpdateBtn.UseVisualStyleBackColor = true;
            this.cancelCustUpdateBtn.Click += new System.EventHandler(this.cancelCustUpdateBtn_Click);
            // 
            // saveCustUpdateBtn
            // 
            this.saveCustUpdateBtn.Location = new System.Drawing.Point(252, 341);
            this.saveCustUpdateBtn.Name = "saveCustUpdateBtn";
            this.saveCustUpdateBtn.Size = new System.Drawing.Size(75, 33);
            this.saveCustUpdateBtn.TabIndex = 83;
            this.saveCustUpdateBtn.TabStop = false;
            this.saveCustUpdateBtn.Text = "Save";
            this.saveCustUpdateBtn.UseVisualStyleBackColor = true;
            this.saveCustUpdateBtn.Click += new System.EventHandler(this.saveCustUpdateBtn_Click);
            // 
            // updCountryTxt
            // 
            this.updCountryTxt.Location = new System.Drawing.Point(147, 246);
            this.updCountryTxt.Name = "updCountryTxt";
            this.updCountryTxt.Size = new System.Drawing.Size(228, 20);
            this.updCountryTxt.TabIndex = 4;
            this.updCountryTxt.TextChanged += new System.EventHandler(this.updCountryTxt_TextChanged);
            // 
            // updPostalCodeTxt
            // 
            this.updPostalCodeTxt.Location = new System.Drawing.Point(147, 213);
            this.updPostalCodeTxt.Name = "updPostalCodeTxt";
            this.updPostalCodeTxt.Size = new System.Drawing.Size(228, 20);
            this.updPostalCodeTxt.TabIndex = 3;
            this.updPostalCodeTxt.TextChanged += new System.EventHandler(this.updPostalCodeTxt_TextChanged);
            // 
            // updateCityTxt
            // 
            this.updateCityTxt.Location = new System.Drawing.Point(147, 180);
            this.updateCityTxt.Name = "updateCityTxt";
            this.updateCityTxt.Size = new System.Drawing.Size(228, 20);
            this.updateCityTxt.TabIndex = 2;
            this.updateCityTxt.TextChanged += new System.EventHandler(this.updateCityTxt_TextChanged);
            // 
            // updatePhoneTxt
            // 
            this.updatePhoneTxt.Location = new System.Drawing.Point(147, 280);
            this.updatePhoneTxt.Name = "updatePhoneTxt";
            this.updatePhoneTxt.Size = new System.Drawing.Size(98, 20);
            this.updatePhoneTxt.TabIndex = 5;
            this.updatePhoneTxt.Text = "XXX-XXXX";
            this.updatePhoneTxt.TextChanged += new System.EventHandler(this.updatePhoneTxt_TextChanged);
            // 
            // updateAddressTxt
            // 
            this.updateAddressTxt.Location = new System.Drawing.Point(147, 147);
            this.updateAddressTxt.Name = "updateAddressTxt";
            this.updateAddressTxt.Size = new System.Drawing.Size(228, 20);
            this.updateAddressTxt.TabIndex = 1;
            this.updateAddressTxt.TextChanged += new System.EventHandler(this.updateAddressTxt_TextChanged);
            // 
            // updCustIdTxt
            // 
            this.updCustIdTxt.Enabled = false;
            this.updCustIdTxt.Location = new System.Drawing.Point(147, 81);
            this.updCustIdTxt.Name = "updCustIdTxt";
            this.updCustIdTxt.ReadOnly = true;
            this.updCustIdTxt.Size = new System.Drawing.Size(98, 20);
            this.updCustIdTxt.TabIndex = 69;
            this.updCustIdTxt.TabStop = false;
            // 
            // updateCustNameTxt
            // 
            this.updateCustNameTxt.Location = new System.Drawing.Point(147, 114);
            this.updateCustNameTxt.Name = "updateCustNameTxt";
            this.updateCustNameTxt.Size = new System.Drawing.Size(228, 20);
            this.updateCustNameTxt.TabIndex = 0;
            this.updateCustNameTxt.TextChanged += new System.EventHandler(this.updateCustNameTxt_TextChanged);
            // 
            // labelUpdateCust
            // 
            this.labelUpdateCust.AutoSize = true;
            this.labelUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateCust.Location = new System.Drawing.Point(23, 16);
            this.labelUpdateCust.Name = "labelUpdateCust";
            this.labelUpdateCust.Size = new System.Drawing.Size(89, 13);
            this.labelUpdateCust.TabIndex = 68;
            this.labelUpdateCust.Text = "Update Customer";
            // 
            // btnValidatePhone
            // 
            this.btnValidatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidatePhone.Location = new System.Drawing.Point(255, 279);
            this.btnValidatePhone.Name = "btnValidatePhone";
            this.btnValidatePhone.Size = new System.Drawing.Size(120, 23);
            this.btnValidatePhone.TabIndex = 85;
            this.btnValidatePhone.Text = "Validate Phone";
            this.btnValidatePhone.UseVisualStyleBackColor = true;
            this.btnValidatePhone.Click += new System.EventHandler(this.btnValidatePhone_Click);
            // 
            // CustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 386);
            this.Controls.Add(this.btnValidatePhone);
            this.Controls.Add(this.cancelCustUpdateBtn);
            this.Controls.Add(this.saveCustUpdateBtn);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.updCountryTxt);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.updPostalCodeTxt);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.updateCityTxt);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.updatePhoneTxt);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.updateAddressTxt);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.updCustIdTxt);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.updateCustNameTxt);
            this.Controls.Add(this.labelUpdateCust);
            this.Name = "CustomerUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelCustUpdateBtn;
        private System.Windows.Forms.Button saveCustUpdateBtn;
        private System.Windows.Forms.TextBox updCountryTxt;
        private System.Windows.Forms.TextBox updPostalCodeTxt;
        private System.Windows.Forms.TextBox updateCityTxt;
        private System.Windows.Forms.TextBox updatePhoneTxt;
        private System.Windows.Forms.TextBox updateAddressTxt;
        private System.Windows.Forms.TextBox updCustIdTxt;
        private System.Windows.Forms.TextBox updateCustNameTxt;
        private System.Windows.Forms.Label labelUpdateCust;
        private System.Windows.Forms.Button btnValidatePhone;
    }
}