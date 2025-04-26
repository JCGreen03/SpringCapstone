namespace SpringCapstone
{
    partial class runningTest
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
            components = new System.ComponentModel.Container();
            StartStopBTN = new Button();
            label3 = new Label();
            label4 = new Label();
            timeLBL = new Label();
            taskNameLBL = new Label();
            reportBTN = new Button();
            nextTaskBTN = new Button();
            label1 = new Label();
            nameLBL = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartStopBTN
            // 
            StartStopBTN.Location = new Point(149, 9);
            StartStopBTN.Name = "StartStopBTN";
            StartStopBTN.Size = new Size(95, 28);
            StartStopBTN.TabIndex = 0;
            StartStopBTN.Text = "Start Test";
            StartStopBTN.UseVisualStyleBackColor = true;
            StartStopBTN.Click += StartStopBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Task:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 40);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Time:";
            // 
            // timeLBL
            // 
            timeLBL.AutoSize = true;
            timeLBL.Location = new Point(49, 40);
            timeLBL.Name = "timeLBL";
            timeLBL.Size = new Size(0, 15);
            timeLBL.TabIndex = 8;
            // 
            // taskNameLBL
            // 
            taskNameLBL.AutoSize = true;
            taskNameLBL.Location = new Point(45, 9);
            taskNameLBL.Name = "taskNameLBL";
            taskNameLBL.Size = new Size(36, 15);
            taskNameLBL.TabIndex = 7;
            taskNameLBL.Text = "None";
            // 
            // reportBTN
            // 
            reportBTN.Location = new Point(149, 51);
            reportBTN.Name = "reportBTN";
            reportBTN.Size = new Size(95, 28);
            reportBTN.TabIndex = 9;
            reportBTN.Text = "Report Issue";
            reportBTN.UseVisualStyleBackColor = true;
            reportBTN.Click += reportBTN_Click;
            // 
            // nextTaskBTN
            // 
            nextTaskBTN.Enabled = false;
            nextTaskBTN.Location = new Point(149, 93);
            nextTaskBTN.Name = "nextTaskBTN";
            nextTaskBTN.Size = new Size(95, 28);
            nextTaskBTN.TabIndex = 10;
            nextTaskBTN.Text = "Next Task";
            nextTaskBTN.UseVisualStyleBackColor = true;
            nextTaskBTN.Click += nextTaskBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 11;
            label1.Text = "Person:";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Location = new Point(59, 71);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(56, 15);
            nameLBL.TabIndex = 12;
            nameLBL.Text = "Last, First";
            // 
            // runningTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 127);
            Controls.Add(nameLBL);
            Controls.Add(label1);
            Controls.Add(nextTaskBTN);
            Controls.Add(reportBTN);
            Controls.Add(timeLBL);
            Controls.Add(taskNameLBL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StartStopBTN);
            Name = "runningTest";
            Text = "runningTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopBTN;
        private Label label3;
        private Label label4;
        private Label timeLBL;
        private Label taskNameLBL;
        private Button reportBTN;
        private Button nextTaskBTN;
        private Label label1;
        private Label nameLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}