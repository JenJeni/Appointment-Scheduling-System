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
    public partial class ConsultantSchedule : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        Dashboard dash = new Dashboard();

        public ConsultantSchedule()
        {
            InitializeComponent();

            usrDGV.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            usrDGV.DefaultCellStyle.SelectionForeColor = Color.White;

            usrDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            usrDGV.MultiSelect = false;

            FillUserCbo();
        }

        private void usrDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

        private void FillUserCbo()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string qry = "SELECT userName FROM user";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(qry, sConn);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                cboUser.DisplayMember = "userName";

                cboUser.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve user.");
            }
            finally
            {
                sConn.Close();
            }
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string qry = "SELECT appointmentId AS 'Appointment ID', u.userId AS 'User ID', c.customerId AS 'Customer ID', type AS 'Type', start AS 'Start', end AS 'End' FROM appointment a, user u, customer c WHERE a.customerId = c.customerId AND a.userId = u.userId AND userName = '" + cboUser.Text.ToString() +"'";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(qry, sConn);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                usrDGV.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Could not retrieve user.");
            }
            finally
            {
                sConn.Close();
            }
        }

        private void btnExitUsrSchd_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        }
    }
}
