namespace BusinessLayer
{
    public class AdditionProblem
    {
        public int Number1 { get; private set; }
        public int Number2 { get; private set; }

        private static readonly Random rand = new();

        public AdditionProblem()
        {
            GenerateNewProblem();
        }

        public void GenerateNewProblem()
        {
            Number1 = rand.Next(100, 501);
            Number2 = rand.Next(100, 501);
        }

        public int GetCorrectAnswer() => Number1 + Number2;

        public bool CheckAnswer(int userAnswer) => userAnswer == GetCorrectAnswer();
    }
}