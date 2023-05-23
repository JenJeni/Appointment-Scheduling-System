using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.DataAccess
{
    public class ConnectDb
    {
		public static MySqlConnection sqlConn { get; set; }

		public static void openConnection()
		{
			try
			{
				//Initialize connection
				string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

				if (sqlConn == null)
				{
					// get connection string
					sqlConn = new MySqlConnection(cs);

					//Open connection
					sqlConn.Open();
				}

                else
                {
					MessageBox.Show("Connection was not successful.");
				}
				
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void closeConnection()
		{
			try
			{
				//Close connection
				if (sqlConn != null)
				{
					sqlConn.Close();
				}

				sqlConn = null;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
