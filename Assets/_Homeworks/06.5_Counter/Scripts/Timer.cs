using System.Collections;
using TMPro;
using UnityEngine;

namespace Counter
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private float _speed = 0.5f;

        private int _score;
        private WaitForSeconds _wait;
        private Coroutine _coroutine;

        private void Awake()
        {
            _score = 0;
            _wait = new WaitForSeconds(_speed);
            DisplayScore();
        }

        public void SwitchTicking()
        {
            if (_coroutine != null)
            {
                StopTicking();

                return;
            }

            _coroutine = StartCoroutine(Ticking());
        }

        private IEnumerator Ticking()
        {
            while (true)
            {
                _score++;
                DisplayScore();

                yield return _wait;
            }
        }

        private void StopTicking()
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }

        private void DisplayScore() =>
            _text.text = _score.ToString();
    }
}
