using System.Collections.Generic;
using Codebase.View;
using QuizGameCore;

namespace Codebase.Quiz
{
    public class TimedQuiz : IQuiz
    {
        private readonly Timer _timer;
        private readonly IQuiz _origin;
        private readonly int _rewardTime;

        public TimedQuiz(Timer timer, IQuiz origin, int rewardTime)
        {
            _timer = timer;
            _origin = origin;
            _rewardTime = rewardTime;
        }

        public string Question => _origin.Question;
        public IReadOnlyList<string> Variants => _origin.Variants;

        public bool Answer(string answer)
        {
            var result = _origin.Answer(answer);

            if (result)
            {
                _timer.AddTime(_rewardTime);
            }

            return result;
        }
    }
}