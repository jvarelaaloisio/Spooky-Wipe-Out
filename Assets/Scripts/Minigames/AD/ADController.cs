using System;
using System.Collections;
using Player.FSM;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace Minigames
{
    public class ADController : Minigame
    {
        [SerializeField] InputReader inputReader;

        [SerializeField] private AD ad;

        [SerializeField] private float decreaseRate = 0.1f;
        [SerializeField] private float increaseAmount = 0.15f;
        [SerializeField] private float maxProgress = 1f;
        [SerializeField] private float minProgress = 0f;
        [SerializeField] private float threshold = 0.8f;
        [SerializeField] private float decreaseRateMultiplier = 1.0f;
        [SerializeField] private float maxAfkTime = 5.0f;

        [SerializeField] private AnimationCurve defillCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
        private float progress { get; set; } = 0.0f;
        private float _expectedSign = 1.0f;
        private float _lastSuccessfulInputTime = -1f;

        private bool HasPlayerWon => progress >= maxProgress;

        private bool HasPlayerLost => progress <= minProgress;

        public override void StartGame()
        {
            OnStart?.Invoke();
            ad.gameObject.SetActive(true);
            
            progress = minProgress;
            inputReader.OnMove += HandleInput;
            _lastSuccessfulInputTime = Time.time;
            StartCoroutine(DecreaseProgressOverTime());
        }

        public override void StopGame()
        {
            OnStop?.Invoke();
            ResetGame();
        }

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

        protected override void ResetGame()
        {
            StopCoroutine(nameof(DecreaseProgressOverTime));

            progress = minProgress;
            ad.gameObject.SetActive(false);
            inputReader.OnMove -= HandleInput;
        }

        private void HandleInput(Vector2 inputDirection, bool shouldRot)
        {
            Debug.Log($"{name}: Input received -> {inputDirection.x}");

            float absDirection = Mathf.Abs(inputDirection.x);
            float directionSign = Mathf.Sign(inputDirection.x);

            if (Mathf.Approximately(directionSign, _expectedSign) && absDirection >= threshold)
            {
                UpdateProgress(progress + increaseAmount);
                _expectedSign *= -1;
                _lastSuccessfulInputTime = Time.time;
            }
        }

        private void UpdateProgress(float value)
        {
            Debug.Log($"{name}: Current progress -> {value}");
            progress = value;
            if (HasPlayerWon)
                WinGame();
            else if (HasPlayerLost && maxAfkTime <= _lastSuccessfulInputTime - Time.time)
                LoseGame();

            ad.SetProgressBarFill(progress);
        }

        private IEnumerator DecreaseProgressOverTime()
        {
            while (!destroyCancellationToken.IsCancellationRequested)
            {
                DecreaseProgress();
                yield return null;
            }
        }

        private void DecreaseProgress()
        {
            float curveValue = defillCurve.Evaluate(progress);
            Debug.Log($"{name}: ProgressDecreaseCurve({progress}) = {curveValue}");
            var decreaseAmount = Mathf.Clamp(
                progress - decreaseRate * Time.deltaTime * curveValue,
                minProgress, maxProgress);

            UpdateProgress(decreaseAmount);
        }
    }
}