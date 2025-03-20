using System.Collections.Generic;
using Codebase.Generic;
using Codebase.View.Buttons;
using QuizGameCore;
using TMPro;
using UnityEngine;

namespace Codebase.View
{
    public class QuizView : MonoBehaviour, IView<IQuiz>
    {
        [SerializeField] private TextMeshProUGUI _questionText;
        [SerializeField] private AnswerButton _answerTemplate;
        [SerializeField] private Transform _answersContainer;
        
        private ObjectPool<AnswerButton> _answerButtonPool;
        private IList<AnswerButton> _activeButtons = new List<AnswerButton>();
        private IQuiz _currentQuiz;

        public void Start()
        {
            _answerButtonPool = new ObjectPool<AnswerButton>(
                _currentQuiz?.Variants.Count ?? 5, // <- magic number, i know
                () =>
                {
                    var answ = Instantiate(_answerTemplate, _answersContainer);
                    answ.Clicked += (string answer) =>
                    {
                        bool isCorrect = _currentQuiz.Answer(answer);
                    };
                    return answ;
                },
                (AnswerButton btn) => btn.gameObject.SetActive(false),
                (AnswerButton btn) => btn.gameObject.SetActive(true)
            );
        }

        public void Render(IQuiz quizForRendering)
        {
            _currentQuiz = quizForRendering;
            
            _questionText.text = quizForRendering.Question;
            
            foreach (var button in _activeButtons)
                _answerButtonPool.Push(button);
            
            _activeButtons.Clear();

            foreach (var variant in _currentQuiz.Variants)
            {
                var answer = _answerButtonPool.Pop();
                _activeButtons.Add(answer);
                answer.Render(variant);
            }
        }
    }
}