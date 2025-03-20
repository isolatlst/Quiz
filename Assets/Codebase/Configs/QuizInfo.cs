using QuizGameCore;
using UnityEngine;

namespace Codebase.Configs
{
    [CreateAssetMenu(fileName = "QuizInfo", menuName = "Quiz Info")]
    public class QuizInfo : ScriptableObject
    {
        [SerializeField] private string _question;
        [SerializeField] private string _correctAnswer;
        [SerializeField] private string[] _wrongAnswers;

        public IQuiz GetQuiz() => new QuizGameCore.Quiz(_question, _correctAnswer, _wrongAnswers);
    }
}