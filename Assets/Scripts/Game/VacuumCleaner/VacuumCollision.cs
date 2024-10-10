using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumCollision : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (IsVacuumable(other))
        {
            
        }
    }

    private static bool IsVacuumable(Collider other)
    {
        IVacuumable vacuumable = other.GetComponent<IVacuumable>();

        return vacuumable != null;
    }
}
