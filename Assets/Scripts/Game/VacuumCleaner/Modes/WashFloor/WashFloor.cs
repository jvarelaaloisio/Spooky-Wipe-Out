using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VacuumCleaner.Modes
{
    public class WashFloor : MonoBehaviour, ITool
    {
        public event Action OnPowerOn;
        public event Action OnPowerOff;
        
        [SerializeField] WashFloorColision washFloorColision;

        public void PowerOn()
        {
            washFloorColision.gameObject.SetActive(true);
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            washFloorColision.gameObject.SetActive(false);
            OnPowerOff?.Invoke();
        }
    }
}
