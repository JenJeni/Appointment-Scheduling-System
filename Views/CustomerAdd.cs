using AppointmentSchedulingApplication.DataModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class CustomerAdd : Form
    {
        Dashboard dash = new Dashboard();

        bool _addName = false;

        bool _addAddress = false;

        bool _addCity = false;

        bool _addCountry = false;

        bool _addZip = false;

        bool _addPhone = false;


        public CustomerAdd()
        {
            InitializeComponent();

            saveNewCustBtn.Enabled = false;
        }

        private bool canBSaved()
        {
            if ((_addName == true) &&

                (_addAddress == true) &&

                (_addCity == true) &&

                (_addCountry == true) &&

                (_addZip == true) &&

                (_addPhone == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerNameTxt.Text))
            {
                _addName = false;

                MessageBox.Show("Please enter a customer name.");

                return;
            }

            _addName = true;

            saveNewCustBtn.Enabled = canBSaved();
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text))
            {
                _addAddress = false;

                MessageBox.Show("Please enter a valid address.");

                return;
            }

            _addAddress = true;

            saveNewCustBtn.Enabled = canBSaved();
        }

        private void cityTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cityTxt.Text))
            {
                _addCity = false;

                MessageBox.Show("Please enter a valid city name.");

                return;
            }

            _addCity = true;

            saveNewCustBtn.Enabled = canBSaved();
        }

        private void postalCodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postalCodeTxt.Text) || (!Int32.TryParse(postalCodeTxt.Text, out _)))
            {
                _addZip = false;

                MessageBox.Show("Please enter a valid postal code.");

                return;
            }

            _addZip = true;

            saveNewCustBtn.Enabled = canBSaved();
        }

        private void countryTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countryTxt.Text))
            {
                _addCountry = false;

                MessageBox.Show("Please enter a valid country name.");

                return;
            }

            _addCountry = true;

            saveNewCustBtn.Enabled = canBSaved();
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phoneTxt.Text))
            {
                _addPhone = false;

                MessageBox.Show("Please enter a valid phone number.");

                return;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string strReg = @"^[0-9]{3}-[0-9]{4}$";

            Regex R = new Regex(strReg);

            if (R.IsMatch(phoneTxt.Text))
            {
                _addPhone = true;

                MessageBox.Show("Validation successful.");

                saveNewCustBtn.Enabled = canBSaved();
            }
            else
            {
                _addPhone = false;

                MessageBox.Show("Please enter a valid phone number.");
            }
        }

        private void saveNewCustBtn_Click(object sender, EventArgs e)
        {
            string name = customerNameTxt.Text;

            string adr = addressTxt.Text;

            string city = cityTxt.Text;

            string postal = postalCodeTxt.Text;

            string country = countryTxt.Text;

            string phoneNum = phoneTxt.Text;


            Customer c = new Customer(name, adr, city, postal, country, phoneNum);

            Customer.InsertCustomer(c);

            saveNewCustBtn.Enabled = canBSaved();

            Customer.DisplayCustomer();

            dash.Show();

            this.Close(); 
        }

        private void cancelNewCustBtn_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        }
    }
}
