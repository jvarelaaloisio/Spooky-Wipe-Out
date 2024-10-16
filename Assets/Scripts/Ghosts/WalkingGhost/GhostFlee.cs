using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostFlee : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _fleeSpeed = 5f;

    private NavMeshAgent _agent;
    private float _fleeSpeedDeltaTimed;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        //_fleeSpeedDeltaTimed = _fleeSpeed * Time.deltaTime;

        Flee();
    }

    private void Flee()
    {
        Vector3 directionToPlayer = transform.position - _player.position;
        Vector3 fleeDirection = transform.position + directionToPlayer.normalized;

        _agent.speed = _fleeSpeed;
        _agent.Move(fleeDirection);
    }
}
