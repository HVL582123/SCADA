using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Opc.UaFx;
using Opc.UaFx.Client;

namespace DataLoggerOPCUA
{
    public partial class Form1 : Form
    {
        OpcClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnDisconnect.Show();
            btnConnect.Hide();
            txtConnect.Enabled = false;
            txtTagId.Enabled = false;

            connectToOPC(txtConnect.Text.ToString());
        }

        private void connectToOPC(string serverAddress)
        {

            try
            {
                client = new OpcClient(serverAddress);
                client.Connect();
                timer1.Start();
            }
            catch (Opc.UaFx.OpcException ex)
            {
                MessageBox.Show("Failed to connect to OPC UA server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConnect.Enabled = true;
                txtTagId.Enabled = true;
                btnConnect.Show();
                btnDisconnect.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tagName = txtTagId.Text;
            double tagValue = 0;
            if(tagName != null) {
                // Generate a random tag name and value for testing
                var result = client.ReadNode(txtTagId.Text);

                if (result.Status.IsGood)
                {
                   if(result.Value is double doubleVal)
                    {
                        tagValue = doubleVal;
                        txtTagValue.Text = tagValue.ToString("#0.00");

                        // Check if the tag name exists in the TagConfig table
                        if (!CheckTagExists(tagName))
                        {
                            // If the tag name doesn't exist, create a new tag in the TagConfig table
                            CreateNewTag(tagName);
                        }

                        // Log the tag data in the TagData table
                        LogTagData(tagName, tagValue);
                    }
                    else
                    {
                        MessageBox.Show("Value was not double, please check OPC Tag");
                    }
                }
                else
                {
                    MessageBox.Show("Status was not Good");
                }

            }
            

        }

        private bool CheckTagExists(string tagName)
        {
            // Check if the tag name exists in the TagConfig table

            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AlarmSystem;User ID=tester;Password=test;"))
            {
                connection.Open();

                // Execute a query to check if the tag name exists
                string query = "SELECT COUNT(*) FROM TagConfig WHERE TagName = @TagName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TagName", tagName);
                    int count = (int)command.ExecuteScalar();

                    // Return true if the tag name exists, false otherwise
                    return count > 0;
                }
            }
        }

        private void CreateNewTag(string tagName)
        {
            // Create a new tag entry in the TagConfig table

            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AlarmSystem;User ID=tester;Password=test;"))
            {
                connection.Open();

                // Execute an insert query to create a new tag
                string query = "INSERT INTO TagConfig (TagName) VALUES (@TagName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TagName", tagName);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LogTagData(string tagName, double tagValue)
        {
            // Log the tag data in the TagData table

            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AlarmSystem;User ID=tester;Password=test;"))
            {
                connection.Open();

                // Execute an insert query to log the tag data
                string query = "INSERT INTO TagData (TagId, Value, Status) " +
                               "SELECT TagId, @TagValue, 'Normal' " +
                               "FROM TagConfig " +
                               "WHERE TagName = @TagName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TagName", tagName);
                    command.Parameters.AddWithValue("@TagValue", tagValue);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDisconnect.Hide();
            btnConnect.Show();

            client.Disconnect();

            txtConnect.Enabled = true;
            txtTagId.Enabled = true;
        }
    }
}
