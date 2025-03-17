using System;
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
        

        public void Render(IQuiz value)
        {
            throw new NotImplementedException();
        }
    }
}