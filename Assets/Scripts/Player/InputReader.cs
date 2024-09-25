using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.FSM
{
    public class InputReader : MonoBehaviour
    {
        public Action<Vector2,bool> OnMove;
        public Action OnCleanerStart;
        public Action OnCleanerPerform;
        public Action OnCleanerEnd;
        public Action OnSwitchTool;

        public void HandleMoveInput(InputAction.CallbackContext context)
        {
            OnMove?.Invoke(context.ReadValue<Vector2>(),Input.GetMouseButton(0));
        }

        public void HandleCleanerInput(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnCleanerStart?.Invoke();
            }
            
            if (context.performed)
            {
                OnCleanerPerform?.Invoke();
            }
            
            if (context.canceled)
            {
                OnCleanerEnd?.Invoke();
            }
            
        }

        public void HandleSwitchTool(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                OnSwitchTool?.Invoke();
            }
        }
    }
}
