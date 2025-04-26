using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringCapstone
{
    public partial class bugReport : Form
    {
        private int? taskID;

        public bugReport(int? taskID)
        {
            InitializeComponent();
            this.taskID = taskID;

        }



        private void finishReportBTN_Click(object sender, EventArgs e)
        {
            if (taskID == null)
            {
                MessageBox.Show("No Task ID is associated with this bug report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bugDescription = issueReportTXT.Text.Trim(); // Get the bug description from the text box

            if (string.IsNullOrEmpty(bugDescription))
            {
                MessageBox.Show("Please provide a description for the bug.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Insert the new bug record into the bugs table
                    string insertQuery = "INSERT INTO Bugs (BugDescription, TaskID) VALUES (@Description, @TaskID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@TaskID", taskID);
                        command.Parameters.AddWithValue("@Description", bugDescription);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bug report submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit the bug report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                this.Close(); // Close the form after successful submission
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the bug report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
