using System.Collections.Generic;
using Fsm_Mk2;
using Ghost.WallGhost;
using UnityEngine;
using State = Fsm_Mk2.State;

namespace Ghost
{
    public class WallGhostAgent : MonoBehaviour
    {
        private List<State> _states = new List<State>();

        private Fsm _fsm;

        private Transition huntToCatch;
        private Transition catchToDead;

        private WallGhostCollision _wallGhostCollision;

        public void Start()
        {
            _wallGhostCollision = GetComponentInChildren<WallGhostCollision>();

            _wallGhostCollision.OnPlayerCollision += SetCatchState;

            State _hunt = new Hunt();
            _states.Add(_hunt);

            State _catch = new Catch();
            _states.Add(_hunt);

            State _dead = new Dead();
            _states.Add(_hunt);

            huntToCatch = new Transition() { From = _hunt, To = _catch };
            _hunt.transitions.Add(huntToCatch);

            catchToDead = new Transition() { From = _catch, To = _dead };
            _catch.transitions.Add(catchToDead);

            _fsm = new Fsm(_hunt);
        }

        private void SetCatchState()
        {
            _fsm.ApplyTransition(huntToCatch);
        }

        private void Update()
        {
            _fsm.Update();
        }

        private void FixedUpdate()
        {
            _fsm.FixedUpdate();
        }
    }
}