using System;
using System.Collections.Generic;
using Minigames;
using Player.FSM;
using UnityEngine;


namespace Fsm_Mk2
{
    public class PlayerAgent : MonoBehaviour
    {
        public Action<Transform> OnHunted;

        private List<State> _states = new List<State>();

        [SerializeField] private InputReaderFsm inputReaderFsm;
        [SerializeField] private WalkIdleModel walkIdleModel;
        [SerializeField] private GameObject playerModel;

        [SerializeField] private ADController adController;
        [SerializeField] private SkillCheckController skillCheckController;

        private Fsm _fsm;

        private Transition _walkIdleToTrapped;
        private Transition _walkIdleToWalkIdle;
        private Transition _trappedToWalkIdle;


        public void Start()
        {
            inputReaderFsm.OnMove += SetMoveStateDirection;
            OnHunted += SetTrappedState;
            adController.OnLose += SetTrappedToMoveState;
            adController.OnWin += SetTrappedToMoveState;

            State _walkIdle = new WalkIdle(playerModel, walkIdleModel);
            _states.Add(_walkIdle);

            State _trapped = new Trapped(playerModel);
            _states.Add(_trapped);

            _walkIdleToTrapped = new Transition() { From = _walkIdle, To = _trapped };
            _walkIdle.transitions.Add(_walkIdleToTrapped);

            _walkIdleToWalkIdle = new Transition() { From = _walkIdle, To = _walkIdle };
            _walkIdle.transitions.Add(_walkIdleToWalkIdle);

            _trappedToWalkIdle = new Transition() { From = _trapped, To = _walkIdle };
            _trapped.transitions.Add(_trappedToWalkIdle);

            _fsm = new Fsm(_walkIdle);
        }

        private void SetMoveStateDirection(Vector2 direction, bool shouldRot)
        {
            Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);

            bool stateFound = false;

            foreach (var state in _states)
            {
                if (_fsm.GetCurrentState() == state)
                {
                    if (state is WalkIdle walkIdle)
                    {
                        _fsm.ApplyTransition(_walkIdleToWalkIdle);
                        walkIdle.SetDir(moveDirection, shouldRot);
                        stateFound = true;
                        break;
                    }
                }
            }

            if (!stateFound)
            {
                Debug.Log("Current state not found in the list of states.");
            }
        }

        private void SetTrappedState(Transform trappedPos)
        {
            _fsm.ApplyTransition(_walkIdleToTrapped);

            bool stateFound = false;

            foreach (var state in _states)
            {
                if (_fsm.GetCurrentState() == state)
                {
                    if (state is Trapped trapped)
                    {
                        trapped.SetPos(trappedPos);
                        stateFound = true;
                        break;
                    }
                }
            }

            if (!stateFound)
            {
                Debug.Log("Current state not found in the list of states.");
            }
        }

        private void SetTrappedToMoveState()
        {
            _fsm.ApplyTransition(_trappedToWalkIdle);
            
            bool stateFound = false;

            foreach (var state in _states)
            {
                if (_fsm.GetCurrentState() == state)
                {
                    if (state is WalkIdle walkIdle)
                    {
                        _fsm.ApplyTransition(_walkIdleToWalkIdle);
                        walkIdle.SetDir(Vector2.zero,false );
                        stateFound = true;
                        break;
                    }
                }
            }

            if (!stateFound)
            {
                Debug.Log("Current state not found in the list of states.");
            }
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
    }
}