using UnityEngine;

namespace Minigames
{
    public class ADController : Minigame
    {
        [SerializeField] private AD ad;
    
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
            
            ad.progressBar.fillAmount -= decreaseRate * Time.deltaTime;
            
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                _hasStarted = true;
                ad.progressBar.fillAmount += increaseAmount;
            }

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
        }
        
        protected override void ResetGame()
        {
            if (ad.progressBar)
            {
                ad.progressBar.fillAmount = minProgress;
            }

            _hasStarted = false;
            ad.gameObject.SetActive(false);
        }

        public override void StartGame()
        {
            ad.gameObject.SetActive(true);
            _hasStarted = true;
        }
    }
}