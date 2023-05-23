using AppointmentSchedulingApplication.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.DataModels
{
    public class User
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public User(int uId, string uName, string passwd)
        {
            UserId = uId;

            UserName = uName;

            Password = passwd;
        }

        #region Insert
        public static void CreateNewUser()
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string newUser = "INSERT INTO user VALUES(NULL, 'test3', 'test3', 1, NOW(), 'test', NOW(), 'test');";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(newUser, sConn);

                cmd.ExecuteNonQuery();
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
    }
}
