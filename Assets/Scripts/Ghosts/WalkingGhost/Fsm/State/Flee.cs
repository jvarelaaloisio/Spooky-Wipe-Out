using Fsm_Mk2;
using UnityEngine;

namespace Ghosts.WalkingGhost
{
    public class Flee : State
    {
        private GhostFlee _ghostFlee;

        public Flee(GhostFlee flee)
        {
            this._ghostFlee = flee;
        }

        public override void Enter()
        {
            //Debug.Log("Entro al enter de flee");
            _ghostFlee.enabled = true;
        }

        public override void Tick(float delta)
        {

        }

        public override void FixedTick(float delta)
        {

        }

        public override void Exit()
        {
            //Debug.Log("Entro al exit de flee");
            _ghostFlee.enabled = false;
        }
    }
}
