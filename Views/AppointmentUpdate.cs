using AppointmentSchedulingApplication.DataModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class AppointmentUpdate : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        MySqlConnection sConn = new MySqlConnection(cs);

        Dashboard dash = new Dashboard();

        private int myIndex;

        private DataTable myDt;

        bool _updCusId = false;
              
        bool _updUsrId = false;
              
        bool _updCusName = false;
              
        bool _updType = false;
              
        bool _updStart = false;
              
        bool _updEnd = false;

        public AppointmentUpdate(int idx, DataTable dt)
        {
            myIndex = idx;

            myDt = dt;

            InitializeComponent();

            FillCustomerIdCbo();

            FillUsrIdCbo();

            FillTypeCbo();

            int aId = (int)myDt.Rows[myIndex]["Appointment ID"];

            int cId = (int)dt.Rows[idx]["Customer ID"];

            int uId = (int)dt.Rows[idx]["User ID"];

            string apptType = (string)dt.Rows[idx]["Type"];

            DateTime startT = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["Start"], TimeZoneInfo.Local);

            DateTime endT = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["End"], TimeZoneInfo.Local);

            apptIdTxtUpd.Text = aId.ToString();

            cboCusIdUpd.SelectedItem = cId.ToString();

            cboUsrIdUpd.SelectedItem = uId.ToString();

            cboApptTypeUpd.SelectedItem = apptType.ToString();

            dtpStartUpd.Value = (DateTime)startT;

            dtpEndUpd.Value = (DateTime)endT;

            saveApptUpdBtn.Enabled = false;
        }

        #region Fill Comboboxes
        private void FillCustomerIdCbo()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string cusQry = "SELECT * FROM customer";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string cId = sdr.GetString("customerId");

                    cboCusIdUpd.Items.Add(cId);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve customer Id. \n");
            }
            finally
            {
                sConn.Close();
            }
        }

        private void FillUsrIdCbo()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string cusQry = "SELECT * FROM user";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string uId = sdr.GetString("userId");

                    cboUsrIdUpd.Items.Add(uId);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve user Id. \n");
            }
            finally
            {
                sConn.Close();
            }
        }

        private void FillTypeCbo()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string cusQry = "SELECT DISTINCT type FROM appointment";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    //var apptTypes = new List<string>();

                    //apptTypes.Add("Presentation");

                    //apptTypes.Add("Scrum");

                    //apptTypes.Add("Risk Analysis");

                    //apptTypes.Add("Stakeholder Meeting");

                    //apptTypes.Add("Office Party");

                    ////Used lambda to alphabetize and make expression more understandable
                    //apptTypes = apptTypes.OrderBy(type => type).ToList();

                    //cboApptTypeUpd.DataSource = apptTypes;

                    string apType = sdr.GetString("type");

                    cboApptTypeUpd.Items.Add(apType);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve type. \n");
            }
            finally
            {
                sConn.Close();
            }
        }
        #endregion

        #region Overlap Conditions
        private bool ApptOverlap()
        {
            DateTime proposedStartT = dtpStartUpd.Value;

            DateTime proposedEndT = dtpEndUpd.Value;

            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string checkOver = "SELECT * FROM appointment WHERE appointmentId = '"+apptIdTxtUpd.Text+"'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(checkOver, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(myDt);

                if (myDt.Rows.Count > 0)
                {
                    for (int i = 0; i < myDt.Rows.Count; i++)
                    {
                        DateTime apptStartMod = Convert.ToDateTime(myDt.Rows[i]["start"]);

                        DateTime apptEndMod = Convert.ToDateTime(myDt.Rows[i]["end"]);

                        if (proposedStartT >= apptStartMod && proposedStartT < apptEndMod)
                        {
                            return true;
                        }
                        if (proposedEndT > apptStartMod && proposedEndT <= apptEndMod)
                        {
                            return true;
                        }
                        if (proposedStartT <= apptStartMod && proposedEndT >= apptEndMod)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            return false;
        }
        #endregion

        private bool canBSaved()
        {
            if ((_updCusId == true) &&

                (_updUsrId == true) &&

                (_updCusName == true) &&

                (_updType == true) &&

                (_updStart == true) &&

                (_updEnd == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cboCusIdUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCusIdUpd.Text == "")
            {
                _updCusId = false;

                MessageBox.Show("Please select a customer Id.");

                return;
            }

            try
            {
                string cusQry = "SELECT * FROM customer WHERE customerId = '" + cboCusIdUpd.Text + "'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string cId = sdr.GetInt32("customerId").ToString(); 

                    string cName = sdr.GetString("customerName");

                    cboCusIdUpd.Text = cId; 

                    cusNameTxtUpd.Text = cName;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve customer name. \n");
            }
            finally
            {
                sConn.Close();
            }

            _updCusId = true;

            saveApptUpdBtn.Enabled = canBSaved();
        }

        private void cboUsrIdUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsrIdUpd.Text == "")
            {
                _updUsrId = false;

                MessageBox.Show("Please select a user Id.");

                return;
            }

            try
            {
                string usrQry = "SELECT * FROM user WHERE userId = '" + cboUsrIdUpd.Text + "'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(usrQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string uId = sdr.GetInt32("userId").ToString(); 

                    cboUsrIdUpd.Text = uId; 
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve user Id. \n");
            }
            finally
            {
                sConn.Close();
            }

            _updUsrId = true;

            saveApptUpdBtn.Enabled = canBSaved();
        }

        private void cusNameTxtUpd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cusNameTxtUpd.Text))
            {
                _updCusName = false;

                MessageBox.Show("Please select a customer Id.");

                return;
            }

            _updCusName = true;

            saveApptUpdBtn.Enabled = canBSaved();
        }

        private void cboApptTypeUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboApptTypeUpd.Text == "")
            {
                _updType = false;

                MessageBox.Show("Please select a type.");

                return;
            }

            try
            {
                string getType = "SELECT * FROM appointment WHERE type = '" + cboApptTypeUpd.Text + "'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(getType, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string p = sdr.GetString("type");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            _updType = true;

            saveApptUpdBtn.Enabled = canBSaved();                        
        }

        private void dtpStartUpd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartUpd.Checked != true)
            {
                _updStart = false;

                MessageBox.Show("Please select a start date and time.");

                return;
            }

            _updStart = true;

            saveApptUpdBtn.Enabled = canBSaved();
        }

        private void dtpEndUpd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndUpd.Checked != true)
            {
                _updEnd = false;

                MessageBox.Show("Please select an end date and time.");

                return;
            }

            _updEnd = true;

            saveApptUpdBtn.Enabled = canBSaved();
        }

        private void saveApptUpdBtn_Click(object sender, EventArgs e)
        {
            //Assign variables to txtbx and cbo
            int apId = Convert.ToInt32(apptIdTxtUpd.Text);

            int cId = Int32.Parse(cboCusIdUpd.SelectedItem.ToString());

            int usrId = Int32.Parse(cboUsrIdUpd.SelectedItem.ToString());

            string cusName = cusNameTxtUpd.Text;

            string aType = cboApptTypeUpd.SelectedItem.ToString();

            DateTime modifyStartT = dtpStartUpd.Value;

            DateTime modifyEndT = dtpEndUpd.Value;

            DateTime selStart = TimeZoneInfo.ConvertTimeToUtc(dtpStartUpd.Value);

            DateTime selEnd = TimeZoneInfo.ConvertTimeToUtc(dtpEndUpd.Value);


            //Check business hours and dates
            try
            {
                DateTime now = DateTime.Now;

                TimeSpan businessStartT = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;

                TimeSpan businessEndT = new DateTime(now.Year, now.Month, now.Day, 20, 0, 0).TimeOfDay;

                if ((modifyStartT.TimeOfDay < businessStartT) ||
                    (modifyStartT.TimeOfDay > businessEndT) ||
                    (modifyEndT.TimeOfDay < businessStartT) ||
                    (modifyEndT.TimeOfDay > businessEndT))
                {
                    MessageBox.Show("Start and end times conflict business hours. \n Please select another time during normal business hours: 7 AM - 7 PM");

                    return;
                }
                if (modifyStartT.Date > modifyEndT.Date)
                {
                    MessageBox.Show("End date cannot be earlier than start date. \n Please select a different date range.");

                    return;
                }
                else
                {
                    MessageBox.Show("Updated appointment time and date is within normal business hours.");
                }
            }
            catch (ArgumentOutOfRangeException ar)
            {
                MessageBox.Show(ar.Message, "Check business start and end date times. \n");
            }

            //Check appointment overlap
            if (ApptOverlap())
            {
                MessageBox.Show("Updated appointment times overlap with another appointment.");

                return;
            }

            Appointment appt = new Appointment(apId, cId, usrId, cusName, aType, selStart, selEnd);

            Appointment.UpdateAppt(appt);

            saveApptUpdBtn.Enabled = canBSaved();

            Appointment.DisplayAppt();

            dash.Show();

            this.Close();
        }

        private void cancelApptUpdBtn_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        }
    }
}
