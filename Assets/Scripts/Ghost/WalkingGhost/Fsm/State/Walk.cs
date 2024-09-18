using Fsm_Mk2;
using Gameplay.GhostMechanics;

namespace Ghost.WalkingGhost
{
    public class Walk : State
    {
        private RandomPatrolling randomPatrolling;

        public Walk(RandomPatrolling randomPatrolling)
        {
            this.randomPatrolling = randomPatrolling;
        }

        public override void Enter()
        {
            randomPatrolling.enabled = true;
        }

        public override void Tick(float delta)
        {

        }

        public override void FixedTick(float delta)
        {

        }

        public override void Exit()
        {
            randomPatrolling.enabled = false;
        }
    }
}
