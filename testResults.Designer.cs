namespace SpringCapstone
{
    partial class testResults
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
            Label1 = new Label();
            totalTimeLBL = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(27, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 15);
            Label1.TabIndex = 1;
            Label1.Text = "Total Time:";
            // 
            // totalTimeLBL
            // 
            totalTimeLBL.AutoSize = true;
            totalTimeLBL.Location = new Point(97, 20);
            totalTimeLBL.Name = "totalTimeLBL";
            totalTimeLBL.Size = new Size(0, 15);
            totalTimeLBL.TabIndex = 2;
            totalTimeLBL.Click += totalTimeLBL_Click;
            // 
            // button1
            // 
            button1.Location = new Point(194, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Finish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 54);
            Controls.Add(button1);
            Controls.Add(totalTimeLBL);
            Controls.Add(Label1);
            Name = "testResults";
            Text = "testResults";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label1;
        private Label totalTimeLBL;
        private Button button1;
    }
}