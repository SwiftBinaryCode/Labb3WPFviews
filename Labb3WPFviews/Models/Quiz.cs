using System.Collections;

namespace Labb3WPFviews.Models
{
    class Quiz
    {
        public ICollection Questions { get; }
        public string Title { get; }


        public Question GetRandomQuestion()
        {

        }
        public void AddQuestion(string statement, params string[] answers, int correctAnser)
        {

        }
        public void RemoveQuestion(int index)
        {

        }
    }
}
