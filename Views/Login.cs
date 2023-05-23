using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Generic;
using AppointmentSchedulingApplication.DataModels;
using System.Linq;

namespace AppointmentSchedulingApplication.Views
{
    public partial class Login : Form
    {
        public static string cs = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;

        MySqlConnection sConn = new MySqlConnection(cs);

        DateTime localT = DateTime.Now;

        //Used to help culture change
        string errorString;

        string signSuccess;

        string emptyString;

        string apptReminder;

        string reminderHeader;

        string exitForm;

        public Login()
        {
            InitializeComponent();

            //CultureInfo.CurrentCulture = new CultureInfo("fr");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TranslateLogin();
        }

        #region Culture Change
        private void TranslateLogin()
        {            
            string currCultureEn = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            string currCultureLux = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            try
            {
                if (currCultureEn == "en")
                {
                    DisplayEngLang();
                }
                else if (currCultureLux == "fr")
                {
                    this.Text = "Login";

                    labelLoginIntro.Text = "Login op Äre Kont";

                    labelUsrName.Text = "Benotzernumm";

                    labelPwd.Text = "Passwuert";

                    signInBtn.Text = "umellen";

                    exitBtn.Text = "Sortie";

                    signSuccess = "Zeechen an erfollegräich.";

                    emptyString = "Gitt weg e Benotzernumm a Passwuert.";

                    errorString = "Benotzernumm oder Passwuert ass ongëlteg. Versich et nach eng Kéier.";

                    apptReminder = "Dir hutt e Rendez-vous bannent 15 Minutten!";

                    reminderHeader = "Alarm";

                    exitForm = "Sidd Dir sécher datt Dir ausgoe wëllt?";
                }
                else
                {
                    DisplayEngLang();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DisplayEngLang()
        {
            this.Text = "Login";

            labelLoginIntro.Text = "Login To Your Account";

            labelUsrName.Text = "Username";

            labelPwd.Text = "Password";

            signInBtn.Text = "Sign In";

            exitBtn.Text = "Exit";

            errorString = "Username or password is invalid. Try again.";

            signSuccess = "Sign in successful.";

            emptyString = "Please enter a username and password.";

            apptReminder = "You have an appointment starting within 15 minutes!";

            reminderHeader = "Alert";

            exitForm = "Are you sure you want to exit?";
        }
        #endregion

        #region Activity Log
        private void LoginActivityLog(string infoText)
        {
            try
            {
                string logTxtPath = @"C:\TempLog\LoginActivity.txt";

                if (!Directory.Exists("C:\\TempLog"))
                {
                    Directory.CreateDirectory("C:\\TempLog");
                }

                using (FileStream fileStream = new FileStream(logTxtPath, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        //If file doesn't exist, create new file and write to it
                        if (!File.Exists(logTxtPath))
                        {
                            var newFile = File.Create(logTxtPath);

                            streamWriter.WriteLine(infoText);

                            streamWriter.Flush();

                            newFile.Close();

                            streamWriter.Close();

                            fileStream.Close();
                        }
                        else if (File.Exists(logTxtPath))
                        {
                            streamWriter.WriteLine(infoText);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Appointment Reminder
        private void SetReminder()
        {
            //Appointment reminder/alert 
            try
            {
                string sql = "SELECT * FROM appointment";

                MySqlCommand cmd = new MySqlCommand(sql, sConn);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                DataTable dtAp = new DataTable();

                sda.Fill(dtAp);

                for (int i = 0; i < dtAp.Rows.Count; i++)
                {
                    DateTime startT = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dtAp.Rows[i]["Start"], TimeZoneInfo.Local);

                    DateTime endT = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dtAp.Rows[i]["End"], TimeZoneInfo.Local);

                    TimeSpan tSpan = startT.Subtract(localT);

                    if (tSpan.TotalMinutes > 0 && tSpan.TotalMinutes < 15)
                    {

                        //Used lambda here to display message to user about appointments starting within 15 minute window
                        Action remind = () => MessageBox.Show(apptReminder, reminderHeader);

                        remind.Invoke();                        
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
        }
        #endregion

        private void usrNameTxt_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(usrNameTxt.Text))
            //{
            //    MessageBox.Show(emptyString);

            //    return;
            //}
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(pwdTxt.Text))
            //{
            //    MessageBox.Show(emptyString);

            //    return;
            //}
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {           
            string usr = usrNameTxt.Text;

            string pwd = pwdTxt.Text;


            if (string.IsNullOrEmpty(usr) && string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show(emptyString);

                return;
            }

            try
            {
                string selUser = "SELECT userName, password FROM user WHERE userName = @userName AND password = @password";

                sConn.Open();

                MySqlCommand cmd2 = new MySqlCommand(selUser, sConn);

                cmd2.Parameters.AddWithValue("@userName", usr);

                cmd2.Parameters.AddWithValue("@password", pwd);

                MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);

                DataTable dt = new DataTable();

                sda2.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    SetReminder();

                    MessageBox.Show(signSuccess);

                    //Write to log
                    LoginActivityLog("User " + usr + " has logged in at " + localT.ToLongTimeString() + '\n');

                    //Display next screen
                    Dashboard dash = new Dashboard();

                    this.Hide();

                    dash.Show();
                }
                else
                {
                    MessageBox.Show(errorString);

                    //Write to log
                    LoginActivityLog("Failed Login Attempt With User " + usr + " at " + localT.ToLongTimeString() + '\n');

                    usrNameTxt.Clear();

                    pwdTxt.Clear();

                    usrNameTxt.Focus();
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
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show(exitForm, "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
