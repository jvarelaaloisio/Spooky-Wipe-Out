using System;
using UnityEngine;
using UnityEngine.UI;

namespace Minigames
{
    public class AD : Minigame
    {
        private Image _progressBar;
        
        [SerializeField] private float decreaseRate = 0.1f;
        [SerializeField] private float increaseAmount = 0.05f;
        [SerializeField] private float maxProgress = 1f;
        [SerializeField] private float minProgress = 0f;
        
        private bool _hasStarted;
        
        protected override void WinGame()
        {
            ResetGame();
        }
        protected override void LoseGame()
        {
            ResetGame();
        }

        private void Update()
        {
            OnTick();
        }

        private void OnTick()
        {
            if (!_hasStarted) return;
            _progressBar.fillAmount -= decreaseRate * Time.deltaTime;


            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                _hasStarted = true;
                _progressBar.fillAmount += increaseAmount;
            }

            if (_progressBar.fillAmount >= maxProgress)
            {
                _progressBar.fillAmount = maxProgress;
                WinGame();
            }
            else if (_progressBar.fillAmount <= minProgress)
            {
                _progressBar.fillAmount = minProgress;
                LoseGame();
            }
        }
        
        protected override void ResetGame()
        {
            if (_progressBar)
            {
                _progressBar.fillAmount = minProgress;
            }

            _hasStarted = false;
            _progressBar.enabled = false;
        }

        public override void StartGame()
        {
            _progressBar.fillAmount = minProgress;
            _progressBar.enabled = true;
            _hasStarted = true;
        }
    }
}
