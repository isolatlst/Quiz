using System.Collections.Generic;
using System.Linq;


namespace QuizGameCore
{
    public class Quiz : IQuiz
    {
        private readonly string correctAnswer;
        private readonly IReadOnlyList<string> garbage; //неправильные ответы


        public string Question { get; }


        public IReadOnlyList<string> Variants => garbage.Append(correctAnswer).ToList();


        public Quiz(string question, string correctAnswer, IReadOnlyList<string> garbage)
        {
            Question = question;
            this.correctAnswer = correctAnswer;
            this.garbage = garbage;
        }


        public bool Answer(string answer)
        {
            return correctAnswer == answer;
        }
    }
}