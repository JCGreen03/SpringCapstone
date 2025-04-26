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
    public partial class testSetup : Form
    {
        public testSetup()
        {
            InitializeComponent();
            loadGroups();
        }

        private void loadGroups()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to fetch all GroupName records from the Groups table
                    string query = "SELECT GroupName FROM Groups";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            GroupCheck.Items.Clear(); // Clear existing items

                            while (reader.Read())
                            {
                                // Add each GroupName to the CheckedListBox
                                GroupCheck.Items.Add(reader["GroupName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading groups: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            // Ensure at least one group is selected
            if (GroupCheck.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one group to start the test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<int> selectedGroupIDs = new List<int>();

                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to fetch GroupID for the selected GroupNames
                    string query = "SELECT GroupID FROM Groups WHERE GroupName = @GroupName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (var selectedGroup in GroupCheck.CheckedItems)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@GroupName", selectedGroup.ToString());

                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                selectedGroupIDs.Add(Convert.ToInt32(result));
                            }
                        }
                    }
                }

                // Pass the selected GroupIDs to the runningTest form
                runningTest testForm = new runningTest(selectedGroupIDs);
                this.Hide();
                testForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while starting the test: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
