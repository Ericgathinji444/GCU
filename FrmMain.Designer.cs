namespace PresentationLayer
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvProblems;
        private TextBox txtAnswer;
        private Button btnCheck;
        private Label lblFeedback;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProblems = new DataGridView();
            txtAnswer = new TextBox();
            btnCheck = new Button();
            lblFeedback = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvProblems).BeginInit();
            SuspendLayout();

            // dgvProblems
            dgvProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProblems.Columns.Add("Number1", "Number 1");
            dgvProblems.Columns.Add("Number2", "Number 2");
            dgvProblems.Columns.Add("Answer", "Your Answer");
            dgvProblems.Location = new Point(30, 30);
            dgvProblems.Size = new Size(400, 60);

            // txtAnswer
            txtAnswer.Location = new Point(30, 110);
            txtAnswer.Size = new Size(100, 23);

            // btnCheck
            btnCheck.Location = new Point(150, 110);
            btnCheck.Size = new Size(100, 23);
            btnCheck.Text = "Check";
            btnCheck.Click += btnCheck_Click;

            // lblFeedback
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(30, 150);
            lblFeedback.Size = new Size(300, 23);

            // FrmMain
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 200);
            Controls.Add(dgvProblems);
            Controls.Add(txtAnswer);
            Controls.Add(btnCheck);
            Controls.Add(lblFeedback);
            Name = "FrmMain";
            Text = "Addition Tutor";
            ((System.ComponentModel.ISupportInitialize)dgvProblems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}