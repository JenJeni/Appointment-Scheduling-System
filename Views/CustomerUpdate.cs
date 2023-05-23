using AppointmentSchedulingApplication.DataModels;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class CustomerUpdate : Form
    {
        private int myIndex;

        private DataTable myDt;        

        Dashboard dash = new Dashboard();

        bool _updName = false;

        bool _updAddress = false;

        bool _updCity = false;

        bool _updCountry = false;

        bool _updZip = false;

        bool _updPhone = false;

        public CustomerUpdate(int index, DataTable dt)
        {
            myIndex = index;

            myDt = dt;

            InitializeComponent();

            int cId = (int)myDt.Rows[myIndex]["Customer ID"];

            string customerName = (string)dt.Rows[index]["Name"];           

            string addressName = (string)dt.Rows[index]["Address"];

            string cityName = (string)dt.Rows[index]["City"];

            string zipCode = (string)dt.Rows[index]["Postal Code"];

            string countryName = (string)dt.Rows[index]["Country"];

            string phoneNum = (string)dt.Rows[index]["Phone"];

            updCustIdTxt.Text = cId.ToString();

            updateCustNameTxt.Text = customerName;

            updateAddressTxt.Text = addressName;

            updateCityTxt.Text = cityName;

            updPostalCodeTxt.Text = zipCode;

            updCountryTxt.Text = countryName;

            updatePhoneTxt.Text = phoneNum;

            saveCustUpdateBtn.Enabled = false;

        }

        private bool canBSaved()
        {
            if ((_updName == true) &&

                (_updAddress == true) &&

                (_updCity == true) &&

                (_updCountry == true) &&

                (_updZip == true) &&

                (_updPhone == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void updateCustNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateCustNameTxt.Text))
            {
                _updName = false;

                MessageBox.Show("Please enter a customer name.");

                return;
            }

            _updName = true;

            saveCustUpdateBtn.Enabled = canBSaved();
        }

        private void updateAddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateAddressTxt.Text))
            {
                _updAddress = false;

                MessageBox.Show("Please enter a valid address.");

                return;
            }

            _updAddress = true;

            saveCustUpdateBtn.Enabled = canBSaved();
        }

        private void updateCityTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateCityTxt.Text))
            {
                _updCity = false;

                MessageBox.Show("Please enter a valid city name.");

                return;
            }

            _updCity = true;

            saveCustUpdateBtn.Enabled = canBSaved();
        }

        private void updPostalCodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(updPostalCodeTxt.Text) || (!Int32.TryParse(updPostalCodeTxt.Text, out _)))
            {
                _updZip = false;

                MessageBox.Show("Please enter a valid postal code.");

                return;
            }

            _updZip = true;

            saveCustUpdateBtn.Enabled = canBSaved();
        }

        private void updCountryTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updCountryTxt.Text))
            {
                _updCountry = false;

                MessageBox.Show("Please enter a valid country name.");

                return;
            }

            _updCountry = true;

            saveCustUpdateBtn.Enabled = canBSaved();
        }

        private void updatePhoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updatePhoneTxt.Text))
            {
                _updPhone = false;

                MessageBox.Show("Please enter a valid phone number.");

                return;
            }
        }

        private void btnValidatePhone_Click(object sender, EventArgs e)
        {
            string strReg = @"^[0-9]{3}-[0-9]{4}$";

            Regex R = new Regex(strReg);

            if (R.IsMatch(updatePhoneTxt.Text))
            {
                _updPhone = true;

                MessageBox.Show("Validation successful.");

                saveCustUpdateBtn.Enabled = canBSaved();
            }
            else
            {
                _updPhone = false;

                MessageBox.Show("Please enter a valid phone number.");
            }
        }

        private void saveCustUpdateBtn_Click(object sender, EventArgs e)
        {
            int cusId = Convert.ToInt32(updCustIdTxt.Text);

            string name = updateCustNameTxt.Text;

            string adr = updateAddressTxt.Text;

            string city = updateCityTxt.Text;

            string postal = updPostalCodeTxt.Text;

            string country = updCountryTxt.Text;

            string phoneNum = updatePhoneTxt.Text;


            Customer c = new Customer(cusId, name, adr, city, postal, country, phoneNum);

            Customer.UpdateCustomer(c);

            saveCustUpdateBtn.Enabled = canBSaved();

            Customer.DisplayCustomer();
                
            MessageBox.Show("Updated successfully!");

            dash.Show();

            this.Close();
        }

        private void cancelCustUpdateBtn_Click(object sender, EventArgs e)
        {           
            dash.Show();

            this.Close();
        }      
    }
}
