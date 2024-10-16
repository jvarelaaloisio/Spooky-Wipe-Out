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
        public Action OnJumpStart;
        public Action OnPauseStart;

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
                OnJumpStart?.Invoke();
            }
        }
        
        public void HandlePause(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnPauseStart?.Invoke();
            }
        }
    }
}
