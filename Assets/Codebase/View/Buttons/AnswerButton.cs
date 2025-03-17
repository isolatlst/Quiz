using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Codebase.View.Buttons
{
    [RequireComponent(typeof(Button))]
    public class AnswerButton : MonoBehaviour, IView<string>
    {
        [SerializeField] private TextMeshProUGUI _text;
        public event Action<string> Clicked;

        private void Awake()
        {
            GetComponent<Button>()?.onClick.AddListener(() =>
            {
                if (_text.text != "" || _text.text != null)
                    Clicked?.Invoke(_text.text);
            });
        }

        public void Render(string value)
        {
            _text.text = value;
        }
    }
}