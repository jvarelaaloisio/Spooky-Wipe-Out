using Fsm_Mk2;
using UnityEngine;

namespace Ghosts.WallGhost
{
    public class Dead : State
    {
        GameObject _gameObject;

        public Dead(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public override void Enter()
        {
            _gameObject.SetActive(false);
        }

        public override void Tick(float delta)
        {
        }

        public override void FixedTick(float delta)
        {
            
        }

        public override void Exit()
        {
        }
    }
}
