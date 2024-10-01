using System;
using Fsm_Mk2;
using UnityEngine;

namespace Ghosts.WallGhost
{
    public class WallGhostCollision : MonoBehaviour
    {
        [SerializeField] private Transform trappingPos;
        
        public Action OnPlayerCollision;
        private GameObject _player;
        
        private void OnTriggerEnter(Collider other)
        {
            if (IsPlayerCollision(other))
            {
                OnPlayerCollision?.Invoke();
                SetPlayerAction(other);
            }
        }

        private static bool IsPlayerCollision(Collider other)
        {
            return other.gameObject.layer == LayerMask.NameToLayer($"Player");
        }

        private void SetPlayerAction(Collider other)
        {
            _player = other.gameObject;
            _player.GetComponentInParent<PlayerAgent>().OnHunted.Invoke(trappingPos);
        }
    }
}
