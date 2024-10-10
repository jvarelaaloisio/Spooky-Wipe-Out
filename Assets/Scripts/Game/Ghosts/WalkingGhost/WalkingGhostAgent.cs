using System.Collections.Generic;
using Fsm_Mk2;
using Gameplay.GhostMechanics;
using Ghosts.WalkingGhost;
using Minigames;
using UnityEngine;
using UnityEngine.AI;
using State = Fsm_Mk2.State;

namespace Ghosts
{
    public class WalkingGhostAgent : Ghost, IVacuumable
    {
        [SerializeField] private Minigame minigame;
        [SerializeField] private RandomPatrolling patrolling;
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private GameObject model;
        
        private List<State> _states = new List<State>();

        private Fsm _fsm;

        private Transition _walkToStruggle;
        private Transition _struggleToCapture;
        private Transition _struggleToWalk;
        private Transition _struggleToFlee;
        private Transition _fleeToWalk;
        [SerializeField] private bool logFsmStateChanges = false;

        public void Start()
        {
            minigame.OnWin += SetCaptureState;
            minigame.OnLose += SetWalkState;

            GameManager.GetInstance().ghosts.Add(this);

            State _walk = new Walk(patrolling);
            _states.Add(_walk);

            State _struggle = new WalkingGhost.Struggle();
            _states.Add(_struggle);

            State _capture = new Capture(model, this, minigame);
            
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
            if (minigame.GetActive()) return;

            _fsm.ApplyTransition(_walkToStruggle);

            minigame.StartGame();
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
            if(logFsmStateChanges)
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

        public State GetCurrentState()
        {
            return _fsm.GetCurrentState();
        }
    }
}