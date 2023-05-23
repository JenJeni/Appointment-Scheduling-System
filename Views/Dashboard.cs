using AppointmentSchedulingApplication.DataModels;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class Dashboard : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
       
        public Dashboard()
        {
            InitializeComponent();

            FormatDGV();
        }

        private void FormatDGV()
        {
            customerDGV.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            customerDGV.DefaultCellStyle.SelectionForeColor = Color.White;

            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            customerDGV.MultiSelect = false;


            apptDGV.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            apptDGV.DefaultCellStyle.SelectionForeColor = Color.White;

            apptDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            apptDGV.MultiSelect = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Customer
            customerDGV.DataSource = Customer.DisplayCustomer();

            customerDGV.Columns["Customer ID"].Visible = false;

            customerDGV.Columns["cityId"].Visible = false;

            customerDGV.Columns["addressId"].Visible = false;

            customerDGV.Columns["countryId"].Visible = false;

            //Appointment
            apptDGV.DataSource = Appointment.DisplayAppt();

            apptDGV.Columns["Appointment ID"].Visible = true;

            apptDGV.Columns["User ID"].Visible = true;

            apptDGV.Columns["Customer ID"].Visible = false;
        }

        private void apptDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            apptDGV.ClearSelection();
        }

        private void customerDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customerDGV.ClearSelection();
        }

        private void apptDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Display Utc time as Local time

            if (e.Value is DateTime)
            {
                DateTime dateVal = (DateTime)e.Value;

                switch (dateVal.Kind)
                {
                    case DateTimeKind.Local:

                        break;

                    case DateTimeKind.Unspecified:

                        e.Value = DateTime.SpecifyKind(dateVal, DateTimeKind.Utc).ToLocalTime();

                        break;

                    case DateTimeKind.Utc:

                        e.Value = dateVal.ToLocalTime();

                        break;
                }
            }
        }

        private void apptDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Appointment.CurrApptIdx = e.RowIndex;

                Appointment.CurrApptIdx = (int)apptDGV.Rows[Appointment.CurrApptIdx].Cells[0].Value;
            }
        }

        private void customerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                Customer.CurrCustomerIdx = e.RowIndex;

                Customer.CurrCustomerIdx = (int)customerDGV.Rows[Customer.CurrCustomerIdx].Cells[0].Value;
            }
        }

        #region Radio Buttons        
        private void rBtnCurrWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCurrWeek.Checked == true)
            {
                apptDGV.Refresh();

                GetCurrWeekAppts();
            }
        }

        private void rBtnCurrMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCurrMonth.Checked == true)
            {
                apptDGV.Refresh();

                GetCurrMonthAppts();
            }  
        }

        private void rBtnAllAppt_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAllAppt.Checked == true)
            {
                apptDGV.Refresh();

                GetAllAppts();
            }
        }
        #endregion

        #region Radio Button Handlers
        private void GetCurrWeekAppts()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string getWeekAp = "SELECT appointment.appointmentId AS 'Appointment ID', customer.customerId AS 'Customer ID', customer.customerName AS 'Name', user.userId AS 'User ID', appointment.type, appointment.start, appointment.end FROM appointment, customer, address, city, user WHERE customer.customerId = appointment.customerId AND appointment.userId = user.userId AND customer.addressId = address.addressId AND city.cityId = address.cityId AND YEARWEEK(start) = YEARWEEK(NOW());";
                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(getWeekAp, sConn);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataTable dtWeek = new DataTable();

                adap.Fill(dtWeek);

                apptDGV.DataSource = dtWeek;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            apptDGV.Update();

            apptDGV.Refresh();
        }

        private void GetCurrMonthAppts()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string getMonthAp = "SELECT appointment.appointmentId AS 'Appointment ID', customer.customerId AS 'Customer ID', customer.customerName AS 'Name', user.userId AS 'User ID', appointment.type, appointment.start, appointment.end FROM appointment, customer, address, city, user WHERE customer.customerId = appointment.customerId AND appointment.userId = user.userId AND customer.addressId = address.addressId AND city.cityId = address.cityId AND MONTH(start) = MONTH(NOW());";
                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(getMonthAp, sConn);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataTable dtMonth = new DataTable();

                adap.Fill(dtMonth);

                apptDGV.DataSource = dtMonth;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            apptDGV.Update();

            apptDGV.Refresh();
        }

        private void GetAllAppts()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string getAllAp = "SELECT appointment.appointmentId AS 'Appointment ID', customer.customerId AS 'Customer ID', customer.customerName AS 'Name', user.userId AS 'User ID', appointment.type, appointment.start, appointment.end FROM appointment, customer, address, city, user WHERE customer.customerId = appointment.customerId AND appointment.userId = user.userId AND customer.addressId = address.addressId AND city.cityId = address.cityId AND YEAR(start) <= YEAR(NOW());";
                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(getAllAp, sConn);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataTable dtAll = new DataTable();

                adap.Fill(dtAll);

                apptDGV.DataSource = dtAll;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            apptDGV.Update();

            apptDGV.Refresh();
        }
        #endregion
       
        #region Report Buttons
        private void btnMonthType_Click(object sender, EventArgs e)
        {
            ApptTypeReport typeReport = new ApptTypeReport();

            typeReport.Show();

            this.Hide();
        }

        private void btnUsrSched_Click(object sender, EventArgs e)
        {
            ConsultantSchedule scheduleReport = new ConsultantSchedule();

            scheduleReport.Show();

            this.Hide();
        }

        private void btnCustomerCount_Click(object sender, EventArgs e)
        {
            CustomerNoAppts customerCount = new CustomerNoAppts();

            customerCount.Show();

            this.Hide();
        }
        #endregion

        #region Customer
        private void newCustBtn_Click(object sender, EventArgs e)
        {
            CustomerAdd cusAddForm = new CustomerAdd();

            cusAddForm.Show();

            this.Hide();
        }

        private void updateCustBtn_Click(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer.");

                return;
            }

            DataTable dt = customerDGV.DataSource as DataTable;

            int index = customerDGV.CurrentCell.RowIndex;

            CustomerUpdate cusUpdForm = new CustomerUpdate(index, dt);

            cusUpdForm.Show();

            this.Hide();
        }

        private void delCustBtn_Click(object sender, EventArgs e)
        {
            if (customerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");

                return;
            }

            int cId = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[0].Value);

            int aId = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[7].Value);

            int ctyId = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[8].Value);

            int ctryId = Convert.ToInt32(customerDGV.SelectedRows[0].Cells[9].Value);

            Customer.DeleteCustomer(cId, aId, ctyId, ctryId);

            customerDGV.Update();

            customerDGV.Refresh();

            MessageBox.Show("Customer deleted.");

            customerDGV.DataSource = Customer.DisplayCustomer();
        } 
        #endregion

        #region Appointment
        private void newApptBtn_Click(object sender, EventArgs e)
        {
            AppointmentAdd addApptForm = new AppointmentAdd();

            addApptForm.Show();

            this.Hide();
        }

        private void updApptBtn_Click(object sender, EventArgs e)
        {
            if (apptDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment.");

                return;
            }

            DataTable dt = apptDGV.DataSource as DataTable;

            int idx = apptDGV.CurrentCell.RowIndex;

            AppointmentUpdate updApptForm = new AppointmentUpdate(idx, dt);

            updApptForm.Show();

            this.Hide();
        }

        private void delAppBtn_Click(object sender, EventArgs e)
        {
            if (apptDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment.");

                return;
            }

            int index = Convert.ToInt32(apptDGV.SelectedRows[0].Cells[0].Value);

            Appointment.DeleteAppt(index);

            apptDGV.Update();

            apptDGV.Refresh();

            MessageBox.Show("Appointment deleted.");

            apptDGV.DataSource = Appointment.DisplayAppt();
        } 
        #endregion

        private void exitDashBtn_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();

            loginWindow.Show();

            this.Close();
        }       
    }
}
