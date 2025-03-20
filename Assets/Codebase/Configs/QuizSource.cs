using System.Collections.Generic;
using System.Linq;
using Codebase.Quiz;
using QuizGameCore;
using UnityEngine;

namespace Codebase.Configs
{
    public class QuizSource : MonoBehaviour, IQuizSource
    {
        [SerializeField] private List<QuizInfo> _quizInfos;

        public List<IQuiz> QuizList
        {
            get => _quizInfos.Select(x => x.GetQuiz()).ToList();
        }
    }
}