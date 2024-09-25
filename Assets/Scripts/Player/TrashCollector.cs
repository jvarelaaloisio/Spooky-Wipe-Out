using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (IsVacuumable(other))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Trash was Collected");
        }
    }

    private bool IsVacuumable(Collider other)
    {
        IVacuumable vacuumable = other.GetComponent<IVacuumable>();

        return vacuumable != null;
    }
}