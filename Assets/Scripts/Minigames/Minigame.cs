using System;

namespace Minigames
{
    public abstract class Minigame
    {
        public Action OnWin;
        public Action OnLose;

        public virtual void WinGame() => OnWin?.Invoke();
        public virtual void LoseGame() => OnLose?.Invoke();
        public abstract void ResetGame();
        public abstract void StartGame();
    }
}