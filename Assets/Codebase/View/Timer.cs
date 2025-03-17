using System;
using UnityEngine;
using UnityEngine.UI;

namespace Codebase.View
{
    [RequireComponent(typeof(Slider))]
    public class Timer : MonoBehaviour
    {
        [SerializeField] private int _maxTime = 3;
        [SerializeField] private Gradient _gradient;
        [SerializeField] private Image _fillImage;
        private Slider _slider;
        public event Action TimerEnd;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.maxValue = _maxTime;
            _slider.value = _maxTime;
        }

        private void Update()
        {
            _slider.value -= Time.deltaTime;
            _fillImage.color = _gradient.Evaluate(_slider.value / _maxTime);

            if (_slider.value <= 0)
            {
                TimerEnd?.Invoke();
            }
        }

        public void AddTime(int time)
        {
            if (time < 0)
                return;

            _slider.value += time;
        }
    }
}