using System;
using UnityEngine;

namespace Minigames
{
    public abstract class Minigame: MonoBehaviour
    {
        public Action OnWin;
        public Action OnLose;
        protected virtual void WinGame() => OnWin?.Invoke();
        protected virtual void LoseGame() => OnLose?.Invoke();
        protected abstract void ResetGame();
        public abstract void StartGame();
    }
}