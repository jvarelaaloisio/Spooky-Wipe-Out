using System;
using System.Collections.Generic;
using Minigames;
using Player.FSM;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using VacuumCleaner;


namespace Fsm_Mk2
{
    public class PlayerAgent : MonoBehaviour
    {
        public Action<Transform> OnHunted;
        public Action<Transform> OnStruggle;

        private List<State> _states = new List<State>();

        [SerializeField] private InputReader inputReader;
        [SerializeField] private WalkIdleModel walkIdleModel;
        [SerializeField] private GameObject playerModel;

        [SerializeField] private ADController adController;
        [SerializeField] private SkillCheckController skillCheckController;

        [SerializeField] private CleanerController cleanerController;
        
        [SerializeField] private LayerMask layerRaycast;
        
        private Fsm _fsm;

        private Transition _walkIdleToTrapped;
        private Transition _walkIdleToWalkIdle;
        private Transition _trappedToWalkIdle;
        private Transition _walkIdleToClean;


        public void Start()
        {
            inputReader.OnMove += SetMoveStateDirection;
            OnHunted += SetTrappedState;
            adController.OnLose += SetTrappedToMoveState;
            adController.OnWin += SetTrappedToMoveState;

            inputReader.OnCleanerStart += SetCleanerVacuumMode;
            // inputReader.OnCleanerStart += ChangeRotation;
            // inputReader.OnCleanerPerform += ChangeRotation;
            inputReader.OnCleanerEnd += SetCleanerIdleMode;

            State _walkIdle = new WalkIdle(playerModel, walkIdleModel, layerRaycast);
            _states.Add(_walkIdle);

            State _trapped = new Trapped(playerModel);
            _states.Add(_trapped);

            State _clean = new Clean();
            _states.Add(_clean);

            _walkIdleToTrapped = new Transition() { From = _walkIdle, To = _trapped };
            _walkIdle.transitions.Add(_walkIdleToTrapped);

            _walkIdleToWalkIdle = new Transition() { From = _walkIdle, To = _walkIdle };
            _walkIdle.transitions.Add(_walkIdleToWalkIdle);

            _trappedToWalkIdle = new Transition() { From = _trapped, To = _walkIdle };
            _trapped.transitions.Add(_trappedToWalkIdle);

            _walkIdleToClean = new Transition() { From = _walkIdle, To = _clean };
            _clean.transitions.Add(_walkIdleToClean);

            _fsm = new Fsm(_walkIdle);
        }

        private void SetMoveStateDirection(Vector2 direction, bool shouldRot)
        {
            //                                  Local direction (in relation to the world)
            Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
            var cameraTransform = Camera.main.transform;
            //                                      World direction (passed through the camera transform matrix)
            var cameraBasedMoveDirection = cameraTransform.TransformDirection(moveDirection);
            cameraBasedMoveDirection.y = 0;
     
            bool stateFound = false;

            foreach (var state in _states)
            {
                if (_fsm.GetCurrentState() == state)
                {
                    if (state is WalkIdle walkIdle)
                    {
                        _fsm.ApplyTransition(_walkIdleToWalkIdle);
                        walkIdle.SetDir(cameraBasedMoveDirection, shouldRot);
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

        private void SetCleanerVacuumMode()
        {
            cleanerController.SwitchToTool(1);
        }
        
        private void SetCleanerIdleMode()
        {
            cleanerController.SwitchToTool(0);
        }
        
        // private void ChangeRotation()
        // {
        //     if (!Camera.main) return;
        //     
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit hit;
        //     
        //     if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerRaycast))
        //     {
        //         Vector3 targetPosition = new Vector3(hit.point.x, playerModel.transform.position.y, hit.point.z);
        //
        //         Vector3 direction = targetPosition - playerModel.transform.position;
        //         Quaternion actualRotation = playerModel.transform.rotation;
        //         float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //         Quaternion targetRotation = Quaternion.Euler(0f, rotationAngle, 0f);
        //
        //         playerModel.transform.rotation = targetRotation;
        //     }
        // }
        
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