using Codebase.View;

namespace Codebase.Quiz
{
    public class TimerFail : IFail
    {
        private readonly Timer _timer;
        public bool Failed => _timer.RemainigTime <= 0;

        public TimerFail(Timer timer)
        {
            _timer = timer;
        }
    }
}