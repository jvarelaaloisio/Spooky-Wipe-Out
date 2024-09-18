using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vacuum : MonoBehaviour, ITool
{
    public event Action OnPowerOn;
    public event Action OnPowerOff;

    private void OnTriggerStay(Collider other)
    {
        if(IsVacuumable(other))
        {
            other.GetComponent<IVacuumable>().IsBeingVacuumed();
        }
    }

    public void PowerOn()
    {
        
    }

    private static bool IsVacuumable(Collider other)
    {
        IVacuumable vacuumable = other.GetComponent<IVacuumable>();

        return vacuumable != null;
    }

    public void PowerOff()
    {
        throw new System.NotImplementedException();
    }
}
