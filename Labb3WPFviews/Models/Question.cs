namespace Labb3WPFviews.Models
{
    class Question
    {
        public string Statement { get; }
        public string[] Answers { get; }

        private readonly int correctAnswer;

        public int GetCorrectAnswer()
        {
            return correctAnswer;
        }
    }
}
