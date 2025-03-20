using System.Collections;
using Codebase.Quiz;
using Codebase.View;
using QuizGameCore.Utils;
using UnityEngine;

namespace Codebase
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private QuizView _quizView;

        private IEnumerator Start()
        {
            var timerFail = WaitFail(new IFail.Any(new TimerFail(_timer)));
            foreach (var info in GetComponent<IQuizSource>().QuizList)
            {
                _quizView.Render(new AwaitCurrentAnswerQuiz(new TimedQuiz(_timer, info, 5)).Cache(out var quiz));
                yield return WaitAny(quiz.WaitCorrect(), timerFail);
            }
        }

        private IEnumerator WaitAny(params IEnumerator[] items)
        {
            bool doneAny = false;

            IEnumerator WaitDone(IEnumerator enumerator)
            {
                yield return enumerator;
                doneAny = true;
            }

            foreach (var item in items)
            {
                StartCoroutine(WaitDone(item));
            }

            while (doneAny == false)
            {
                yield return null;
            }
        }

        private IEnumerator WaitFail(IFail fail)
        {
            while (fail.Failed == false)
            {
                yield return null;
            }
        }
    }
}