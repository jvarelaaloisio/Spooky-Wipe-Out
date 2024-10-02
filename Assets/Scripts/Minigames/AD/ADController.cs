using UnityEngine;

namespace Minigames
{
    public class ADController : Minigame
    {
        [SerializeField] private AD ad;
    
        [SerializeField] private float decreaseRate = 0.1f;
        [SerializeField] private float increaseAmount = 0.15f;
        [SerializeField] private float maxProgress = 1f;
        [SerializeField] private float minProgress = 0f;
        
        private bool _hasStarted = false;
        private bool _runMinigame;
        
        protected override void WinGame()
        {
            ResetGame();
            OnWin?.Invoke();
        }
        protected override void LoseGame()
        {
            ResetGame();
            OnLose?.Invoke();
        }

        private void Update()
        {
            OnTick();
        }

        private void OnTick()
        {
            if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && _runMinigame)
            {
                _hasStarted = true;
                ad.progressBar.fillAmount += increaseAmount;
            }
            
            if (!_hasStarted) return;
            
            if (ad.progressBar.fillAmount >= maxProgress)
            {
                ad.progressBar.fillAmount = maxProgress;
                WinGame();
            }
            else if (ad.progressBar.fillAmount <= minProgress)
            {
                ad.progressBar.fillAmount = minProgress;
                LoseGame();
            }
           
            ad.progressBar.fillAmount -= decreaseRate * Time.deltaTime;
        }
        
        protected override void ResetGame()
        {
            if (ad.progressBar)
            {
                ad.progressBar.fillAmount = minProgress;
            }

            _hasStarted = false;
            _runMinigame = false;
            ad.gameObject.SetActive(false);
        }

        public override void StartGame()
        {
            OnStart?.Invoke();
            ad.gameObject.SetActive(true);
            ad.progressBar.fillAmount = minProgress;
            _runMinigame = true;
        }

        public override void StopGame()
        {
            if(_runMinigame)
            {
                OnStop?.Invoke();
                ResetGame();
            }
        }
    }
}
