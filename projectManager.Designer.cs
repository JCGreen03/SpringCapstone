namespace SpringCapstone
{
    partial class projectManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            runTestToolStripMenuItem = new ToolStripMenuItem();
            taskPage = new TabPage();
            TaskBox = new ListBox();
            addTask = new Button();
            taskDeleteBTN = new Button();
            taskDescTXT = new TextBox();
            taskNameTXT = new TextBox();
            label12 = new Label();
            label14 = new Label();
            peoplePage = new TabPage();
            peopleGroup = new ListBox();
            addToGroupBTN = new Button();
            label4 = new Label();
            PeopleBox = new ListBox();
            addPerson = new Button();
            ageTXT = new TextBox();
            lastNameTXT = new TextBox();
            firstNameTXT = new TextBox();
            label7 = new Label();
            peopleDeleteBTN = new Button();
            label8 = new Label();
            label9 = new Label();
            TabControl = new TabControl();
            groupPage = new TabPage();
            addGroup = new Button();
            groupCompletionLBL = new Label();
            label1 = new Label();
            deleteGroupBTN = new Button();
            groupDescriptionTXT = new TextBox();
            groupAgeTXT = new TextBox();
            groupNameTXT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupNameLBL = new Label();
            GroupList = new ListBox();
            tabPage1 = new TabPage();
            ResolveBTN = new Button();
            IssueBox = new ListBox();
            menuStrip1.SuspendLayout();
            taskPage.SuspendLayout();
            peoplePage.SuspendLayout();
            TabControl.SuspendLayout();
            groupPage.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { runTestToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(803, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // runTestToolStripMenuItem
            // 
            runTestToolStripMenuItem.Name = "runTestToolStripMenuItem";
            runTestToolStripMenuItem.Size = new Size(63, 20);
            runTestToolStripMenuItem.Text = "Run Test";
            runTestToolStripMenuItem.Click += runTestToolStripMenuItem_Click;
            // 
            // taskPage
            // 
            taskPage.Controls.Add(TaskBox);
            taskPage.Controls.Add(addTask);
            taskPage.Controls.Add(taskDeleteBTN);
            taskPage.Controls.Add(taskDescTXT);
            taskPage.Controls.Add(taskNameTXT);
            taskPage.Controls.Add(label12);
            taskPage.Controls.Add(label14);
            taskPage.Location = new Point(4, 24);
            taskPage.Name = "taskPage";
            taskPage.Padding = new Padding(3);
            taskPage.Size = new Size(771, 216);
            taskPage.TabIndex = 2;
            taskPage.Text = "Tasks";
            taskPage.UseVisualStyleBackColor = true;
            // 
            // TaskBox
            // 
            TaskBox.FormattingEnabled = true;
            TaskBox.ItemHeight = 15;
            TaskBox.Location = new Point(6, 6);
            TaskBox.Name = "TaskBox";
            TaskBox.Size = new Size(472, 199);
            TaskBox.TabIndex = 30;
            // 
            // addTask
            // 
            addTask.Location = new Point(484, 152);
            addTask.Name = "addTask";
            addTask.Size = new Size(75, 23);
            addTask.TabIndex = 29;
            addTask.Text = "Add";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += addTask_Click;
            // 
            // taskDeleteBTN
            // 
            taskDeleteBTN.ForeColor = Color.IndianRed;
            taskDeleteBTN.Location = new Point(484, 181);
            taskDeleteBTN.Name = "taskDeleteBTN";
            taskDeleteBTN.Size = new Size(75, 23);
            taskDeleteBTN.TabIndex = 21;
            taskDeleteBTN.Text = "Delete";
            taskDeleteBTN.UseVisualStyleBackColor = true;
            taskDeleteBTN.Click += taskDeleteBTN_Click;
            // 
            // taskDescTXT
            // 
            taskDescTXT.Location = new Point(484, 78);
            taskDescTXT.Multiline = true;
            taskDescTXT.Name = "taskDescTXT";
            taskDescTXT.Size = new Size(156, 64);
            taskDescTXT.TabIndex = 19;
            // 
            // taskNameTXT
            // 
            taskNameTXT.Location = new Point(484, 24);
            taskNameTXT.Name = "taskNameTXT";
            taskNameTXT.Size = new Size(100, 23);
            taskNameTXT.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(484, 60);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 18;
            label12.Text = "Task Description";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(484, 6);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 14;
            label14.Text = "Task Name";
            // 
            // peoplePage
            // 
            peoplePage.Controls.Add(peopleGroup);
            peoplePage.Controls.Add(addToGroupBTN);
            peoplePage.Controls.Add(label4);
            peoplePage.Controls.Add(PeopleBox);
            peoplePage.Controls.Add(addPerson);
            peoplePage.Controls.Add(ageTXT);
            peoplePage.Controls.Add(lastNameTXT);
            peoplePage.Controls.Add(firstNameTXT);
            peoplePage.Controls.Add(label7);
            peoplePage.Controls.Add(peopleDeleteBTN);
            peoplePage.Controls.Add(label8);
            peoplePage.Controls.Add(label9);
            peoplePage.Location = new Point(4, 24);
            peoplePage.Name = "peoplePage";
            peoplePage.Padding = new Padding(3);
            peoplePage.Size = new Size(771, 216);
            peoplePage.TabIndex = 1;
            peoplePage.Text = "People";
            peoplePage.UseVisualStyleBackColor = true;
            // 
            // peopleGroup
            // 
            peopleGroup.FormattingEnabled = true;
            peopleGroup.ItemHeight = 15;
            peopleGroup.Location = new Point(487, 6);
            peopleGroup.Name = "peopleGroup";
            peopleGroup.Size = new Size(120, 139);
            peopleGroup.TabIndex = 33;
            // 
            // addToGroupBTN
            // 
            addToGroupBTN.Location = new Point(487, 160);
            addToGroupBTN.Name = "addToGroupBTN";
            addToGroupBTN.Size = new Size(117, 23);
            addToGroupBTN.TabIndex = 32;
            addToGroupBTN.Text = "Add to group";
            addToGroupBTN.UseVisualStyleBackColor = true;
            addToGroupBTN.Click += addToGroupBTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 104);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 30;
            label4.Text = "Age";
            // 
            // PeopleBox
            // 
            PeopleBox.FormattingEnabled = true;
            PeopleBox.ItemHeight = 15;
            PeopleBox.Location = new Point(6, 6);
            PeopleBox.Name = "PeopleBox";
            PeopleBox.Size = new Size(472, 199);
            PeopleBox.TabIndex = 29;
            // 
            // addPerson
            // 
            addPerson.Location = new Point(654, 152);
            addPerson.Name = "addPerson";
            addPerson.Size = new Size(75, 23);
            addPerson.TabIndex = 28;
            addPerson.Text = "Add";
            addPerson.UseVisualStyleBackColor = true;
            addPerson.Click += addPerson_Click;
            // 
            // ageTXT
            // 
            ageTXT.Location = new Point(654, 122);
            ageTXT.Name = "ageTXT";
            ageTXT.Size = new Size(100, 23);
            ageTXT.TabIndex = 27;
            // 
            // lastNameTXT
            // 
            lastNameTXT.Location = new Point(654, 74);
            lastNameTXT.Name = "lastNameTXT";
            lastNameTXT.Size = new Size(100, 23);
            lastNameTXT.TabIndex = 17;
            // 
            // firstNameTXT
            // 
            firstNameTXT.Location = new Point(654, 26);
            firstNameTXT.Name = "firstNameTXT";
            firstNameTXT.Size = new Size(100, 23);
            firstNameTXT.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 110);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 26;
            label7.Text = "Age";
            // 
            // peopleDeleteBTN
            // 
            peopleDeleteBTN.ForeColor = Color.IndianRed;
            peopleDeleteBTN.Location = new Point(654, 181);
            peopleDeleteBTN.Name = "peopleDeleteBTN";
            peopleDeleteBTN.Size = new Size(75, 23);
            peopleDeleteBTN.TabIndex = 21;
            peopleDeleteBTN.Text = "Delete";
            peopleDeleteBTN.UseVisualStyleBackColor = true;
            peopleDeleteBTN.Click += peopleDeleteBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(654, 54);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 16;
            label8.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(654, 6);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 14;
            label9.Text = "First Name";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(groupPage);
            TabControl.Controls.Add(peoplePage);
            TabControl.Controls.Add(taskPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Location = new Point(12, 27);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(779, 244);
            TabControl.TabIndex = 2;
            // 
            // groupPage
            // 
            groupPage.Controls.Add(addGroup);
            groupPage.Controls.Add(groupCompletionLBL);
            groupPage.Controls.Add(label1);
            groupPage.Controls.Add(deleteGroupBTN);
            groupPage.Controls.Add(groupDescriptionTXT);
            groupPage.Controls.Add(groupAgeTXT);
            groupPage.Controls.Add(groupNameTXT);
            groupPage.Controls.Add(label3);
            groupPage.Controls.Add(label2);
            groupPage.Controls.Add(groupNameLBL);
            groupPage.Controls.Add(GroupList);
            groupPage.Location = new Point(4, 24);
            groupPage.Name = "groupPage";
            groupPage.Padding = new Padding(3);
            groupPage.Size = new Size(771, 216);
            groupPage.TabIndex = 0;
            groupPage.Text = "Groups";
            groupPage.UseVisualStyleBackColor = true;
            // 
            // addGroup
            // 
            addGroup.Location = new Point(484, 107);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(75, 23);
            addGroup.TabIndex = 13;
            addGroup.Text = "Add";
            addGroup.UseVisualStyleBackColor = true;
            addGroup.Click += addGroup_Click;
            // 
            // groupCompletionLBL
            // 
            groupCompletionLBL.AutoSize = true;
            groupCompletionLBL.Location = new Point(401, 163);
            groupCompletionLBL.Name = "groupCompletionLBL";
            groupCompletionLBL.Size = new Size(0, 15);
            groupCompletionLBL.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 163);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // deleteGroupBTN
            // 
            deleteGroupBTN.ForeColor = Color.IndianRed;
            deleteGroupBTN.Location = new Point(484, 136);
            deleteGroupBTN.Name = "deleteGroupBTN";
            deleteGroupBTN.Size = new Size(75, 23);
            deleteGroupBTN.TabIndex = 8;
            deleteGroupBTN.Text = "Delete";
            deleteGroupBTN.UseVisualStyleBackColor = true;
            deleteGroupBTN.Click += deleteGroupBTN_Click;
            // 
            // groupDescriptionTXT
            // 
            groupDescriptionTXT.Location = new Point(609, 24);
            groupDescriptionTXT.Multiline = true;
            groupDescriptionTXT.Name = "groupDescriptionTXT";
            groupDescriptionTXT.Size = new Size(156, 77);
            groupDescriptionTXT.TabIndex = 6;
            // 
            // groupAgeTXT
            // 
            groupAgeTXT.Location = new Point(484, 78);
            groupAgeTXT.Name = "groupAgeTXT";
            groupAgeTXT.Size = new Size(100, 23);
            groupAgeTXT.TabIndex = 4;
            // 
            // groupNameTXT
            // 
            groupNameTXT.Location = new Point(484, 24);
            groupNameTXT.Name = "groupNameTXT";
            groupNameTXT.Size = new Size(100, 23);
            groupNameTXT.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 6);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Group description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 60);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Age Range";
            // 
            // groupNameLBL
            // 
            groupNameLBL.AutoSize = true;
            groupNameLBL.Location = new Point(484, 6);
            groupNameLBL.Name = "groupNameLBL";
            groupNameLBL.Size = new Size(75, 15);
            groupNameLBL.TabIndex = 1;
            groupNameLBL.Text = "Group Name";
            // 
            // GroupList
            // 
            GroupList.ColumnWidth = 36;
            GroupList.FormattingEnabled = true;
            GroupList.ItemHeight = 15;
            GroupList.Location = new Point(6, 6);
            GroupList.MultiColumn = true;
            GroupList.Name = "GroupList";
            GroupList.Size = new Size(472, 199);
            GroupList.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ResolveBTN);
            tabPage1.Controls.Add(IssueBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 216);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Reported Issues";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResolveBTN
            // 
            ResolveBTN.Location = new Point(489, 6);
            ResolveBTN.Name = "ResolveBTN";
            ResolveBTN.Size = new Size(75, 23);
            ResolveBTN.TabIndex = 1;
            ResolveBTN.Text = "Resolve";
            ResolveBTN.UseVisualStyleBackColor = true;
            ResolveBTN.Click += ResolveBTN_Click;
            // 
            // IssueBox
            // 
            IssueBox.FormattingEnabled = true;
            IssueBox.ItemHeight = 15;
            IssueBox.Location = new Point(6, 6);
            IssueBox.Name = "IssueBox";
            IssueBox.Size = new Size(477, 184);
            IssueBox.TabIndex = 0;
            // 
            // projectManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 305);
            Controls.Add(TabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "projectManager";
            Text = "Project Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            taskPage.ResumeLayout(false);
            taskPage.PerformLayout();
            peoplePage.ResumeLayout(false);
            peoplePage.PerformLayout();
            TabControl.ResumeLayout(false);
            groupPage.ResumeLayout(false);
            groupPage.PerformLayout();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exportProjectToolStripMenuItem;
        private ToolStripMenuItem runTestToolStripMenuItem;
        private TabPage taskPage;
        private Button addTask;
        private Button taskDeleteBTN;
        private TextBox taskDescTXT;
        private TextBox taskNameTXT;
        private Label label12;
        private Label label14;
        private TabPage peoplePage;
        private Button addPerson;
        private TextBox ageTXT;
        private TextBox lastNameTXT;
        private TextBox firstNameTXT;
        private Label label7;
        private Button peopleDeleteBTN;
        private Label label8;
        private Label label9;
        private TabControl TabControl;
        private TabPage groupPage;
        private Button addGroup;
        private Label groupCompletionLBL;
        private Label label1;
        private Button deleteGroupBTN;
        private TextBox groupDescriptionTXT;
        private TextBox groupAgeTXT;
        private TextBox groupNameTXT;
        private Label label3;
        private Label label2;
        private Label groupNameLBL;
        private ListBox GroupList;
        private ListBox TaskBox;
        private ListBox PeopleBox;
        private Label label4;
        private TabPage tabPage1;
        private Button ResolveBTN;
        private ListBox IssueBox;
        private Button addToGroupBTN;
        private ListBox peopleGroup;
    }
}