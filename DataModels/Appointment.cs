using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace AppointmentSchedulingApplication.DataModels
{
    public class Appointment
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        public int AppointmentId { get; set; }

        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public string CustomerName { get; set; }

        public string Type { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public static int CurrApptIdx { get; set; }

        #region Constructors
        public Appointment(int apptId, int custId, int usrId, string cusName, string apptType, DateTime startT, DateTime endT) 
        {
            AppointmentId = apptId;

            CustomerId = custId;

            UserId = usrId;

            CustomerName = cusName;

            Type = apptType;

            Start = startT;

            End = endT;
        }

        public Appointment(int custId, int usrId, string cusName, string apptType, DateTime startT, DateTime endT)
        {
            CustomerId = custId;

            UserId = usrId;

            CustomerName = cusName;

            Type = apptType;

            Start = startT;

            End = endT;
        }
        #endregion

        #region Display
        public static DataTable DisplayAppt()
        {
            DataTable dtAppts = new DataTable();

            MySqlConnection sConn = new MySqlConnection(cs);
            
            try
            {
                string selAppt = "SELECT appointmentId AS 'Appointment ID', appointment.customerId AS 'Customer ID', appointment.userId AS 'User ID', customerName AS 'Name', type AS 'Type', start AS 'Start', end AS 'End' FROM  appointment, customer, user WHERE appointment.customerId = customer.customerId AND appointment.userId = user.userId ";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(selAppt, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(dtAppts);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sConn.Close();
            }

            return dtAppts;                      
        }
        #endregion

        #region Insert
        public static void InsertAppt(Appointment appt)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string insertAppt = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)                                                                        VALUES(@CustomerId, @UserId, 'not needed', 'not needed', 'not needed', 'not needed', @Type, 'not needed', @Start, @End, NOW(), 'test', NOW(), 'test')";

                sConn.Open();
                
                MySqlCommand cmd = new MySqlCommand(insertAppt, sConn);

                cmd.Parameters.AddWithValue("@CustomerId", appt.CustomerId);

                cmd.Parameters.AddWithValue("@UserId", appt.UserId);

                cmd.Parameters.AddWithValue("@Type", appt.Type);

                cmd.Parameters.AddWithValue("@Start", appt.Start);

                cmd.Parameters.AddWithValue("@End", appt.End);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Appointment couldn't be added. \n");
            }
            finally
            {
                sConn.Close();
            }
        }
        #endregion

        #region Update
        public static void UpdateAppt(Appointment appt)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string updateAppt = "UPDATE appointment SET customerId = @CustomerId, userId = @UserId, type = @Type, start = @Start, end = @End WHERE appointmentId = @AppointmentId";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(updateAppt, sConn);

                cmd.Parameters.AddWithValue("@AppointmentId", appt.AppointmentId);

                cmd.Parameters.AddWithValue("@CustomerId", appt.CustomerId);

                cmd.Parameters.AddWithValue("@UserId", appt.UserId);

                cmd.Parameters.AddWithValue("@Type", appt.Type);

                cmd.Parameters.AddWithValue("@Start", appt.Start);

                cmd.Parameters.AddWithValue("@End", appt.End);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Appointment couldn't be updated. \n");
            }
            finally
            {
                sConn.Close();
            }
        }

        #endregion

        #region Delete
        public static bool DeleteAppt(int apId)
        {
            MySqlConnection sConn = new MySqlConnection(cs);

            try
            {
                string delAppt = "DELETE FROM appointment WHERE appointmentId = @AppointmentId";

                sConn.Open();

                MySqlCommand cmd = new MySqlCommand(delAppt, sConn);

                cmd.Parameters.AddWithValue("@AppointmentId", apId);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Appointment couldn't be deleted. \n");

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
