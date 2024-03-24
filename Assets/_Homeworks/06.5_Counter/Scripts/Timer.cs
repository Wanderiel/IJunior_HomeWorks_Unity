using System.Collections;
using TMPro;
using UnityEngine;

namespace Counter
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private float _speed = 0.5f;

        private float _time;
        private int _score;
        private Coroutine _coroutine;

        private void Awake()
        {
            _score = 0;
            DisplayScore();
        }

        public void SwitchTick()
        {
            if (_coroutine != null)
            {
                StopTick();

                return;
            }

            _coroutine = StartCoroutine(TickCoroutine());
        }

        private IEnumerator TickCoroutine()
        {
            while (true)
            {
                _time += Time.deltaTime;
                Scoreup();
                DisplayScore();

                yield return null;
            }
        }

        private void StopTick()
        {
            StopCoroutine(_coroutine);

            _coroutine = null;
        }

        private void Scoreup()
        {
            if (_time > _speed)
            {
                _score++;
                _time -= _speed;
            }
        }

        private void DisplayScore() =>
            _text.text = _score.ToString();
    }
}
