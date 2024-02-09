using System;
using System.Net.Mail;
using Enlightened.Management;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SOS
{



    public partial class Metro
    {

        private string emailTO = "1234567890@mms.att.net, some.one@somewhere.org";
        private string emailFROM = "support@somewhere.org";
        private string smtpSERVER = "smtp.someplace.com";
        private string uName = "support@somewhere.org";
        private string pWord = "suppor1";

        public Metro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // checkForUpdate()

            // lbl_Date.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            lbl_Date.Text = DateTime.Now.ToShortDateString() + " @ " + DateTime.Now.ToShortTimeString();
            // lbl_Date.Text = "00/00/00 @ 00:00 PM"
            lbl_User.Text = GetUserName();
            // prgrs_Submit.Visible = False
            lbl_Progress.Visible = false;
            cb_Fix.Items.Add("This Week");
            cb_Fix.Items.Add("Today");

            // txtbx_Problem.Select()
            // txtbx_Problem.Select()
            // Me.AcceptButton = btn_Submit
            // Me.Show()
            // Me.Focus()
            // Me.BringToFront()
            // Me.Focus()
            // Timer1.Enabled = True
        }


        private void Form_Deactivate()
        {
            Focus();

        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            // MsgBox("Lost Focus")
            if (cb_Fix.SelectedIndex != -1)
            {
                TopMost = true;
                Select();
                txtbx_Problem.Select();
            }
            else
            {

                rb_Fix.Checked = true;

            }

        }



        public string GetUserName()
        {
            if (My.MyProject.User.CurrentPrincipal is System.Security.Principal.WindowsPrincipal)
            {
                // The application is using Windows authentication.
                // The name format is DOMAIN\USERNAME.
                string[] parts = Strings.Split(My.MyProject.User.Name, @"\");
                string username = parts[1];
                return username;
            }
            else
            {
                // The application is using custom authentication.
                return My.MyProject.User.Name;
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void checkForUpdate()
        {


            // -----------------------------------BEGIN LICENSE CODE----------------------------------------
            // Keith Harrison        December 2014        Enlightened Management                         '
            // ---------------------------------------------------------------------------------------------'
            // Give a password and appCode to determine a unique key for your application (between 5 and 9 characters) (no numbers)'
            // 
            int appCode = 18;
            string pass = "saveoursouls";
            // URL you would like to check for updates
            string updateTextURL = "https://dl.dropboxusercontent.com/u/7794031/SOS/version.txt";
            // URL you would like to download update from
            string updateDownloadURL = "https://dl.dropboxusercontent.com/u/7794031/SOS/SOS%20Setup.exe";
            // URL for change log
            string changeLogURL = "https://dl.dropboxusercontent.com/u/7794031/SOS/ChangeLog.txt";
            // URL you would like to verify serial
            string serialURL = "https://dl.dropboxusercontent.com/u/7794031/Users.txt";
            // URL for payment
            string paymentURL = "http://site.enlightenedlogic.com/form/scadaview.html";
            // '
            // ---------------------------------------------------------------------------------------------'
            // -----------------------------------DO NOT TOUCH THIS-----------------------------------------'
            // '
            var getLicense = new generateLicense();                                                         // 
                                                                                                            // Dim licensed As Boolean
                                                                                                            // licensed = getLicense.checkSerial(serialURL, pass, paymentURL)
                                                                                                            // If (licensed = False) Then
                                                                                                            // licensed = getLicense.checkStatus(appCode, pass)
                                                                                                            // End If
            getLicense.checkupdate(updateTextURL, updateDownloadURL, changeLogURL);
            // '
            // -----------------------------------END LICENSE CODE-------------------------------------------

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbx_Problem.Text))
            {

                Interaction.MsgBox("Please Enter Your Problem");
            }

            else if (rb_Critical.Checked == true)
            {

                sendEmail("Critical");
            }

            else if (rb_Fix.Checked == true)
            {

                if (cb_Fix.SelectedIndex == -1)
                {
                    Interaction.MsgBox("Please Select Urgency");
                }
                else
                {
                    // MsgBox(cb_Fix.SelectedItem)
                    sendEmail(cb_Fix.SelectedItem);
                }
            }

            else
            {
                Interaction.MsgBox("Please Select Urgency");
            }


        }


        private void sendEmail(object status)
        {

            try
            {
                // prgrs_Submit.Visible = True



                lbl_Progress.Visible = true;
                lbl_Progress.Text = "Gathering Data To Send...";
                Refresh();
                // prgrs_Submit.Increment(10)
                var Smtp_Server = new SmtpClient();
                var e_mail = new MailMessage();
                Smtp_Server.UseDefaultCredentials = false;
                // prgrs_Submit.Increment(10)
                Smtp_Server.Credentials = new System.Net.NetworkCredential(uName, pWord);

                Smtp_Server.Port = 587;

                Smtp_Server.EnableSsl = true;
                // prgrs_Submit.Increment(20)
                Smtp_Server.Host = smtpSERVER;

                lbl_Progress.Text = "Preparing Message...";
                Refresh();
                e_mail = new MailMessage();
                // prgrs_Submit.Increment(10)
                e_mail.From = new MailAddress(emailFROM);
                // prgrs_Submit.Increment(10)
                e_mail.To.Add(emailTO);
                // prgrs_Submit.Increment(10)
                e_mail.Subject = "SOS FROM: " + lbl_User.Text + " ON " + lbl_Date.Text;
                // prgrs_Submit.Increment(10)
                e_mail.IsBodyHtml = false;
                // e_mail.Body = "USER: " & lbl_User.Text & vbCrLf & vbCrLf & "DATE/TIME: " & lbl_Date.Text & vbCrLf & vbCrLf & "PROBLEM: " & vbCrLf & txtbx_Problem.Text & vbCrLf & vbCrLf & "Solution: "

                e_mail.Body = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("USER: " + lbl_User.Text + Constants.vbCrLf + Constants.vbCrLf + "STATUS: ", status), Constants.vbCrLf), Constants.vbCrLf), "DATE/TIME: "), lbl_Date.Text), Constants.vbCrLf), Constants.vbCrLf), "PROBLEM: "), Constants.vbCrLf), txtbx_Problem.Text), Constants.vbCrLf), Constants.vbCrLf), "Solution: "));


                lbl_Progress.Text = "Sending Message...";
                Refresh();
                Smtp_Server.Send(e_mail);
                // prgrs_Submit.Value = 100

                Interaction.MsgBox("Thanks, I will get back to you ASAP!");
            }




            catch (Exception error_t)
            {
                Interaction.MsgBox(error_t.ToString());

            }
            // prgrs_Submit.Value = 0
            // prgrs_Submit.Visible = False
            lbl_Progress.Text = "";
            lbl_Progress.Visible = false;

            Close();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Focus();
            BringToFront();
            Timer1.Enabled = false;


        }
    }
}