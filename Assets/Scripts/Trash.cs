using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, IVacuumable
{
    public void IsBeingVacuumed(params object[] args)
    {
        var rb = GetComponent<Rigidbody>();

        var direction = ((Vector3)args[0] - transform.position).normalized;
            
        rb.AddForce(direction * (float)args[1], ForceMode.VelocityChange);
    }
}
