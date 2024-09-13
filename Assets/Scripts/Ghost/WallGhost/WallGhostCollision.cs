using System;
using UnityEngine;

namespace Ghost.WallGhost
{
    public class WallGhostCollision : MonoBehaviour
    {
        public Action OnPlayerCollision;
        private void OnTriggerEnter(Collider other)
        {
            if (IsPlayerCollision(other))
            {
                OnPlayerCollision?.Invoke();
            }
        }

        private static bool IsPlayerCollision(Collider other)
        {
            return other.gameObject.layer == LayerMask.NameToLayer($"Player");
        }
    }
}
