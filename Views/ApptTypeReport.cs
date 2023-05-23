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
    public partial class ApptTypeReport : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        Dashboard dash = new Dashboard();

        public ApptTypeReport()
        {
            InitializeComponent();

            dgvApptTypes.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvApptTypes.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvApptTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DisplayMonthTypes();
        }

        private void dgvApptTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvApptTypes.ClearSelection();
        }

        private DataTable DisplayMonthTypes()
        {
            DataTable monthDt = new DataTable();

            MySqlConnection sConn = new MySqlConnection(cs);

            reportTxt.Text = "Report: Total Count Of Each Appointment Type By Month:\r\n\r\n";

            try
            {
                string apptType = "SELECT MONTHNAME(start)Month, type AS 'Type', COUNT(*) Count FROM appointment WHERE YEAR(start) <= YEAR(end)  GROUP BY MONTHNAME(start), type;";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(apptType, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(monthDt);

                dgvApptTypes.DataSource = monthDt;

                foreach (DataRow row in monthDt.Rows)
                {
                    reportTxt.Text = reportTxt.Text +
                    row[0].ToString() + ": " + row[1].ToString() +  " = " + row[2].ToString() + "\r\n";                   
                    //0 = month, 1 = type, 2 = count
                }

                reportTxt.Select(0, 0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            dgvApptTypes.Update();

            dgvApptTypes.Refresh();

            return monthDt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        }
    }
}
