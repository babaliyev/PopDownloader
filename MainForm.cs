using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PopDownloader
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        Pop3Client client;

        SqlCommand countCmd = new SqlCommand();

        SqlCommand mailCmd = new SqlCommand();
        SqlCommand recieverCmd = new SqlCommand();

        public MainForm()
        {
            InitializeComponent();
            chengeControlStatuses(false);

            countCmd.CommandText = "SELECT max(id) FROM mails";

            mailCmd.CommandText = @"INSERT INTO [mails]
                                           ([id]
                                           ,[title]
                                           ,[raw]
                                           ,[sender_email]
                                           ,[sendtime])
                                     VALUES
                                           (@id
                                           ,@title
                                           ,@raw
                                           ,@sender_email
                                           ,@sendtime)";

            mailCmd.Parameters.Clear();
            mailCmd.Parameters.Add("@id", SqlDbType.Decimal);
            mailCmd.Parameters.Add("@title", SqlDbType.NVarChar);
            mailCmd.Parameters.Add("@raw", SqlDbType.Image);
            mailCmd.Parameters.Add("@sender_email", SqlDbType.NVarChar);
            mailCmd.Parameters.Add("@sendtime", SqlDbType.DateTime);

            recieverCmd.CommandText = @"INSERT INTO [mail_recievers]
                                               ([email]
                                               ,[cc]
                                               ,[mail_id])
                                         VALUES
                                               (@email
                                               ,@cc
                                               ,@mail_id)";

            recieverCmd.Parameters.Clear();
            recieverCmd.Parameters.Add("@email", SqlDbType.NVarChar);
            recieverCmd.Parameters.Add("@cc", SqlDbType.Bit);
            recieverCmd.Parameters.Add("@mail_id", SqlDbType.Decimal);
        }

        private void chengeControlStatuses(bool started)
        {
            buttonStop.Enabled = started;
            buttonStart.Enabled = !started;
            textBoxPOPHost.Enabled = !started;
            numericUpDownPOPPort.Enabled = !started;
            checkBoxPOPUseSSL.Enabled = !started;
            textBoxPOPLogin.Enabled = !started;
            textBoxPOPPassword.Enabled = !started;
            textBoxDBHost.Enabled = !started;
            textBoxDBName.Enabled = !started;
            textBoxDBLogin.Enabled = !started;
            textBoxDBPassword.Enabled = !started;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Save();

                connection = new SqlConnection();
                client = new Pop3Client();
               

                connection.ConnectionString = "Data Source=" + textBoxDBHost.Text +
                    ";Initial Catalog=" + textBoxDBName.Text +
                    ";Persist Security Info=True;User ID=" + textBoxDBLogin.Text +
                    ";Password=" + textBoxDBPassword.Text + ";Connection Timeout=15";

                connection.Open();

                countCmd.Connection = connection;
                mailCmd.Connection = connection;
                recieverCmd.Connection = connection;

                timer1.Start();
                chengeControlStatuses(true);
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        public void getMessages()
        {
            //try
            //{
                Int32 count = 0;
                object obj = countCmd.ExecuteScalar();
                if(obj!=null && obj != DBNull.Value)
                    count = Int32.Parse(obj.ToString());

                if (!client.Connected)
                {
                    // Connect to the server
                    client.Connect(textBoxPOPHost.Text, (int)numericUpDownPOPPort.Value, checkBoxPOPUseSSL.Checked);

                    // Authenticate ourselves towards the server
                    client.Authenticate(textBoxPOPLogin.Text, textBoxPOPPassword.Text);
                }

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

               // messageCount = messageCount > (int)numericUpDown1.Value ? (int)numericUpDown1.Value : messageCount;

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number
                for (int i = count+1; i <= messageCount; i++)
                {
                    try
                    {
                        proseccMessage(client.GetMessage(i), i);
                        //client.DeleteMessage(i);
                    }
                    catch { }
                }

                client.Disconnect();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    //chengeControlStatuses(false);
            //    //timer1.Start();
            //}
        }

        public void proseccMessage(OpenPop.Mime.Message msg, decimal id)
        {            
                mailCmd.Parameters["@id"].Value = DBNull.Value;
                mailCmd.Parameters["@title"].Value = DBNull.Value;
                mailCmd.Parameters["@raw"].Value = DBNull.Value;
                mailCmd.Parameters["@sender_email"].Value = DBNull.Value;
                mailCmd.Parameters["@sendtime"].Value = DBNull.Value;


                if (!String.IsNullOrWhiteSpace(msg.Headers.From.Address))
                {

                    mailCmd.Parameters["@id"].Value = id;
                    mailCmd.Parameters["@title"].Value = String.IsNullOrEmpty(msg.Headers.Subject) ? "" : (object)msg.Headers.Subject;

                    mailCmd.Parameters["@raw"].Value = msg.RawMessage;

                    mailCmd.Parameters["@sender_email"].Value = msg.Headers.From.Address;
                    mailCmd.Parameters["@sendtime"].Value = msg.Headers.DateSent;
                    mailCmd.ExecuteNonQuery();

                    foreach (OpenPop.Mime.Header.RfcMailAddress addr in msg.Headers.To)
                    {
                        if (!String.IsNullOrWhiteSpace(addr.Address))
                        {
                            recieverCmd.Parameters["@email"].Value = DBNull.Value;
                            recieverCmd.Parameters["@cc"].Value = DBNull.Value;
                            recieverCmd.Parameters["@mail_id"].Value = DBNull.Value;

                            recieverCmd.Parameters["@email"].Value = addr.Address.Replace("'", "").Replace(" ", "");
                            recieverCmd.Parameters["@cc"].Value = false;
                            recieverCmd.Parameters["@mail_id"].Value = id;
                            recieverCmd.ExecuteNonQuery();
                        }
                    }

                    foreach (OpenPop.Mime.Header.RfcMailAddress addr in msg.Headers.Cc)
                    {
                        if (!String.IsNullOrWhiteSpace(addr.Address))
                        {
                            recieverCmd.Parameters["@email"].Value = DBNull.Value;
                            recieverCmd.Parameters["@cc"].Value = DBNull.Value;
                            recieverCmd.Parameters["@mail_id"].Value = DBNull.Value;

                            recieverCmd.Parameters["@email"].Value = addr.Address.Replace("'", "").Replace(" ", "");
                            recieverCmd.Parameters["@cc"].Value = true;
                            recieverCmd.Parameters["@mail_id"].Value = id;
                            recieverCmd.ExecuteNonQuery();
                        }
                    }
                }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            chengeControlStatuses(false);

            connection.Close();
            connection.Dispose();
            client.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getMessages();
        }
    }
}
