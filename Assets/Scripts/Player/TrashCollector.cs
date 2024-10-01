using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (IsVacuumable(other))
        {
            other.gameObject.transform.parent.gameObject.SetActive(false);
            Trash trash = other.gameObject.transform.parent.GetComponent<Trash>();
            trash.OnDestroy.Invoke(trash);
            //GameManager.GetInstance().garbage.Remove();
            //other.gameObject.SetActive(false);
            Debug.Log("Trash was Collected");
        }
    }

    private bool IsVacuumable(Collider other)
    {
        IVacuumable vacuumable = other.GetComponentInParent<IVacuumable>();

        return vacuumable != null;
    }
}