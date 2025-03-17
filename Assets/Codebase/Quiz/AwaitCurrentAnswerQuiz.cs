using System.Collections;
using System.Collections.Generic;
using QuizGameCore;
using QuizGameCore.Utils;

namespace Codebase.Quiz
{
    public class AwaitCurrentAnswerQuiz : IQuiz
    {
        private IQuiz _origin;
        private bool _isCorrect;
        private readonly IReadOnlyList<string> _variants;

        public AwaitCurrentAnswerQuiz(IQuiz origin)
        {
            _origin = origin;
        }

        public string Question => _origin.Question;
        public IReadOnlyList<string> Variants => _origin.Variants;

        public bool Answer(string answer)
        {
            if (_origin.Answer(answer).Cache(out var result))
            {
                _isCorrect = true;
            }

            return result;
        }


        public IEnumerator WaitCorrect()
        {
            while (_isCorrect == false)
            {
                yield return null;
            }
        }
    }
}