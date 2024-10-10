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

        public void PowerOn()
        {
            OnPowerOn?.Invoke();
        }

        public void PowerOff()
        {
            OnPowerOff?.Invoke();
        }
    }
}
