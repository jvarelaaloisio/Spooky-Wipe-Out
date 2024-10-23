using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class GhostFlee : MonoBehaviour, IRest
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _fleeSpeed = 5f;

    private NavMeshAgent _agent;
    private float _fleeSpeedDeltaTimed;

    private float minScapeDistance = 40.0f;
    private float maxScapeDistance = 45.0f;

    private int maxAttempts = 30;

    public UnityEvent<bool> SetRestState { get; set; } = new UnityEvent<bool>();

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {
        _agent.ResetPath();
    }

    private void FixedUpdate()
    {
        _fleeSpeedDeltaTimed = _fleeSpeed * Time.deltaTime;

        if(_agent.remainingDistance < 0.5f)
        {
            Flee();
        }
    }

    private void Flee()
    {
        _agent.speed = _fleeSpeedDeltaTimed;
        _agent.SetDestination(GetRandomScapePoint());
    }

    private Vector3 GetRandomScapePoint()
    {
        NavMeshHit navMeshHit;
        int attempts = 0;

        while (attempts < maxAttempts)
        {
            Vector3 randomDirection = Random.insideUnitSphere.normalized;

            float randomScapeDistance = Random.Range(minScapeDistance, maxScapeDistance);

            randomDirection *= randomScapeDistance;
            randomDirection += this.gameObject.transform.position;

            if(NavMesh.SamplePosition(randomDirection, out navMeshHit, maxScapeDistance, NavMesh.AllAreas))
            {
                return navMeshHit.position;
            }

            attempts++;
        }

        return this.gameObject.transform.position;
    }
}
