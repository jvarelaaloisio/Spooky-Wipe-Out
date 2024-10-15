using Fsm_Mk2;
using Gameplay.GhostMechanics;

namespace Ghosts.WalkingGhost
{
    public class Walk : State
    {
        private GhostPatrolling _ghostPatrolling;

        public Walk(GhostPatrolling patrolling)
        {
            this._ghostPatrolling = patrolling;
        }

        public override void Enter()
        {
            _ghostPatrolling.enabled = true;
        }

        public override void Tick(float delta)
        {

        }

        public override void FixedTick(float delta)
        {

        }

        public override void Exit()
        {
            _ghostPatrolling.enabled = false;
        }
    }
}
