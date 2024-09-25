using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Trash : MonoBehaviour, IVacuumable
{
    [SerializeField] private GameObject model;
    

    public void IsBeingVacuumed(params object[] args)
    {
        var rb = GetComponentInChildren<Rigidbody>();

        var direction = ((Vector3)args[0] - model.transform.position).normalized;
            
        rb.AddForce(direction * (float)args[1], ForceMode.VelocityChange);
    }
}
