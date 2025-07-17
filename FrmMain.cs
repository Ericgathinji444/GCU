using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        private AdditionProblem currentProblem;

        public FrmMain()
        {
            InitializeComponent();
            currentProblem = new AdditionProblem();
            DisplayProblem();
        }

        private void DisplayProblem()
        {
            dgvProblems.Rows.Clear();
            dgvProblems.Rows.Add(currentProblem.Number1, currentProblem.Number2, "?");
            txtAnswer.Clear();
            lblFeedback.Text = "";
            txtAnswer.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnswer.Text, out int userAnswer))
            {
                bool isCorrect = currentProblem.CheckAnswer(userAnswer);
                dgvProblems.Rows[0].Cells[2].Value = userAnswer;
                lblFeedback.Text = isCorrect ? "✅ Correct!" : $"❌ Incorrect. Answer: {currentProblem.GetCorrectAnswer()}";

                currentProblem.GenerateNewProblem();
                DisplayProblem();
            }
            else
            {
                lblFeedback.Text = "❗ Please enter a valid number.";
            }
        }
    }
}