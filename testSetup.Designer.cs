namespace SpringCapstone
{
    partial class testSetup
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
            GroupCheck = new CheckedListBox();
            label1 = new Label();
            startBTN = new Button();
            SuspendLayout();
            // 
            // GroupCheck
            // 
            GroupCheck.FormattingEnabled = true;
            GroupCheck.Location = new Point(12, 27);
            GroupCheck.Name = "GroupCheck";
            GroupCheck.Size = new Size(120, 94);
            GroupCheck.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Who will be testing?";
            // 
            // startBTN
            // 
            startBTN.Location = new Point(138, 98);
            startBTN.Name = "startBTN";
            startBTN.Size = new Size(75, 23);
            startBTN.TabIndex = 2;
            startBTN.Text = "Start";
            startBTN.UseVisualStyleBackColor = true;
            startBTN.Click += startBTN_Click;
            // 
            // testSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 138);
            Controls.Add(startBTN);
            Controls.Add(label1);
            Controls.Add(GroupCheck);
            Name = "testSetup";
            Text = "testSetup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox GroupCheck;
        private Label label1;
        private Button startBTN;
    }
}