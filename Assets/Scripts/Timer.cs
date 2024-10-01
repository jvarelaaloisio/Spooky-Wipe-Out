using TMPro;
using UnityEngine;

namespace Gameplay.Timer
{
    enum CountType
    {
        CountDown,
        CountUp
    };

    public class Timer : MonoBehaviour
    {
        public TextMeshProUGUI textTimer;
        [SerializeField] private float startTime;
        [SerializeField] private float objectiveTime;
        [SerializeField] private CountType countType;

        private float _timer;
        public bool finished;

        private void Start()
        {
            _timer = startTime;
            finished = false;
        }

        private void Update()
        {
            if (countType == CountType.CountUp)
            {
                _timer += Time.deltaTime;
            }
            else if (countType == CountType.CountDown)
            {
                _timer -= Time.deltaTime;
            }

            int minutes = (int)_timer / 60;
            int seconds = (int)_timer % 60;

            if (seconds >= 10)
            {
                textTimer.text = minutes + ":" + seconds;
            }
            else
            {
                textTimer.text = minutes + ":0" + seconds;
            }

            if (Mathf.Approximately(_timer, objectiveTime))
            {
                finished = true;
            }
        }

        public float GetTime()
        {
            return _timer;
        }
    }
}