using System;
using EventSystems.EventSceneManager;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.FSM
{
    public class InputReader : MonoBehaviour
    {
        public Action<Vector2> OnMove;
        public Action<Vector2> OnAimingVacuum;
        public Action<bool> OnClick;
        public Action OnClickStart;
        public Action OnClickPerform;
        public Action OnClickEnd;
        public Action OnSwitchTool;
        public Action OnSpaceInputStart;
        public Action OnPauseStart;
        public Action OnSeeTimerStart;
        public Action OnSeeTasksStart;

        public void HandleMoveInput(InputAction.CallbackContext context)
        {
            OnMove?.Invoke(context.ReadValue<Vector2>());
        }

        public void HandleMouseInput(InputAction.CallbackContext context)
        {
            OnAimingVacuum?.Invoke(context.ReadValue<Vector2>());
        }

        public void HandleClickInput(InputAction.CallbackContext context)
        {
            OnClick?.Invoke(context.performed);

            if (context.started)
            {
                OnClickStart?.Invoke();
            }

            if (context.performed)
            {
                OnClickPerform?.Invoke();
            }

            if (context.canceled)
            {
                OnClickEnd?.Invoke();
            }
        }

        public void HandleSwitchTool(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnSwitchTool?.Invoke();
            }
        }

        public void HandleSpaceInput(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnSpaceInputStart?.Invoke();
            }
        }
        
        public void HandlePause(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnPauseStart?.Invoke();
            }
        }

        public void HandleTimerUI(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnSeeTimerStart?.Invoke();
            }
        }

        public void HandleTasksUI(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnSeeTasksStart?.Invoke();
            }
        }
    }
}
