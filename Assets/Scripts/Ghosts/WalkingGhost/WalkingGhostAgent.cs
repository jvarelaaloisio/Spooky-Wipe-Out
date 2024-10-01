using System.Collections.Generic;
using Fsm_Mk2;
using Gameplay.GhostMechanics;
using Ghosts.WalkingGhost;
using UnityEngine;
using State = Fsm_Mk2.State;

namespace Ghosts
{
    public class WalkingGhostAgent : Ghost, IVacuumable
    {
        [SerializeField] private SkillCheckController minigame;
        [SerializeField] private RandomPatrolling patrolling;

        private List<State> _states = new List<State>();

        private Fsm _fsm;

        private Transition _walkToStruggle;
        private Transition _struggleToCapture;
        private Transition _struggleToWalk;
        private Transition _struggleToFlee;
        private Transition _fleeToWalk;
        
        bool minigameActive = false;

        public void Start()
        {
            minigame.OnWin += SetCaptureState;
            minigame.OnWin += ResetMinigame;
            minigame.OnLose += SetWalkState;
            minigame.OnLose += ResetMinigame;

            GameManager.GetInstance().ghosts.Add(this);

            State _walk = new Walk(patrolling);
            _states.Add(_walk);

            State _struggle = new Struggle();
            _states.Add(_struggle);

            State _capture = new Capture();
            _states.Add(_capture);

            State _flee = new Flee();
            _states.Add(_flee);

            _walkToStruggle = new Transition() { From = _walk, To = _struggle };
            _walk.transitions.Add(_walkToStruggle);

            _struggleToCapture = new Transition() { From = _struggle, To = _capture };
            _struggle.transitions.Add(_struggleToCapture);

            _struggleToFlee = new Transition() { From = _struggle, To = _flee };
            _struggle.transitions.Add(_struggleToFlee);
            
            _struggleToWalk = new Transition() { From = _struggle, To = _walk };
            _struggle.transitions.Add(_struggleToWalk);

            _fleeToWalk = new Transition() { From = _flee, To = _walk };
            _flee.transitions.Add(_fleeToWalk);
            
            _fsm = new Fsm(_walk);
        }

        private void SetStruggleState()
        {
            _fsm.ApplyTransition(_walkToStruggle);

            if (minigameActive) return;
            
            minigame.StartGame();
            minigameActive = true;

        }

        private void ResetMinigame()
        {
            minigameActive = false;
        }

        private void SetCaptureState()
        {
            _fsm.ApplyTransition(_struggleToCapture);
        }

        private void SetFleeState()
        {
            _fsm.ApplyTransition(_struggleToFlee);
        }

        private void SetWalkState()
        {
            _fsm.ApplyTransition(_struggleToWalk);
        }

        private void Update()
        {
            _fsm.Update();
            Debug.Log(_fsm.GetCurrentState());
        }

        private void FixedUpdate()
        {
            _fsm.FixedUpdate();
        }

        public void IsBeingVacuumed(params object[] args)
        {
            SetStruggleState();
        }
    }
}
