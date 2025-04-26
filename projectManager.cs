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

//Note to professors: I have no clue how to get the database working for you. I used an express installation of localdb
//and used the connection string to connect to it. This is the first time in a long time that I have used VS and C#, much less
//integrating a database with the application. I have no clue how to get it working for you, but my documentation can show that
//it works for me. 


namespace SpringCapstone
{
    public partial class projectManager : Form
    {
        public projectManager()
        {
            InitializeComponent();
            LoadGroups();
            LoadPeople();
            LoadTasks();
            LoadBugs();
        }

        private void LoadBugs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to fetch TaskName and BugDescription by joining Bugs and Tasks tables
                    string query = @"
                SELECT T.TaskName, B.BugDescription 
                FROM Bugs B
                INNER JOIN Tasks T ON B.TaskID = T.TaskID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            IssueBox.Items.Clear(); // Clear existing items in the issueBox

                            while (reader.Read())
                            {
                                // Format the data as "Task name: [taskName] - [bug description]"
                                string taskName = reader["TaskName"].ToString();
                                string bugDescription = reader["BugDescription"].ToString();
                                string formattedData = $"Task name: {taskName} - {bugDescription}";

                                // Add the formatted data to the issueBox
                                IssueBox.Items.Add(formattedData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading bugs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTasks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Query to fetch all columns from the Tasks table
                    string query = "SELECT TaskName, TaskDescription FROM Tasks";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            TaskBox.Items.Clear(); // Clear existing items
                            while (reader.Read())
                            {
                                // Format the data as a single string and add it to the ListBox
                                string taskData = $"Name: {reader["TaskName"]}, Description: {reader["TaskDescription"]}";
                                TaskBox.Items.Add(taskData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPeople()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Query to fetch all columns from the People table
                    string query = "SELECT FirstName, LastName, Age FROM People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            PeopleBox.Items.Clear(); // Clear existing items
                            while (reader.Read())
                            {
                                // Format the data as a single string and add it to the ListBox
                                string personData = $"Name: {reader["FirstName"]} {reader["LastName"]}, Age: {reader["Age"]}";
                                PeopleBox.Items.Add(personData);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading people: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGroups()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to fetch all columns from the Groups table
                    string query = "SELECT GroupName, GroupAgeRange, GroupDescription FROM Groups";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            GroupList.Items.Clear(); // Clear existing items in GroupList
                            peopleGroup.Items.Clear(); // Clear existing items in peopleGroup

                            while (reader.Read())
                            {
                                // Populate GroupList with full group details
                                string groupData = $"Name: {reader["GroupName"]}, Age Range: {reader["GroupAgeRange"]}, Description: {reader["GroupDescription"]}";
                                GroupList.Items.Add(groupData);

                                // Populate peopleGroup with only the group name
                                string groupName = reader["GroupName"].ToString();
                                peopleGroup.Items.Add(groupName);
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



        private void runTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            testSetup casetest = new testSetup();
            casetest.Show();
        }


        //Group Management Methods

        private void addGroup_Click(object sender, EventArgs e)
        {
            // Retrieve values from the text fields
            string groupName = groupNameTXT.Text;
            string groupAgeRange = groupAgeTXT.Text;
            string groupDescription = groupDescriptionTXT.Text;

            // Validate that the required fields are not empty
            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Group name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(groupAgeRange))
            {
                MessageBox.Show("Group age range cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(groupDescription))
            {
                MessageBox.Show("Group description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Insert the new group into the Groups table
                    string query = "INSERT INTO Groups (GroupName, GroupDescription, GroupAgeRange) VALUES (@GroupName, @GroupDescription, @GroupAgeRange)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupName", groupName);
                        command.Parameters.AddWithValue("@GroupAgeRange", groupAgeRange);
                        command.Parameters.AddWithValue("@GroupDescription", groupDescription);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Group added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                groupNameTXT.Clear();
                groupAgeTXT.Clear();
                groupDescriptionTXT.Clear();
                LoadGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteGroupBTN_Click(object sender, EventArgs e)
        {
            // Check if a group is selected
            if (GroupList.SelectedItem == null)
            {
                MessageBox.Show("Please select a group to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extract the GroupName from the selected item
                string selectedItem = GroupList.SelectedItem.ToString();
                string groupName = selectedItem.Split(',')[0].Replace("Name: ", "").Trim();

                string query = "DELETE FROM Groups WHERE GroupName = @GroupName";

                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Delete the selected group from the database
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupName", groupName);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Group deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the group list
                LoadGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the group: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Person Management Methods

        private void addPerson_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTXT.Text;
            string lastName = lastNameTXT.Text;
            string age = ageTXT.Text;
            //validate that the required fields are not empty
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(age))
            {
                MessageBox.Show("Age cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Insert the new person into the People table
                    string query = "INSERT INTO People (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Person added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstNameTXT.Clear();
                lastNameTXT.Clear();
                ageTXT.Clear();
                LoadPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void peopleDeleteBTN_Click(object sender, EventArgs e)
        {
            //check if a person is selected
            if (PeopleBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a person to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extract the person's name from the selected item
                string selectedItem = PeopleBox.SelectedItem.ToString();
                string personName = selectedItem.Split(',')[0].Replace("Name: ", "").Trim();
                string query = "DELETE FROM People WHERE FirstName + ' ' + LastName = @PersonName";
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Delete the selected person from the database
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonName", personName);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Person deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the people list
                LoadPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToGroupBTN_Click(object sender, EventArgs e)
        {
            // Ensure a person and a group are selected
            if (PeopleBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a person to assign to a group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (peopleGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a group to assign the person to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extract the selected person's name
                string selectedPerson = PeopleBox.SelectedItem.ToString();
                string[] personParts = selectedPerson.Split(',');
                string personName = personParts[0].Replace("Name: ", "").Trim();
                string[] nameParts = personName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                // Extract the selected group's name
                string selectedGroup = peopleGroup.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Get the GroupID of the selected group
                    string getGroupIDQuery = "SELECT GroupID FROM Groups WHERE GroupName = @GroupName";
                    int groupID;
                    using (SqlCommand getGroupIDCommand = new SqlCommand(getGroupIDQuery, connection))
                    {
                        getGroupIDCommand.Parameters.AddWithValue("@GroupName", selectedGroup);
                        object result = getGroupIDCommand.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show($"The group '{selectedGroup}' could not be found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        groupID = (int)result;
                    }

                    // Update the selected person's GroupID
                    string updatePersonQuery = "UPDATE People SET GroupID = @GroupID WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SqlCommand updatePersonCommand = new SqlCommand(updatePersonQuery, connection))
                    {
                        updatePersonCommand.Parameters.AddWithValue("@GroupID", groupID);
                        updatePersonCommand.Parameters.AddWithValue("@FirstName", firstName);
                        updatePersonCommand.Parameters.AddWithValue("@LastName", lastName);
                        int rowsAffected = updatePersonCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Person successfully assigned to the group!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to assign the person to the group. Please check the selected person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while assigning the person to the group: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        //Task Management Methods

        private void addTask_Click(object sender, EventArgs e)
        {
            string taskName = taskNameTXT.Text;
            string taskDescription = taskDescTXT.Text;
            //validate that the required fields are not empty
            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Task name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Task description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Insert the new task into the Tasks table
                    string query = "INSERT INTO Tasks (TaskName, TaskDescription) VALUES (@TaskName, @TaskDescription)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskName", taskName);
                        command.Parameters.AddWithValue("@TaskDescription", taskDescription);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taskNameTXT.Clear();
                taskDescTXT.Clear();
                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void taskDeleteBTN_Click(object sender, EventArgs e)
        {
            //check if a task is selected
            if (TaskBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extract the task name from the selected item
                string selectedItem = TaskBox.SelectedItem.ToString();
                string taskName = selectedItem.Split(',')[0].Replace("Name: ", "").Trim();
                string query = "DELETE FROM Tasks WHERE TaskName = @TaskName";
                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    // Delete the selected task from the database
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaskName", taskName);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the task list
                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResolveBTN_Click(object sender, EventArgs e)
        {
            // Ensure a bug is selected
            if (IssueBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a bug to resolve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Extract the selected item's data
                string selectedItem = IssueBox.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                if (parts.Length < 2)
                {
                    MessageBox.Show("Invalid bug format. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string taskName = parts[0].Replace("Task name: ", "").Trim();
                string bugDescription = parts[1].Trim();

                using (SqlConnection connection = new SqlConnection("Data Source=JACK-PC\\SQLEXPRESS;Initial Catalog=CapstoneDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True;"))
                {
                    connection.Open();

                    // Query to delete the bug record
                    string deleteQuery = @"
                DELETE FROM Bugs
                WHERE TaskID = (SELECT TaskID FROM Tasks WHERE TaskName = @TaskName)
                AND BugDescription = @BugDescription";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@TaskName", taskName);
                        command.Parameters.AddWithValue("@BugDescription", bugDescription);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bug resolved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to resolve the bug. Please ensure the selected bug exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Reload the IssueBox
                LoadBugs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resolving the bug: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
