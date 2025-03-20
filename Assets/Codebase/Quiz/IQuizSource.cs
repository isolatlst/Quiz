using System.Collections.Generic;
using QuizGameCore;

namespace Codebase.Quiz
{
    public interface IQuizSource
    {
        public List<IQuiz> QuizList { get; }
    }
}