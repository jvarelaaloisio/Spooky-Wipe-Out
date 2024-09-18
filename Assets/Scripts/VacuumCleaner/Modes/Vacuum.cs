using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vacuum : MonoBehaviour, IVacuumMode
{
    private void OnTriggerStay(Collider other)
    {
        if(IsVacuumable(other))
        {
            other.GetComponent<IVacuumable>().IsBeingVacuumed();
        }
    }

    public void Use()
    {
        
    }

    private static bool IsVacuumable(Collider other)
    {
        IVacuumable vacuumable = other.GetComponent<IVacuumable>();

        return vacuumable != null;
    }
}
