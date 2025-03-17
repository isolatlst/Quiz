using System.Collections.Generic;


namespace QuizGameCore
{
    public interface IQuiz
    {
        string Question { get; }


        IReadOnlyList<string> Variants { get; }


        bool Answer(string answer);
    }
}