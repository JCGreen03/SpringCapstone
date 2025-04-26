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
    public partial class runningTest : Form
    {
        private List<int> selectedGroupIDs;
        private int elapsedSeconds = 0; // Counter to track elapsed time
        private int totalElapsedSeconds = 0; // Counter to track total elapsed time
        private List<int> completedPersonIDs = new List<int>(); // Track completed PersonIDs
        private int currentTaskIndex = 0; // Tracks the current task index
        private int? currentTaskID = null; // Tracks the TaskID of the current task




        public runningTest(List<int> selectedGroupIDs)
        {
            this.selectedGroupIDs = selectedGroupIDs;
            InitializeComponent();



            // Initialize the timers
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1 second interval
            timer1.Tick += timer1_Tick; // Attach the Tick event handler

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000; // 1 second interval
            timer2.Tick += timer2_Tick; // Attach the Tick event handler

            loadNames(); // Load the first person's name
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            totalElapsedSeconds++; // Increment the total elapsed seconds
        }


        private void loadNames()
        {
            if (selectedGroupIDs == null || selectedGroupIDs.Count == 0)
            {
                MessageBox.Show("No groups selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to get the first person in the first group from selectedGroupIDs
                    string query = "SELECT TOP 1 FirstName, LastName FROM People WHERE GroupID = @GroupID ORDER BY PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupID", selectedGroupIDs[0]); // Use the first GroupID
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                nameLBL.Text = $"{lastName}, {firstName}"; // Set nameLBL to "LastName, FirstName"
                            }
                            else
                            {
                                nameLBL.Text = "No people available"; // Handle case where no people exist in the group
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++; // Increment the elapsed seconds
            TimeSpan time = TimeSpan.FromSeconds(elapsedSeconds); // Convert seconds to TimeSpan
            timeLBL.Text = time.ToString(@"hh\:mm\:ss"); // Format as HH:MM:SS and update timeLBL
        }

        private void loadTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to get the first task from the Tasks table
                    string query = "SELECT TOP 1 TaskName FROM Tasks ORDER BY TaskID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            taskNameLBL.Text = result.ToString(); // Set TaskNameLBL to the TaskName
                        }
                        else
                        {
                            taskNameLBL.Text = "No tasks available"; // Handle case where no tasks exist
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void StartStopBTN_Click(object sender, EventArgs e)
        {
            if (StartStopBTN.Text == "Start Test")
            {
                StartStopBTN.Text = "Pause Test"; // Change button text to "Pause Test"
                timer1.Start(); // Start the task timer
                timer2.Start(); // Start the total time timer

                if (!nextTaskBTN.Enabled)
                {
                    nextTaskBTN.Enabled = true; // Enable the "Next Task" button
                    loadTasks(); // Load the first task
                }
            }
            else if (StartStopBTN.Text == "Pause Test")
            {
                StartStopBTN.Text = "Resume Test"; // Change button text to "Resume Test"
                timer1.Stop(); // Pause the task timer
                timer2.Stop(); // Pause the total time timer
            }
            else if (StartStopBTN.Text == "Resume Test")
            {
                StartStopBTN.Text = "Pause Test"; // Change button text back to "Pause Test"
                timer1.Start(); // Resume the task timer
                timer2.Start(); // Resume the total time timer
            }
        }



        private void nextTaskBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to get the next task based on the currentTaskIndex
                    string taskQuery = "SELECT TaskID, TaskName FROM Tasks ORDER BY TaskID OFFSET @Offset ROWS FETCH NEXT 1 ROWS ONLY";
                    using (SqlCommand taskCommand = new SqlCommand(taskQuery, connection))
                    {
                        taskCommand.Parameters.AddWithValue("@Offset", currentTaskIndex); // Use the current task index as the offset
                        using (SqlDataReader reader = taskCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Load the next task
                                currentTaskID = (int)reader["TaskID"]; // Store the TaskID
                                taskNameLBL.Text = reader["TaskName"].ToString(); // Set TaskNameLBL to the TaskName
                                currentTaskIndex++; // Increment the task index for the next call
                                elapsedSeconds = 0; // Reset the timer
                            }
                            else
                            {
                                // No more tasks available, move to the next person
                                taskNameLBL.Text = ""; // Clear the task name
                                currentTaskID = null; // Clear the current TaskID
                                reader.Close(); // Ensure the reader is closed before moving to the next person
                                if (!LoadNextPerson(connection))
                                {
                                    // If no more people, move to the next group
                                    if (!LoadNextGroup())
                                    {
                                        // If no more groups, finish the test
                                        nextTaskBTN.Text = "Finish"; // Change button text to "Finish"
                                        nextTaskBTN.Click -= nextTaskBTN_Click; // Unsubscribe from the current event handler
                                        nextTaskBTN.Click += FinishTest_Click; // Subscribe to the new event handler
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the next task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private bool LoadNextPerson(SqlConnection connection)
        {
            string completedIDs = string.Join(",", completedPersonIDs); // Convert list to comma-separated string
            string personQuery = $"SELECT TOP 1 PersonID, FirstName, LastName FROM People WHERE GroupID = @GroupID {(completedPersonIDs.Count > 0 ? $"AND PersonID NOT IN ({completedIDs})" : "")} ORDER BY PersonID";

            using (SqlCommand personCommand = new SqlCommand(personQuery, connection))
            {
                personCommand.Parameters.AddWithValue("@GroupID", selectedGroupIDs[0]); // Use the current GroupID
                using (SqlDataReader personReader = personCommand.ExecuteReader())
                {
                    if (personReader.Read())
                    {
                        int personID = (int)personReader["PersonID"];
                        string firstName = personReader["FirstName"].ToString();
                        string lastName = personReader["LastName"].ToString();
                        nameLBL.Text = $"{lastName}, {firstName}"; // Set nameLBL to "LastName, FirstName"
                        completedPersonIDs.Add(personID); // Mark this person as completed
                        elapsedSeconds = 0; // Reset the timer
                        currentTaskIndex = 0; // Reset task index for the new person
                        return true; // Successfully loaded the next person
                    }
                }
            }

            return false; // No more people in the current group
        }

        private bool LoadNextGroup()
        {
            if (selectedGroupIDs.Count > 0)
            {
                selectedGroupIDs.RemoveAt(0); // Remove the current group
                if (selectedGroupIDs.Count > 0)
                {
                    loadNames(); // Load the first person in the next group
                    elapsedSeconds = 0; // Reset the timer
                    currentTaskIndex = 0; // Reset task index for the new group
                    return true; // Successfully loaded the next group
                }
            }

            return false; // No more groups available
        }





        private void FinishTest_Click(object sender, EventArgs e)
        {
            timer2.Stop(); // Stop the total time timer
            TimeSpan totalTime = TimeSpan.FromSeconds(totalElapsedSeconds); // Convert total seconds to TimeSpan

            this.Hide();
            testResults testResults = new testResults(totalTime); // Pass the total time to the new window
            testResults.Show();
        }
        private void reportBTN_Click(object sender, EventArgs e)
        {
            // Pause the timer
            timer1.Stop();

            // Open the bugReport form as a modal dialog
            using (bugReport bugReportForm = new bugReport(currentTaskID))
            {
                bugReportForm.ShowDialog(this); // Show the bugReport form over the current window
            }

            // Resume the timer when the bugReport form is closed
            if (StartStopBTN.Text == "Pause Test")
            {
                timer1.Start();
            }
        }



    }
}
