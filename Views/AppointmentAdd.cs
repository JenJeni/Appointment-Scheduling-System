using AppointmentSchedulingApplication.DataModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class AppointmentAdd : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        Dashboard dash = new Dashboard();

        DataTable myDt;

        bool _pickCusId = false;

        bool _pickUsrId = false;

        bool _pCusName = false;

        bool _pickType = false;

        bool _pickStart = false;

        bool _pickEnd = false;

        public AppointmentAdd()
        {
            InitializeComponent();

            FillCustomerIdCbo();

            FillUsrIdCbo();

            FillTypeCbo();

            myDt = new DataTable();

            saveNewApptBtn.Enabled = false;
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

                    cboCusId.Items.Add(cId);
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

                    cboUsrId.Items.Add(uId);
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
                string cusQry = "SELECT DISTINCT type FROM appointment;";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    var apTypes = new List<string>();

                    apTypes.Add("Presentation");

                    apTypes.Add("Scrum");

                    apTypes.Add("Risk Analysis");

                    apTypes.Add("Office Party");

                    //Used lambda to alphabetize types in combo box and make expression more understandable
                    apTypes = apTypes.OrderBy(type => type).ToList();

                    cboApptType.DataSource = apTypes;
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
            DateTime proposedStartT = dtpStart.Value;

            DateTime proposedEndT = dtpEnd.Value;
            
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string checkOver = "SELECT * FROM appointment a, user u WHERE a.userId = u.userId ";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(checkOver, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                myDt.Load(sdr);

                if (myDt.Rows.Count > 0)
                {
                    for (int i = 0; i < myDt.Rows.Count; i++)
                    {
                        DateTime apptStart = Convert.ToDateTime(myDt.Rows[i]["start"]);

                        DateTime apptEnd = Convert.ToDateTime(myDt.Rows[i]["end"]);

                        //Func<DateTime, DateTime, bool> testForOverlap = (x, y) => x == y;

                        if (proposedStartT >= apptStart && proposedStartT < apptEnd)
                        {
                            return true;
                        }
                        if (proposedEndT > apptStart && proposedEndT <= apptEnd)
                        {
                            return true;
                        }
                        if (proposedStartT <= apptStart && proposedEndT >= apptEnd)
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
            if ((_pickCusId == true) &&

                (_pickUsrId == true) &&

                (_pCusName == true) &&

                (_pickType == true) &&

                (_pickStart == true) &&

                (_pickEnd == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cboCusId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCusId.Text == " ")
            {
                _pickCusId = false;

                MessageBox.Show("Please select a customer Id.");

                return;
            }

            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {                
                string cusQry = "SELECT * FROM customer WHERE customerId = @customerId";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(cusQry, sConn);

                cmd.Parameters.AddWithValue("@customerId", cboCusId.SelectedItem.ToString());

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string cId = sdr.GetInt32("customerId").ToString(); 

                    string cName = sdr.GetString("customerName");

                    cboCusId.Text = cId; 

                    cusNameTxt.Text = cName;

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

            _pickCusId = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void cusNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cusNameTxt.Text))
            {
                _pCusName = false;

                MessageBox.Show("Please select a customer Id.");

                return;
            }

            _pCusName = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void cboUsrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsrId.Text == "")
            {
                _pickUsrId = false;

                MessageBox.Show("Please select a user Id.");

                return;
            }

            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string usrQry = "SELECT * FROM user WHERE userId = '" + cboUsrId.Text + "'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(usrQry, sConn);

                MySqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string uId = sdr.GetInt32("userId").ToString(); //convert int to string

                    cboUsrId.Text = uId; //assign column values to textbox

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

            _pickUsrId = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void cboApptType_Click(object sender, EventArgs e)
        {
            if (cboApptType.Text == "")
            {
                _pickType = false;

                MessageBox.Show("Please select a type.");

                return;
            }

            MySqlConnection sConn = new MySqlConnection(cs);
           
            try
            {
                string getType = "SELECT * FROM appointment WHERE type = '" + cboApptType.Text + "'";

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

            _pickType = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Checked != true)
            {
                _pickStart = false;

                MessageBox.Show("Please select a start date and time.");

                return;
            }

            _pickStart = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Checked != true)
            {
                _pickEnd = false;

                MessageBox.Show("Please select an end date and time.");

                return;
            }

            _pickEnd = true;

            saveNewApptBtn.Enabled = canBSaved();
        }

        private void saveNewApptBtn_Click(object sender, EventArgs e)
        {
            //Assign variables to txtbx and cbo
            int cId = Convert.ToInt32(cboCusId.SelectedItem.ToString());

            int usrId = Convert.ToInt32(cboUsrId.SelectedItem.ToString());

            string cusName = cusNameTxt.Text;

            string aType = cboApptType.SelectedItem.ToString();
            
            DateTime selectedStartT = dtpStart.Value;

            DateTime selectedEndT = dtpEnd.Value;

            DateTime selStart = TimeZoneInfo.ConvertTimeToUtc(dtpStart.Value);

            DateTime selEnd = TimeZoneInfo.ConvertTimeToUtc(dtpEnd.Value);

            //Check business hours
            try
            {
                DateTime now = DateTime.Now;
                
                TimeSpan businessStartT = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
                
                TimeSpan businessEndT = new DateTime(now.Year, now.Month, now.Day, 20, 0, 0).TimeOfDay;

                if ((selectedStartT.TimeOfDay < businessStartT) ||
                    
                    (selectedStartT.TimeOfDay > businessEndT) ||
                    
                    (selectedEndT.TimeOfDay < businessStartT) ||
                    
                    (selectedEndT.TimeOfDay > businessEndT))
                {
                    MessageBox.Show("Start and end times conflict business hours.\nPlease select another time during normal business hours: 8 A.M. - 8 P.M.");

                    return;
                }
                if (selectedStartT.Date > selectedEndT.Date)
                {
                    MessageBox.Show("End date cannot be earlier than start date. \n Please select a different date range.");

                    return;
                }
                else
                {
                    MessageBox.Show("New appointment time and date is within normal business hours.");

                }
            }
            catch (ArgumentOutOfRangeException ar)
            {
               MessageBox.Show(ar.Message, "Check business start and end date times. \n");
            }

            //Appointment overlap
            if (ApptOverlap())
            {
                MessageBox.Show("Selected times overlap with another appointment.");

                return;
            }

            Appointment appt = new Appointment(cId, usrId, cusName, aType, selStart, selEnd);

            Appointment.InsertAppt(appt);

            saveNewApptBtn.Enabled = canBSaved();

            Appointment.DisplayAppt();

            dash.Show();

            this.Close();
        }

        private void cancelNewApptBtn_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        } 
    }
}
