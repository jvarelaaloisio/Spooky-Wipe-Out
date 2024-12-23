using System;
using UnityEngine;
using UnityEngine.Events;

namespace Minigames
{
    public abstract class Minigame: MonoBehaviour
    {
        public Action OnWin;
        public Action OnLose;
        public Action OnStart;
        public Action OnStop;

        protected bool _isActive;

        public bool GetActive() => _isActive;

        protected virtual void WinGame() => OnWin?.Invoke();
        protected virtual void LoseGame() => OnLose?.Invoke();
        protected abstract void ResetGame();
        public abstract void StartGame();
        public abstract void StopGame();
    }
}