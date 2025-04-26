namespace SpringCapstone
{
    partial class bugReport
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
            issueReportTXT = new TextBox();
            cancelreportBTN = new Button();
            issueLBL = new Label();
            finishReportBTN = new Button();
            SuspendLayout();
            // 
            // issueReportTXT
            // 
            issueReportTXT.Location = new Point(12, 38);
            issueReportTXT.Multiline = true;
            issueReportTXT.Name = "issueReportTXT";
            issueReportTXT.Size = new Size(199, 127);
            issueReportTXT.TabIndex = 0;
            // 
            // cancelreportBTN
            // 
            cancelreportBTN.Location = new Point(237, 113);
            cancelreportBTN.Name = "cancelreportBTN";
            cancelreportBTN.Size = new Size(75, 23);
            cancelreportBTN.TabIndex = 1;
            cancelreportBTN.Text = "Cancel";
            cancelreportBTN.UseVisualStyleBackColor = true;
            // 
            // issueLBL
            // 
            issueLBL.AutoSize = true;
            issueLBL.Location = new Point(12, 9);
            issueLBL.Name = "issueLBL";
            issueLBL.Size = new Size(100, 15);
            issueLBL.TabIndex = 2;
            issueLBL.Text = "What is the issue?";
            // 
            // finishReportBTN
            // 
            finishReportBTN.Location = new Point(237, 142);
            finishReportBTN.Name = "finishReportBTN";
            finishReportBTN.Size = new Size(75, 23);
            finishReportBTN.TabIndex = 3;
            finishReportBTN.Text = "Report";
            finishReportBTN.UseVisualStyleBackColor = true;
            finishReportBTN.Click += finishReportBTN_Click;
            // 
            // bugReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 177);
            Controls.Add(finishReportBTN);
            Controls.Add(issueLBL);
            Controls.Add(cancelreportBTN);
            Controls.Add(issueReportTXT);
            Name = "bugReport";
            Text = "bugReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox issueReportTXT;
        private Button cancelreportBTN;
        private Label issueLBL;
        private Button finishReportBTN;
    }
}