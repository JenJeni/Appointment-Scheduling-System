using AppointmentSchedulingApplication.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.DataModels
{
    public class Customer
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public int AddressId { get; set; }

        public int CityId { get; set; }

        public int CountryId { get; set; }

        public static int CurrCustomerIdx { get; set; }


        #region Constructors
        public Customer() { }

        public Customer(int cId, string name, string adr, string c, string postal, string ctry, string phoneNum) 
        {
            CustomerId = cId;

            CustomerName = name;

            Address = adr;

            City = c;

            PostalCode = postal;

            Country = ctry;

            Phone = phoneNum;
        }

        public Customer(string name, string adr, string c, string postal, string ctry, string phoneNum)
        {
            CustomerName = name;

            Address = adr;

            City = c;

            PostalCode = postal;

            Country = ctry;

            Phone = phoneNum;
        }
        #endregion

        #region Display
        public static DataTable DisplayCustomer()
        {
            DataTable dtCustomer = new DataTable();

            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                const string selCustomer = "SELECT customerId AS 'Customer ID', customerName AS 'Name', address AS 'Address', city AS 'City', postalCode AS 'Postal Code', country AS 'Country', phone AS 'Phone', customer.addressId, address.cityId, city.countryId FROM country, city, address, customer WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND country.countryId = city.countryId";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(selCustomer, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(dtCustomer);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            return dtCustomer;
        }
        #endregion

        #region Insert        
        public static void InsertCustomer(Customer c)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string newCountry = "INSERT INTO client_schedule.country VALUES (NULL, @Country, NOW(), 'test', NOW(), 'test');";

                string newCity = "INSERT INTO city VALUES (NULL, @City, @CountryId, NOW(), 'test', NOW(), 'test');";

                string newAddress = "INSERT INTO address VALUES (NULL, @Address, 'not needed', @CityId , @PostalCode, @Phone, NOW(), 'test', NOW(), 'test');";

                string newCust = "INSERT INTO customer VALUES (NULL, @CustomerName, @AddressId, 1, NOW(), 'test', NOW(), 'test');";


                sConn.Open();

                //Country
                MySqlCommand countryCmd = new MySqlCommand(newCountry, sConn);

                countryCmd.Parameters.AddWithValue("@Country", c.Country);

                countryCmd.ExecuteNonQuery();

                c.CountryId = (int)countryCmd.LastInsertedId;


                //City
                MySqlCommand cityCmd = new MySqlCommand(newCity, sConn);

                cityCmd.Parameters.AddWithValue("@City", c.City);

                cityCmd.Parameters.AddWithValue("@CountryId", c.CountryId);

                cityCmd.ExecuteNonQuery();

                c.CityId = (int)cityCmd.LastInsertedId;


                //Address
                MySqlCommand addressCmd = new MySqlCommand(newAddress, sConn);

                addressCmd.Parameters.AddWithValue("@Address", c.Address);

                addressCmd.Parameters.AddWithValue("@CityId", c.CityId);

                addressCmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);

                addressCmd.Parameters.AddWithValue("@Phone", c.Phone);

                addressCmd.ExecuteNonQuery();

                c.AddressId = (int)addressCmd.LastInsertedId;


                //Customer
                MySqlCommand customerCmd = new MySqlCommand(newCust, sConn);

                customerCmd.Parameters.AddWithValue("@CustomerName", c.CustomerName);

                customerCmd.Parameters.AddWithValue("@AddressId", c.AddressId);

                customerCmd.ExecuteNonQuery();

                MessageBox.Show("Added succesfully.");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }
        }
        #endregion

        #region Update
        public static void UpdateCustomer(Customer c)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string updateCus = "UPDATE customer SET customerName = @CustomerName WHERE customerId = @CustomerId";

                string updateAdr = "UPDATE address SET address = @Address, postalCode = @PostalCode, phone = @Phone WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @CustomerId)";

                string updateCity = "UPDATE city SET city = @City WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @CustomerId))";

                string updateCtry = "UPDATE country SET country = @Country WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @CustomerId)))";


                sConn.Open();

                //Country
                MySqlCommand cmd1 = new MySqlCommand(updateCtry, sConn);

                cmd1.Parameters.AddWithValue("@Country", c.Country);

                cmd1.Parameters.AddWithValue("@customerId", c.CustomerId);

                cmd1.ExecuteNonQuery();


                //City
                MySqlCommand cmd2 = new MySqlCommand(updateCity, sConn);

                cmd2.Parameters.AddWithValue("@City", c.City);

                cmd2.Parameters.AddWithValue("@customerId", c.CustomerId);

                cmd2.ExecuteNonQuery();


                //Address
                MySqlCommand cmd3 = new MySqlCommand(updateAdr, sConn);

                cmd3.Parameters.AddWithValue("@Address", c.Address);

                cmd3.Parameters.AddWithValue("@CityId", c.CityId);

                cmd3.Parameters.AddWithValue("@PostalCode", c.PostalCode);

                cmd3.Parameters.AddWithValue("@Phone", c.Phone);

                cmd3.Parameters.AddWithValue("@customerId", c.CustomerId);

                cmd3.ExecuteNonQuery();



                //Customer
                MySqlCommand cmd4 = new MySqlCommand(updateCus, sConn);

                cmd4.Parameters.AddWithValue("@CustomerName", c.CustomerName);

                cmd4.Parameters.AddWithValue("@CustomerId", c.CustomerId);

                cmd4.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }
        }
        #endregion

        #region Delete
        public static bool DeleteCustomer(int cId, int aId, int ctyId, int ctryId)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string delCust = "DELETE FROM appointment WHERE customerId = @CustomerId";

                string delCust1 = "DELETE FROM customer WHERE customerId = @CustomerId";

                string delAdr = "DELETE FROM address WHERE addressId = @AddressId";

                string delCity = "DELETE FROM city WHERE cityId = @CityId";

                string delCountry = "DELETE FROM country WHERE countryId = @CountryId";


                sConn.Open();

                //Appointment-Customer
                MySqlCommand apCmd = new MySqlCommand(delCust, sConn);

                apCmd.Parameters.AddWithValue("@CustomerId", cId);

                apCmd.ExecuteNonQuery();

                //Customer
                MySqlCommand cmd = new MySqlCommand(delCust1, sConn);

                cmd.Parameters.AddWithValue("@CustomerId", cId);

                cmd.ExecuteNonQuery();

                //Address
                MySqlCommand cmd2 = new MySqlCommand(delAdr, sConn);

                cmd2.Parameters.AddWithValue("@AddressId", aId);

                cmd2.ExecuteNonQuery();


                //City
                MySqlCommand cmd3 = new MySqlCommand(delCity, sConn);

                cmd3.Parameters.AddWithValue("@cityId", ctyId);

                cmd3.ExecuteNonQuery();


                //Country
                MySqlCommand cmd4 = new MySqlCommand(delCountry, sConn);

                cmd4.Parameters.AddWithValue("@countryId", ctryId);

                cmd4.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Customer couldn't be deleted. \n");

                return false;
            }
            finally
            {
                sConn.Close();
            }

            return true;
        }
        #endregion
    }
}
