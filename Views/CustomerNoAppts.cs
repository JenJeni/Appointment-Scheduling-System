using MySql.Data.MySqlClient;

using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.Views
{
    public partial class CustomerNoAppts : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        Dashboard dash = new Dashboard();

        public CustomerNoAppts()
        {
            InitializeComponent();

            dgvCusCount.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            dgvCusCount.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCusCount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CustomerWOAppt();
        }

        private DataTable CustomerWOAppt()
        {
            DataTable noApptDt = new DataTable();

            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string getCusCount = "SELECT customerName AS 'Name', active AS 'Active', COUNT(*) Count from customer c where not exists (SELECT NULL FROM appointment a WHERE a.customerId = c.customerId) GROUP BY customerName, active;";
                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(getCusCount, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(noApptDt);

                dgvCusCount.DataSource = noApptDt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            dgvCusCount.Update();

            dgvCusCount.Refresh();

            return noApptDt;
        }

        private void btnExitCusCount_Click(object sender, EventArgs e)
        {
            dash.Show();

            this.Close();
        }
    }
}
